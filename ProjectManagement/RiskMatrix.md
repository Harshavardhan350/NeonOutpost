# Neon Outpost Risk Matrix
| Risk | Likelihood | Impact | Mitigation |
|---|---|---|---|
| Feature creep (new weapons requested mid-sprint) | High | Medium | Freeze sprint scope; place new requests in next sprint's backlog. |
| Unity scene merge conflicts | Medium | High | Assign scene ownership, use prefabs, and commit frequently. |
| CI build fails due to Unity activation/license | High | High | Configure required GitHub Secrets and run a test workflow early. |
| Two-week scope is unrealistic | Medium | High | Build only Must stories first; move lower-priority stories out. |
| Enemy AI has bugs or poor performance | Medium | High | Test detection limits and many-enemy scenarios in Unity. |
| A team member accidentally pushes to main | Medium | Medium | Require PR workflow and enable branch protection when available. |
