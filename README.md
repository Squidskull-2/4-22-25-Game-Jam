# 4-22-25-Game-Jam | Music Meister
MSCH-C220 Game Jam, April 2025

## Theme
We interpreted the theme "You only have one" as only having one life. Hence, the player must traverse the dangerous terrain without making any mistakes. Furthermore, there is only one long level where the player stands out as the only one with color.
We decided on a music-based concept; the player is a conductor, and the enemies are music notes.

## Game Play
The objective is to reach the end of the level while avoiding death from dangerous obstacles and a variety of enemies.

Use keys A and D to move left and right. Use the spacebar to jump. Jump on top of enemies to kill them. Use a quick combination of the spacebar and A or D to perform a wall jump. 

## Impediments
- All of the enemy behaviors were coded using C# scripts instead of Visual Scripting, so it took some time to get used to figuring out how to get everything working the way that we intended it to.
- Adding the final touches and polishing everything took a lot of tweaking and time. There are many things we wanted to implement, but didn’t have time to do so. 

## Implementation
Features:
- 3 different enemy types with various behaviors. A normal enemy that moves away when the player approaches, a charging enemy that runs toward the player when close, and a projectile enemy that shoots bullets at the player. 
- Enemies produce musical sounds when killed.
- Dangerous obstacles such as spikes and spiked cubes, that kill the player when touched.
- Player character drawn and animated with an idle, walk, and jump animation.
- Main and end menu designed with shader graphs, TextMeshPro, and particle systems.
- Large and elaborate gameplay level.

## References
- Buttons: https://kenney.nl/assets/fantasy-ui-borders by Kenney
- Font "Bloomington": https://www.dafont.com/bloomington.font by M. Libby
- Platformer Blocks/art: https://kenney.nl/assets/scribble-platformer by Kenney
- Character Controller: https://github.com/SebLague/2DPlatformer-Tutorial by SebLague
- Sounds: [Level Complete sound](https://uppbeat.io/sfx/level-complete-winner-piano/13107/32372), all other sounds created by Violet.

## Future Development

# Created by: Music Meister
- Matthew Sheldon
  - Programmed enemy behaviors.
  - Primary programmer.
- Blayne 
  - Drew character, enemy, and background sprites.
  - Implemented animations.
- Violet 
  - Sound Design.
  - Composed the music and sound effects.
- Angela Tan
  - Added main menu and end screen.
  - Designed the gameplay level.

