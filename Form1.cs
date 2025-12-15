using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakegameproject
{
    public enum FruitType
    {
        Apple = 10,
        Orange = 20,
        Banana = 30,
        Grape = 50
    }

    public partial class Form1 : Form
    {
        // Game constants
        static private int CellSize = 20;
        static private int GridCells = 30;      // virtual grid size (will adapt to panel)
        static private int GamePanelSize = CellSize * GridCells; // 600

        // Game state - use lightweight data (points) instead of Controls to improve perf
        private List<Point> snake = new List<Point>();
        private Point currentDirection = new Point(1, 0); // start moving right
        private Point nextDirection = new Point(1, 0); // buffered input to avoid missed keys
        private Random rnd = new Random();
        private Point? foodPosition = null;
        private FruitType currentFruitType = FruitType.Apple;
        private bool isGameRunning = false;
        private bool isPaused = false;
        private int score = 0;
        private int highScore = 0;
        private int gameInterval = 200; // default easy

        //snake color
        private Color snakeBodyColor = Color.DodgerBlue;
        private Color snakeHeadColor = Color.DarkBlue;

        private readonly Dictionary<FruitType, Color> fruitColors = new Dictionary<FruitType, Color>
        {
            { FruitType.Apple, Color.Red },
            { FruitType.Orange, Color.Orange },
            { FruitType.Banana, Color.Yellow },
            { FruitType.Grape, Color.Purple }
        };

        public Form1()
        {
            InitializeComponent();

            // Enable double-buffering for smooth rendering on the form
            this.DoubleBuffered = true;

            // Enable double buffering on the game panel (protected property) via reflection
            var prop = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            if (prop != null)
                prop.SetValue(pnl_gamepanel, true, null);

            InitCustom(); // extra initialization
        }

        private void InitCustom()
        {
            this.KeyPreview = true; // capture keys at form level
            GridCells = 30; // fixed grid size for simplicity
            ResetToMenuState();
        }

        #region Game Logic

        private void StartNewGame()
        {
            // Reset state
            snake.Clear();
            foodPosition = null;

            score = 0;
            UpdateScoreLabel();

            currentDirection = new Point(1, 0);
            nextDirection = new Point(1, 0);
            isPaused = false;
            isGameRunning = true;
            btn_pause.Text = "Pause";

            // Create snake at center (as Points)
            int startX = (pnl_gamepanel.Width / CellSize) / 2;
            int startY = (pnl_gamepanel.Height / CellSize) / 2;

            for (int i = 0; i < 4; i++)
            {
                snake.Add(new Point(startX - i, startY));
            }

            SpawnFood();

            // Ensure the panel is redrawn immediately
            pnl_gamepanel.Invalidate();

            gameTimer.Interval = gameInterval;
            gameTimer.Start();
        }

        private Point GetHeadGridPosition()
        {
            return snake[0];
        }

        private void MoveSnake()
        {
            if (!isGameRunning || isPaused) return;

            // Apply buffered direction
            currentDirection = nextDirection;

            // Current head
            Point head = GetHeadGridPosition();
            Point newHead = new Point(head.X + currentDirection.X,
                                      head.Y + currentDirection.Y);

            // Calculate grid dimensions based on panel size
            int gridWidth = Math.Max(1, pnl_gamepanel.Width / CellSize);
            int gridHeight = Math.Max(1, pnl_gamepanel.Height / CellSize);

            if (rdo_easy.Checked)
            {                 // Wrap around logic for easy mode
                if (newHead.X < 0) newHead.X = gridWidth - 1;
                else if (newHead.X >= gridWidth) newHead.X = 0;
                if (newHead.Y < 0) newHead.Y = gridHeight - 1;
                else if (newHead.Y >= gridHeight) newHead.Y = 0;
            }
            else if (newHead.X < 0 || newHead.X >= gridWidth ||
                newHead.Y < 0 || newHead.Y >= gridHeight)
            {
                highScore = Math.Max(score, highScore);
                GameOver();
                return;
            }

            // Self collision
            if (snake.Contains(newHead))
            {
                GameOver();
                return;
            }

            // Add new head
            snake.Insert(0, newHead);

            // If food eaten
            if (foodPosition.HasValue && foodPosition.Value.Equals(newHead))
            {
                // Earn points based on fruit type
                score += (int)currentFruitType;
                UpdateScoreLabel();

                if (score > highScore)
                {
                    highScore = score;
                    UpdateHighScoreLabel();
                }

                // Spawn a new fruit (fast and lightweight)
                SpawnFood();
            }
            else
            {
                // Remove tail
                snake.RemoveAt(snake.Count - 1);
            }

            // Request repaint of only game panel (fast)
            pnl_gamepanel.Invalidate();
        }

        private void SpawnFood()
        {
            int gridWidth = Math.Max(1, pnl_gamepanel.Width / CellSize);
            int gridHeight = Math.Max(1, pnl_gamepanel.Height / CellSize);

            List<Point> freeCells = new List<Point>();

            for (int x = 0; x < gridWidth; x++)
            {
                for (int y = 0; y < gridHeight; y++)
                {
                    Point p = new Point(x, y);
                    if (!snake.Contains(p))
                        freeCells.Add(p);
                }
            }

            if (freeCells.Count == 0)
            {
                GameOver();
                return;
            }

            Point chosen = freeCells[rnd.Next(freeCells.Count)];
            foodPosition = chosen;

            // Randomly pick a fruit type by weights (can be adjusted)
            int pick = rnd.Next(100);
            if (pick < 50) currentFruitType = FruitType.Apple; // common
            else if (pick < 80) currentFruitType = FruitType.Orange;
            else if (pick < 95) currentFruitType = FruitType.Banana;
            else currentFruitType = FruitType.Grape; // rare

            // Only invalidate (no heavy control creation)
            pnl_gamepanel.Invalidate();
        }

        private void GameOver()
        {
            isGameRunning = false;
            gameTimer.Stop();

            // Update high score before resetting
            if (score > highScore)
            {
                highScore = score;
                UpdateHighScoreLabel();
            }

            MessageBox.Show($"Game Over!\nYour score: {score}",
                            "Game Over",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            ResetToMenuState();
        }

        private void UpdateScoreLabel()
        {
            lbl_score.Text = $"Score: {score}";
        }

        private void UpdateHighScoreLabel()
        {
            lbl_highscore.Text = $"High Score: {highScore}";
        }

        private void PauseResume()
        {
            if (!isGameRunning) return;

            isPaused = !isPaused;
            if (isPaused)
            {
                gameTimer.Stop();
                btn_pause.Text = "Resume";
            }
            else
            {
                gameTimer.Start();
                btn_pause.Text = "Pause";
            }
        }

        #endregion

        #region UI & Event Handlers

        private void ResetToMenuState()
        {
            // Show Menu UI
            btn_start.Visible = true;
            btn_Level.Visible = true;
            btn_exitgame.Visible = true;
            lbl_gamename.Visible = true;
            lbl_madeby.Visible = true;

            // Hide Game UI
            pnl_gamepanel.Visible = false;
            pnl_gamesidepanel.Visible = false;
            pnl_lvlselect.Visible = false;

            // Reset labels
            lbl_score.Text = "Score: 0";

            // Clear snake & food
            snake.Clear();
            foodPosition = null;

            // Clear any child controls (designer may have placed controls earlier)
            pnl_gamepanel.Controls.Clear();
            pnl_gamepanel.Invalidate();

            isGameRunning = false;
            isPaused = false;
        }

        private void SwitchToGameState()
        {
            // Hide menu items
            btn_start.Visible = false;
            btn_Level.Visible = false;
            btn_exitgame.Visible = false;
            lbl_gamename.Visible = false;
            pnl_lvlselect.Visible = false;
            lbl_madeby.Visible = false;

            // Show game UI
            pnl_gamepanel.Visible = true;
            pnl_gamesidepanel.Visible = true;
            pnl_gamepanel.Focus();

            lbl_highscore.Visible = true;
            pnl_gamepanel.BringToFront();
            pnl_gamesidepanel.BringToFront();
        }

        private void SetLevelInterval(string level)
        {
            switch (level)
            {
                case "Easy":
                    gameInterval = 200;
                    break;
                case "Medium":
                    gameInterval = 120;
                    break;
                case "Hard":
                    gameInterval = 70;
                    break;
                default:
                    gameInterval = 200;
                    break;
            }
            lbl_displaylevel.Text = $"Level: {level}";
        }

        private string GetLevelNameFromInterval(int interval)
        {
            switch (interval)
            {
                case 200:
                    return "Easy";
                case 120:
                    return "Medium";
                case 70:
                    return "Hard";
                default:
                    return "Custom";
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            MoveSnake();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isGameRunning) return;

            Point newDir = nextDirection;

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) newDir = new Point(0, -1);
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) newDir = new Point(0, 1);
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) newDir = new Point(-1, 0);
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) newDir = new Point(1, 0);
            else if (e.KeyCode == Keys.Space) { PauseResume(); return; }

            // Prevent reversing direction
            if (snake.Count > 1)
            {
                Point second = snake[1];
                Point head = GetHeadGridPosition();
                Point attempted = new Point(head.X + newDir.X, head.Y + newDir.Y);

                if (attempted.Equals(second)) return;
            }

            nextDirection = newDir;
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetToMenuState();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            SwitchToGameState();
            StartNewGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set panel to a reasonable size (designer may change this)
            pnl_gamepanel.Size = new Size(784, 460);
            pnl_gamepanel.Paint += Pnl_gamepanel_Paint;
            rdo_easy.Checked = true;
            ResetToMenuState();
        }

        // Custom painting to render snake and fruit fast (no control churn)
        private void Pnl_gamepanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

            // Draw background image if present (maintain BackgroundImageLayout.Stretch semantics)
            if (pnl_gamepanel.BackgroundImage != null)
            {
                // Draw the background image stretched to panel client area
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(pnl_gamepanel.BackgroundImage, new Rectangle(0, 0, pnl_gamepanel.ClientSize.Width, pnl_gamepanel.ClientSize.Height));
            }
            else
            {
                // fallback background
                g.Clear(Color.Black);
            }

            int gridWidth = Math.Max(1, pnl_gamepanel.Width / CellSize);
            int gridHeight = Math.Max(1, pnl_gamepanel.Height / CellSize);

            // Draw food
            if (foodPosition.HasValue)
            {
                Rectangle r = new Rectangle(foodPosition.Value.X * CellSize, foodPosition.Value.Y * CellSize, CellSize, CellSize);
                using (Brush b = new SolidBrush(fruitColors[currentFruitType]))
                {
                    g.FillRectangle(b, r);
                }

                // small white dot to indicate fruit
                using (Brush b = new SolidBrush(Color.White))
                {
                    g.FillEllipse(b, r.X + CellSize/4, r.Y + CellSize/4, CellSize/2, CellSize/2);
                }
            }

            // Draw snake
            for (int i = 0; i < snake.Count; i++)
            {
                Rectangle r = new Rectangle(snake[i].X * CellSize, snake[i].Y * CellSize, CellSize, CellSize);
                Color c = (i == 0) ? snakeHeadColor : snakeBodyColor;
                using (Brush b = new SolidBrush(c))
                {
                    g.FillRectangle(b, r);
                }

                using (Pen p = new Pen(Color.Black, 1))
                {
                    g.DrawRectangle(p, r);
                }
            }
        }

        private void lbl_selectlevel_Click(object sender, EventArgs e)
        {

        }

        private void btn_Level_Click(object sender, EventArgs e)
        {
            // show level panel
            pnl_lvlselect.Visible = true;
            pnl_lvlselect.Enabled = true;
            // preselect current level
            string lvl = GetLevelNameFromInterval(gameInterval);
            rdo_easy.Checked = lvl == "Easy";
            rdo_medium.Checked = lvl == "Medium";
            rdo_hard.Checked = lvl == "Hard";

            if (rdo_easy.Checked)
            {
                lbl_displaylevel.Text = "Level: Easy";
            }
            if (rdo_medium.Checked)
            {
                lbl_displaylevel.Text = "Level: Medium";
            }
            if (rdo_hard.Checked)
            {
                lbl_displaylevel.Text = "Level: Hard";
            }

            //increase panel size to 376, 590
            pnl_lvlselect.Size = new Size(376, 590);
            //change panel location to 0,0
            pnl_lvlselect.Location = new Point(0, 25);
            pnl_lvlselect.BringToFront();
            pnl_lvlselect.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_lvlselect_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_levelsave_Click(object sender, EventArgs e)
        {
            if (rdo_easy.Checked)
            {
                SetLevelInterval("Easy");
                lbl_displaylevel.Text = "Level: Easy";
            }
            else if (rdo_medium.Checked)
            {
                SetLevelInterval("Medium");
                lbl_displaylevel.Text = "Level: Medium";
            }
            else if (rdo_hard.Checked)
            {
                SetLevelInterval("Hard");
                lbl_displaylevel.Text = "Level: Hard";
            }

            pnl_lvlselect.Visible = false;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            PauseResume();
        }

        #endregion

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdo_easy.Checked = true;
            lbl_displaylevel.Text = "Level: Easy";
            SetLevelInterval("Easy");
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdo_medium.Checked = true;
            lbl_displaylevel.Text = "Level: Medium";
            SetLevelInterval("Medium");
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdo_hard.Checked = true;
            lbl_displaylevel.Text = "Level: Hard";
            SetLevelInterval("Hard");
        }

        private void mnustrip_redsnake_Click(object sender, EventArgs e)
        {
            snakeBodyColor = Color.Red;
            snakeHeadColor = Color.DarkRed; // optional: head slightly different
            pnl_gamepanel.Invalidate();
        }

        private void mnustrip_greensnake_Click(object sender, EventArgs e)
        {
            snakeBodyColor = Color.DodgerBlue;
            snakeHeadColor = Color.Blue;
            pnl_gamepanel.Invalidate();
        }

        private void mnustrip_yellowsnake_Click(object sender, EventArgs e)
        {
            snakeBodyColor = Color.Yellow;
            snakeHeadColor = Color.Goldenrod;
            pnl_gamepanel.Invalidate();
        }

        // Helper method to apply the colors immediately
        private void UpdateSnakeColors()
        {
            // just trigger redraw - colors are taken from fields
            pnl_gamepanel.Invalidate();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_gamepanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}