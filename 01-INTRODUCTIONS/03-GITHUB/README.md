# Git and GitHub

Git is a distributed version-control system. GitHub is a hosting and collaboration platform built around Git repositories.

## Learning path

| # | Topic |
|---:|---|
| 01 | [Git Basics](./01-GIT-BASICS/) |
| 02 | [Clone, Add, Commit, Push](./02-CLONE-ADD-COMMIT-PUSH/) |
| 03 | [Branches](./03-BRANCHES/) |
| 04 | [Merging](./04-MERGING/) |
| 05 | [Merge Conflicts](./05-MERGE-CONFLICTS/) |
| 06 | [Pull Requests](./06-PULL-REQUESTS/) |
| 07 | [.gitignore](./07-GITIGNORE/) |
| 08 | [Undo and Restore](./08-UNDO-AND-RESTORE/) |
| 09 | [GitHub Issues](./09-GITHUB-ISSUES/) |
| 10 | [GitHub Actions Introduction](./10-GITHUB-ACTIONS-INTRO/) |

## Git vs GitHub

- **Git** tracks changes locally and supports branching, merging, and history.
- **GitHub** hosts Git repositories and adds collaboration features such as pull requests, issues, code review, and Actions.

## Basic workflow

```bash
git clone <repository-url>
git status
git add .
git commit -m "Describe the change"
git push
```

Always inspect `git status` before committing and avoid committing secrets, environment files, generated caches, or private credentials.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026

