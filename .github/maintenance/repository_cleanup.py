#!/usr/bin/env python3
import hashlib, re, shutil
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
TEXT={".md",".py",".cs",".kt",".html",".css",".js",".txt",".yml",".yaml",".json",".xml",".toml",".ini",".cfg"}

def txt(p):
    if p.name==".gitignore" or p.suffix.lower() in TEXT: return True
    if p.suffix=="":
        try: p.read_text(encoding="utf-8"); return True
        except: return False
    return False
def r(p): return p.read_text(encoding="utf-8")
def w(p,s): p.parent.mkdir(parents=True,exist_ok=True); p.write_text(s.rstrip()+"\n",encoding="utf-8")
def mv(a,b):
    if not a.exists(): return
    b.parent.mkdir(parents=True,exist_ok=True)
    if b.exists(): raise RuntimeError(str(b))
    shutil.move(str(a),str(b))
def h(p):
    q=hashlib.sha256()
    with p.open("rb") as f:
        for c in iter(lambda:f.read(1048576),b""): q.update(c)
    return q.hexdigest()
def slug(n):
    p=Path(n); return re.sub(r"[^a-z0-9]+","-",p.stem.lower()).strip("-")+p.suffix.lower()

def csharp():
    fence=chr(96)*3
    for p in (ROOT/"01-INTRODUCTIONS").rglob("*.cs"):
        t=r(p); out=[]
        for line in t.splitlines():
            if line.strip().lower() in {fence,fence+"csharp",fence+"cs"}: continue
            out.append(re.sub(r"^(\s*)#\s*/\*",r"\1/*",line))
        n="\n".join(out)
        if n!=t: w(p,n)

def metadata():
    bad=("250161@upbc.edu.mx","mxli.peyman@gmail.com","+526865090453")
    for p in ROOT.rglob("*"):
        if not p.is_file() or ".git" in p.parts or ".github" in p.parts or not txt(p): continue
        try: t=r(p)
        except: continue
        out=[]; ch=False
        for line in t.splitlines():
            if any(x.lower() in line.lower() for x in bad) or re.search(r"(student\s+id|id)\s*[:=-]?\s*250161\b",line,re.I):
                ch=True; continue
            out.append(line)
        if ch: w(p,re.sub(r"\n{4,}","\n\n\n","\n".join(out)))

def projects():
    b=ROOT/"02-PROJECTS"
    ren={"01-PROJECT-CLI-CALCULATOR":"01-CLI-CALCULATOR","03-VEHICLE-M-S":"03-VEHICLE-MANAGEMENT-SYSTEM","05-BIBLOTECA-POO":"05-LIBRARY-OOP","06-VETERINARIA-POO":"06-VETERINARY-OOP","07-zoo_poo":"07-ZOO-OOP"}
    for a,z in ren.items():
        if (b/a).exists() and not (b/z).exists(): mv(b/a,b/z)
    v=b/"03-VEHICLE-MANAGEMENT-SYSTEM"; q=v/"01-vehicle-management-system"/"vehiculos_dashboard"
    if q.exists():
        for x in list(q.iterdir()): mv(x,v/("IMPLEMENTATION.md" if x.name=="README.md" else x.name))
        shutil.rmtree(v/"01-vehicle-management-system",ignore_errors=True)
    a=ROOT/"03-CSHARP-PROJECTS/01-STUDENT-MANAGEMENT-SYSTEM/1.png"; z=a.with_name("student-management-system-console.png")
    if a.exists() and not z.exists(): mv(a,z)

def unitrack():
    b=ROOT/"02-PROJECTS/04-UNITRACK"; A=b/"Static"; s=b/"static"
    if A.exists() and not s.exists():
        t=b/"__static_tmp__"; mv(A,t); mv(t,s)
    a=s/"css/Style.css.txt"; z=s/"css/style.css"
    if a.exists() and not z.exists(): mv(a,z)
    app=b/"app.py"
    if app.exists():
        t=r(app)
        if "import secrets" not in t: t=t.replace("import os\n","import os\nimport secrets\n")
        t=t.replace('BASE_DIR / "Static" / "uploads"','BASE_DIR / "static" / "uploads"')
        t=t.replace('os.environ.get("UNITRACK_SECRET_KEY", "dev-only-change-me")','os.environ.get("UNITRACK_SECRET_KEY") or secrets.token_hex(32)')
        w(app,t)
    shutil.rmtree(b/"Texts",ignore_errors=True)
    up=s/"uploads"; up.mkdir(parents=True,exist_ok=True)
    for x in list(up.iterdir()):
        if x.is_dir(): shutil.rmtree(x)
        elif x.name!=".gitkeep": x.unlink()
    w(up/".gitkeep","")
    ph=b/"Photos"; d=b/"docs/assets/screenshots"; d.mkdir(parents=True,exist_ok=True)
    hashes={h(x) for x in (s/"images").rglob("*") if x.is_file()} if (s/"images").exists() else set()
    if ph.exists():
        for x in sorted(ph.rglob("*")):
            if not x.is_file() or h(x) in hashes: continue
            name=slug(x.name); dest=d/name; i=2
            while dest.exists(): dest=d/(Path(name).stem+"-"+str(i)+Path(name).suffix); i+=1
            mv(x,dest)
        shutil.rmtree(ph,ignore_errors=True)
    docs=b/"docs"; docs.mkdir(parents=True,exist_ok=True)
    for a,z in {"Propuesta de Proyecto.docx":"project-proposal.docx","Workshop_ Plan de Diseño primer plan de nuestro appliacion  .docx":"design-plan.docx","sobre app.docx":"app-overview.docx"}.items():
        if (b/a).exists() and not (docs/z).exists(): mv(b/a,docs/z)

def kotlin():
    k=ROOT/"01-INTRODUCTIONS/10-KOTLIN/00-KOTLIN-IN-INTELLIJ"
    w(k/"Notes.kt",'/* IntelliJ, JDK, JVM, Gradle, run and debug. */\nfun main(){ println("Kotlin environment ready") }')
    w(k/"Examples.kt",'fun main(){ val ide="IntelliJ IDEA"; println("$ide + Kotlin") }')
    w(k/"Tasks.kt",'/* Create project, verify JDK, run and debug. */\nfun main(){ }')
    w(k/"Tasks_Solutions.kt",'fun main(){ println("IntelliJ configured"); println("Kotlin executed") }')
    k=ROOT/"01-INTRODUCTIONS/10-KOTLIN/01-INTRODUCTION-TO-KOTLIN"
    if (k/"Tasks").exists() and not (k/"Tasks.md").exists(): mv(k/"Tasks",k/"Tasks.md")
    w(k/"Tasks.kt",'/* Print Hello World and use variables/string templates. */\nfun main(){ }')
    w(k/"Tasks_Solutions.kt",'fun main(){ val language="Kotlin"; println("Hello, World! $language") }')

def python_names():
    b=ROOT/"01-INTRODUCTIONS/02-PYTHON"; m=[]
    for p in sorted(b.rglob("*")):
        if p.is_file() and not p.suffix:
            z=p.with_name(p.name+(".py" if "MODULES" in p.parts else ".md"))
            if not z.exists(): m.append((p,z))
    for a,z in m: mv(a,z)
    for a,z in m:
        for f in (z.parent,z.parent.parent):
            if f.exists():
                for md in f.glob("*.md"):
                    t=r(md); n=t.replace(a.name,z.name)
                    if n!=t: w(md,n)

def motor():
    p=ROOT/"02-PROJECTS/03-VEHICLE-MANAGEMENT-SYSTEM/app/servicios/motor.py"
    if p.exists() and not r(p).strip(): p.unlink()
    if p.parent.exists() and not any(p.parent.iterdir()): p.parent.rmdir()

def refs():
    d={"01-PROJECT-CLI-CALCULATOR":"01-CLI-CALCULATOR","03-VEHICLE-M-S":"03-VEHICLE-MANAGEMENT-SYSTEM","05-BIBLOTECA-POO":"05-LIBRARY-OOP","06-VETERINARIA-POO":"06-VETERINARY-OOP","07-zoo_poo":"07-ZOO-OOP","Static/":"static/","1.png":"student-management-system-console.png"}
    for p in ROOT.rglob("*"):
        if not p.is_file() or ".git" in p.parts or ".github" in p.parts or not txt(p): continue
        try: t=r(p)
        except: continue
        n=t
        for a,z in d.items(): n=n.replace(a,z)
        if n!=t: w(p,n)

def main():
    csharp(); metadata(); projects(); unitrack(); kotlin(); python_names(); motor(); refs(); metadata()
if __name__=="__main__": main()
