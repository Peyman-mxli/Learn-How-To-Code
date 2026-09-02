# How Git and GitHub Work

Git is the version-control system. GitHub is a remote hosting and collaboration platform built around Git repositories.

## Commit

A commit is a recorded snapshot of staged changes.

```bash
git add .
git commit -m "Add variables module notes"
```

Good commits are small, focused, and described clearly.

## Branch

A branch is an independent line of development.

Create and switch to a branch:

```bash
git switch -c feature/example
```

Older Git versions also support:

```bash
git checkout -b feature/example
```

## Push

Upload the branch to GitHub:

```bash
git push -u origin feature/example
```

## Pull request

A pull request proposes merging one branch into another. It supports:

- code review;
- discussion;
- automated checks;
- approval;
- merge history.

## Typical professional workflow

```text
main
  └── feature/example
        ├── edit files
        ├── test changes
        ├── commit
        ├── push
        └── open pull request
              └── review + checks
                    └── merge
```

## Common commands

| Action | Command |
|---|---|
| Check status | `git status` |
| Stage changes | `git add .` |
| Commit | `git commit -m "message"` |
| Create branch | `git switch -c branch-name` |
| Switch branch | `git switch branch-name` |
| Push | `git push` |
| Pull | `git pull` |
| View history | `git log --oneline` |

## Best practices

- inspect `git status` before committing;
- avoid committing secrets or local environment files;
- use meaningful commit messages;
- keep commits focused;
- pull/rebase before pushing when collaborating;
- protect the default branch for team projects.

## Author

**Peyman Miyandashti**  
Information Technology Engineering & Digital Innovation  
Polytechnic University of Baja California  
Mexico · 2026
