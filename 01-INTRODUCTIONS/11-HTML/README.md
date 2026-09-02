# HTML — Complete Foundations Curriculum

A professional HTML learning path built with the same workflow used throughout this repository for Python, C#, and Kotlin:

**README → Notes → Examples → Tasks → Solutions → Validation → Project**

HTML is the markup language of the web. This track develops standards-based structure, semantics, accessibility, navigation, media, forms, metadata, debugging, responsive foundations, privacy/security awareness, and complete projects before introducing CSS or JavaScript.

## Learning outcomes

After completing this track, I should be able to:

- create standards-based HTML5 documents from memory;
- explain the document tree and the browser DOM;
- select semantic elements based on meaning rather than appearance;
- create accessible links, navigation, images, tables, forms, and media;
- reason correctly about relative file/resource paths;
- use browser DevTools to inspect and debug markup;
- create useful metadata and understand SEO foundations;
- recognize common HTML-level privacy and security concerns;
- use responsive image/document foundations correctly;
- validate markup and catch structural mistakes;
- build complete semantic pages that remain useful without CSS;
- move into CSS and JavaScript with strong HTML fundamentals.

## Curriculum

| # | Module | Focus |
|---:|---|---|
| 00 | [HTML in VS Code](./00-HTML-IN-VSCODE/) | Editor/browser workflow, DevTools, Emmet, validation |
| 01 | [Document Structure](./01-DOCUMENT-STRUCTURE/) | DOCTYPE, html, head, metadata, body |
| 02 | [Text Semantics](./02-TEXT-SEMANTICS/) | Headings, paragraphs, emphasis, quotations, code |
| 03 | [Links and Navigation](./03-LINKS-NAVIGATION/) | Relative/absolute links, fragments, nav |
| 04 | [Images and Paths](./04-IMAGES-PATHS/) | Images, alt text, figures, resource paths |
| 05 | [Lists](./05-LISTS/) | Ordered, unordered, description, nested lists |
| 06 | [Tables](./06-TABLES/) | Accessible data tables, captions, headers, scope |
| 07 | [Forms and Inputs](./07-FORMS-INPUTS/) | Labels, controls, fieldsets, native validation |
| 08 | [Semantic HTML](./08-SEMANTIC-HTML/) | Landmarks and content-sectioning elements |
| 09 | [Containers and Global Attributes](./09-CONTAINERS-GLOBAL-ATTRIBUTES/) | div/span, id/class, lang, data attributes |
| 10 | [Audio and Video](./10-MEDIA/) | Native media, sources, captions awareness |
| 11 | [Iframes and Embedded Content](./11-IFRAMES-EMBEDDED-CONTENT/) | Titles, sandbox, lazy loading, privacy |
| 12 | [Metadata and SEO Foundations](./12-METADATA-SEO/) | Titles, descriptions, canonical/robots/social concepts |
| 13 | [Accessibility Foundations](./13-ACCESSIBILITY/) | Native semantics, keyboard, labels, ARIA discipline |
| 14 | [Entities and Symbols](./14-ENTITIES-SYMBOLS/) | Reserved characters, Unicode, entities |
| 15 | [Validation and Debugging](./15-VALIDATION-DEBUGGING/) | Validators, DevTools, source vs DOM |
| 16 | [Responsive HTML Foundations](./16-RESPONSIVE-HTML/) | Viewport, picture/source, responsive image concepts |
| 17 | [Security and Privacy Foundations](./17-HTML-SECURITY-PRIVACY/) | HTTPS, forms, embeds, untrusted HTML |
| 18 | [Project — Personal Profile](./18-PROJECT-PERSONAL-PROFILE/) | Semantic personal portfolio/profile capstone |
| 19 | [Project — Semantic Landing Page](./19-PROJECT-SEMANTIC-LANDING-PAGE/) | Semantic landing page capstone |
| 20 | [Next Steps — CSS and JavaScript](./20-NEXT-STEPS-CSS-JS/) | Roadmap to CSS, JavaScript, testing, frameworks |

## Standard module structure

Each module uses the same predictable learning structure:

    NN-TOPIC/
    ├── README.md
    ├── Notes.md
    ├── Examples.html
    ├── Tasks.md
    └── Tasks_Solutions.html

This mirrors the repository's existing learning workflow: study first, run examples, solve independently, review the solution, then validate.

## Study workflow

1. Read the module README.
2. Study the notes.
3. Open Examples.html in a browser.
4. Inspect the DOM with browser DevTools.
5. Complete Tasks.md without opening the solution.
6. Compare with Tasks_Solutions.html.
7. Modify the example and intentionally test edge cases.
8. Run repository HTML validation.
9. Commit progress with a descriptive Git message.

## Baseline professional HTML document

Every standalone page should normally begin with:

    <!doctype html>
    <html lang="en">
    <head>
      <meta charset="utf-8">
      <meta name="viewport" content="width=device-width, initial-scale=1">
      <title>Descriptive page title</title>
    </head>
    <body>
      <main>
        <h1>Meaningful page heading</h1>
      </main>
    </body>
    </html>

## Core principles

### 1. Structure before style

HTML describes content structure and meaning. CSS is responsible for presentation and layout.

### 2. Native semantics before generic containers

Prefer elements such as header, nav, main, section, article, aside, footer, button, table, label, and form when they accurately represent the content.

### 3. Accessibility is part of correct HTML

Accessible names, labels, alt text, logical headings, keyboard operability, document language, and meaningful links are not optional finishing touches.

### 4. Browser tolerance is not validity

Browsers repair malformed markup. A page that appears to work may still be structurally wrong. Validate and inspect both source and DOM.

### 5. Client-side markup is not a security boundary

HTML validation attributes improve usability but do not replace server-side validation, authorization, escaping, sanitization, or secure transport.

## Separation of concerns

**HTML** → structure and semantics  
**CSS** → presentation and layout  
**JavaScript** → behavior and application logic

Learning these responsibilities separately makes frameworks easier later because frameworks still generate HTML, CSS, and JavaScript.

## Capstone projects

### Module 18 — Personal Profile

Combines semantic navigation, structured sections, lists, tables, projects, and an accessible contact form.

### Module 19 — Semantic Landing Page

Combines hero content, features, workflow, FAQ, calls to action, and a complete page outline.

Both projects should remain understandable and useful before any CSS is added.

## Validation

The repository includes an automated HTML quality checker that verifies module structure and important document-level requirements. Browser DevTools and standards validators should still be used during study because no small local script can replace full browser/standards testing.

## Definition of completion

I consider this HTML track complete when:

- all modules 00–20 are studied;
- tasks are completed independently;
- both capstones are built;
- HTML quality checks pass;
- I can explain semantic choices without relying on memorized snippets;
- I can create a new standards-based page from an empty file.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
