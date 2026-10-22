# Neon Outpost — Two-Week Sprint Backlog
**Sprint goal:** Deliver a testable core survival loop: move, detect/chase player, and spawn enemy waves.
**Sprint length:** 2 weeks. **Team:** 2 programmers, 1 artist, 1 designer.

| ID | User story | Acceptance criteria (testable) | Points | MoSCoW |
|---|---|---|---:|---|
| US-01 | As a player, I want to move around the arena so that I can dodge enemies. | WASD moves the player; movement is limited to the arena. | 3 | Must |
| US-02 | As a player, I want enemies to chase me so that I feel challenged. | Enemy starts chasing within 5 units; moves toward player at speed 3; stops beyond 10 units. | 3 | Must |
| US-03 | As a player, I want enemy waves so that the challenge increases over time. | First wave spawns 5 enemies; next wave begins after all current enemies are defeated. | 5 | Must |
| US-04 | As a player, I want to fire projectiles so that I can defend the base. | Space fires a projectile; projectile damages an enemy on contact. | 3 | Must |
| US-05 | As a player, I want a health display so that I know when I am in danger. | Health appears on screen; incoming damage reduces the visible value. | 2 | Should |
| US-06 | As a player, I want scrap drops so that I can earn upgrades. | Defeated enemies can drop scrap; collecting scrap increases the counter. | 5 | Should |
| US-07 | As a player, I want sound feedback so that shots and hits feel clear. | Shooting plays a sound; enemy hits play a different sound. | 2 | Could |
| US-08 | As a player, I want a weapon upgrade menu so that I can improve between waves. | Menu opens between waves; buying an upgrade deducts scrap and changes weapon stats. | 8 | Won't (this sprint) |

**Sprint priority:** Complete Must stories before Should; do not start Won't stories during this sprint.
**Note:** This is the planned backlog, not a claim that every story is implemented.
