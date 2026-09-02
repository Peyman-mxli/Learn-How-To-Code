# Install Git and Connect to GitHub

GitHub itself is a web service; the local tool you install is **Git**.

## 1. Create a GitHub account

Create and verify an account on GitHub.

## 2. Install Git

Download Git from the official Git website for your operating system.

Verify:

```bash
git --version
```

## 3. Configure identity

Set the name and email you want recorded in Git commits:

```bash
git config --global user.name "Your Name"
git config --global user.email "your-email@example.com"
```

This is commit metadata. It is not a GitHub password.

## 4. Authenticate with GitHub

Recommended methods include:

- GitHub CLI authentication;
- SSH keys;
- HTTPS with Git Credential Manager.

Passwords are not used for Git operations over HTTPS.

## 5. Clone a repository

```bash
git clone https://github.com/USERNAME/REPOSITORY.git
cd REPOSITORY
```

## 6. Basic workflow

```bash
git status
git add .
git commit -m "Describe the change"
git push
```

## Verify the remote

```bash
git remote -v
```

## Common mistakes

- installing GitHub Desktop but not understanding Git;
- using the wrong repository directory;
- committing secrets or `.env` files;
- forgetting to stage files;
- committing without checking `git status`;
- pushing directly to a protected default branch.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
