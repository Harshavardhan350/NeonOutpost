# Neon Outpost Git Workflow

**Model:** Feature branching.
- `main`: production-ready baseline, protected in team use; do not push changes directly.
- `develop`: integration branch for tested features.
- `feature/*`: one branch per story, e.g., `feature/enemy-chase`, `feature/wave-spawner`.
- `hotfix/*`: urgent production corrections branched from `main`.

**Merge policy:** In team use, require at least one teammate review and passing CI build/tests before merge. For this solo lab, demonstrate a GitHub Pull Request and record whether CI actually passed. Prefer `--no-ff` local merges to preserve branch history when following the lab handout.

**Commit prefixes:** `feat:` new feature, `fix:` bug fix, `chore:` maintenance, `docs:` documentation, `ci:` automation.

**Workflow:** Branch from `develop` → edit and test Unity script → commit → push → sync with `develop` → open PR targeting `develop` → review/check CI → merge → repeat.
