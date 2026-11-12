
# Tic-Tac-Toe Game (C# Windows Forms)

A two-player Tic-Tac-Toe game for Windows, built with C# and Windows Forms. Two players take turns on the same computer, and the game detects the winner or a draw automatically.

## Features

- Two players on one computer: **Player 1 plays X** and **Player 2 plays O**.
- The current player is always shown in the **Turn** label.
- The **Winner** label shows the game state: `In Progress`, `Player 1 Wins`, `Player 2 Wins`, or `Draw !`.
- The three winning cells are highlighted in green, and a "Game Over" message appears when someone wins.
- A cell that is already taken cannot be overwritten.
- Click **Restart Game** at any time to clear the board and start a new round.
- The 3x3 grid lines are drawn in code with GDI+.

## How to Play

1. Player 1 clicks any empty cell to place an X.
2. Player 2 clicks any empty cell to place an O.
3. Keep taking turns. The first player to get three marks in a row (horizontal, vertical, or diagonal) wins.
4. If all nine cells are filled and nobody has three in a row, the game ends in a draw.
5. Click **Restart Game** to play again.

## How It Works

- The board is nine `PictureBox` controls (`picbox1` to `picbox9`). Each cell's `Tag` property stores its state: `"?"` for empty, `"X"`, or `"O"`.
- All nine click handlers call the same two methods: `Player1and2Turn` places the mark for the current player and switches the turn, then `IsWinner` checks the board.
- `IsWinner` checks the 8 winning lines through `CheckValues`: three rows (1-2-3, 4-5-6, 7-8-9), three columns (1-4-7, 2-5-8, 3-6-9), and two diagonals (1-5-9, 3-5-7).
- A draw is detected when no cell is left with the `"?"` tag.
- `Form1_Paint` draws the board lines with a white round-capped pen.
- Restart resets every cell's image, tag, and background color, then sets the turn back to Player 1.

## Project Structure

```
Tic Tac Toe Game.slnx
Tic Tac Toe Game/
├── Program.cs              # Entry point: runs Form1
├── Form1.cs                # Game logic and event handlers
├── Form1.Designer.cs       # Designer-generated UI layout
├── Form1.resx              # Form resources
├── App.config
├── Properties/             # Assembly info, resources, and settings
└── Resources/              # X and O mark images and the empty-cell image
```

## Technologies

- C#
- .NET Framework 4.7.2
- Windows Forms

## Concepts Practiced

- Windows Forms controls and events (`PictureBox.Click`, `Label.Click`, `Paint`).
- Sharing one piece of logic between many controls using the `sender` parameter.
- Using the `Tag` property to store state on a control.
- Drawing with `Graphics` and `Pen` in the `Paint` event.
- Embedding images as project resources.

## Author

[abdrhmnKH](https://github.com/abdrhmnKH)
