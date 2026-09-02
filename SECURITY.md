# Security Policy

This repository is a public educational portfolio.

## Do not commit

- passwords;
- API keys;
- Flask/Django secret keys;
- private administrator codes;
- `.env` files;
- personal user databases;
- authentication cookies/tokens;
- private student or customer records.

Use environment variables and commit only safe templates such as `.env.example`.

## Reporting a problem

If a credential is accidentally committed, it should be considered exposed and rotated immediately. Removing it from the latest commit is not sufficient by itself because Git history may still contain it.

## Educational scope

Several projects in this repository are learning prototypes. They should not be treated as production systems without additional security review, testing, authorization controls, validation, logging, and deployment hardening.
