# Snake.IO-Game
A Snake game build using C#, A  winForm Application Game

# Snake Game – C# Windows Forms

Project Overview
This is a classic Snake Game developed using C# Windows Forms. The project focuses on simplicity, clean visuals, and beginner-friendly game logic without using advanced graphics libraries.

Design Choices
The game uses Windows Forms Panel controls to represent the snake and food. Each panel acts as one grid cell, making movement and collision detection easy to manage.
Panels are shown and hidden instead of opening multiple forms to keep the game smooth and easy to control.

Game Layout
The application includes:

* A main menu with Start, Level Select, and Exit options
* A level selection panel with Easy, Medium, and Hard modes
* A game panel where the snake moves
* A side panel showing score, high score, level, and pause control

Game Logic
The snake is stored as a list of panels, with each panel representing a body segment.
A timer is used as the game loop, moving the snake step by step based on the selected difficulty.

Difficulty Levels
Easy: Slow speed with wall wrap-around
Medium: Faster speed, wall collision ends the game
Hard: Fastest speed for higher challenge

Controls
Arrow keys or W A S D are used to move the snake.
Reverse movement is restricted to avoid instant collision.
The game can be paused and resumed during play.

Performance
Double buffering is enabled to reduce flickering.
Only necessary UI elements are updated during gameplay to keep the game responsive.

Customization
Players can change the snake color from the menu.
Score and high score are displayed on the game screen.

Conclusion
This project demonstrates basic game development concepts using C# Windows Forms, including event handling, timers, UI management, and simple game logic.

# Author
# Rana Haider Ali Khan

---
