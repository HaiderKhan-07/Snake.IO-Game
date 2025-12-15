namespace snakegameproject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snakeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnustrip_redsnake = new System.Windows.Forms.ToolStripMenuItem();
            this.mnustrip_greensnake = new System.Windows.Forms.ToolStripMenuItem();
            this.mnustrip_yellowsnake = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnustrip_musicon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnustrip_musicoff = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnustrip_backtomenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_Level = new System.Windows.Forms.Button();
            this.btn_exitgame = new System.Windows.Forms.Button();
            this.lbl_gamename = new System.Windows.Forms.Label();
            this.pnl_lvlselect = new System.Windows.Forms.Panel();
            this.btn_levelsave = new System.Windows.Forms.Button();
            this.grb_menulevel = new System.Windows.Forms.GroupBox();
            this.rdo_hard = new System.Windows.Forms.RadioButton();
            this.lbl_selectlevel = new System.Windows.Forms.Label();
            this.rdo_easy = new System.Windows.Forms.RadioButton();
            this.rdo_medium = new System.Windows.Forms.RadioButton();
            this.pnl_gamepanel = new System.Windows.Forms.Panel();
            this.pnl_gamesidepanel = new System.Windows.Forms.Panel();
            this.lbl_highscore = new System.Windows.Forms.Label();
            this.btn_pause = new System.Windows.Forms.Button();
            this.lbl_displaylevel = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_madeby = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnl_lvlselect.SuspendLayout();
            this.grb_menulevel.SuspendLayout();
            this.pnl_gamesidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snakeColorToolStripMenuItem,
            this.difficultyToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // snakeColorToolStripMenuItem
            // 
            this.snakeColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnustrip_redsnake,
            this.mnustrip_greensnake,
            this.mnustrip_yellowsnake});
            this.snakeColorToolStripMenuItem.Image = global::snakegameproject.Properties.Resources.paint_droplet;
            this.snakeColorToolStripMenuItem.Name = "snakeColorToolStripMenuItem";
            this.snakeColorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.snakeColorToolStripMenuItem.Text = "&Snake Color";
            // 
            // mnustrip_redsnake
            // 
            this.mnustrip_redsnake.Name = "mnustrip_redsnake";
            this.mnustrip_redsnake.Size = new System.Drawing.Size(108, 22);
            this.mnustrip_redsnake.Text = "Red";
            this.mnustrip_redsnake.Click += new System.EventHandler(this.mnustrip_redsnake_Click);
            // 
            // mnustrip_greensnake
            // 
            this.mnustrip_greensnake.Name = "mnustrip_greensnake";
            this.mnustrip_greensnake.Size = new System.Drawing.Size(108, 22);
            this.mnustrip_greensnake.Text = "Blue";
            this.mnustrip_greensnake.Click += new System.EventHandler(this.mnustrip_greensnake_Click);
            // 
            // mnustrip_yellowsnake
            // 
            this.mnustrip_yellowsnake.Name = "mnustrip_yellowsnake";
            this.mnustrip_yellowsnake.Size = new System.Drawing.Size(108, 22);
            this.mnustrip_yellowsnake.Text = "Yellow";
            this.mnustrip_yellowsnake.Click += new System.EventHandler(this.mnustrip_yellowsnake_Click);
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.difficultyToolStripMenuItem.Image = global::snakegameproject.Properties.Resources.difficulty_img;
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.difficultyToolStripMenuItem.Text = "&Difficulty";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.mnustrip_backtomenu});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnustrip_musicon,
            this.mnustrip_musicoff});
            this.musicToolStripMenuItem.Image = global::snakegameproject.Properties.Resources.music_sign;
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.musicToolStripMenuItem.Text = "Music";
            // 
            // mnustrip_musicon
            // 
            this.mnustrip_musicon.Name = "mnustrip_musicon";
            this.mnustrip_musicon.Size = new System.Drawing.Size(91, 22);
            this.mnustrip_musicon.Text = "On";
            // 
            // mnustrip_musicoff
            // 
            this.mnustrip_musicoff.Name = "mnustrip_musicoff";
            this.mnustrip_musicoff.Size = new System.Drawing.Size(91, 22);
            this.mnustrip_musicoff.Text = "Off";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::snakegameproject.Properties.Resources.exit_game;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnustrip_backtomenu
            // 
            this.mnustrip_backtomenu.Image = global::snakegameproject.Properties.Resources.go_back;
            this.mnustrip_backtomenu.Name = "mnustrip_backtomenu";
            this.mnustrip_backtomenu.Size = new System.Drawing.Size(147, 22);
            this.mnustrip_backtomenu.Text = "&Back to m&enu";
            this.mnustrip_backtomenu.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(297, 208);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(200, 50);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "&Start Game";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_Level
            // 
            this.btn_Level.BackColor = System.Drawing.Color.Black;
            this.btn_Level.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Level.ForeColor = System.Drawing.Color.White;
            this.btn_Level.Location = new System.Drawing.Point(297, 271);
            this.btn_Level.Name = "btn_Level";
            this.btn_Level.Size = new System.Drawing.Size(200, 50);
            this.btn_Level.TabIndex = 2;
            this.btn_Level.Text = "&Level";
            this.btn_Level.UseVisualStyleBackColor = false;
            this.btn_Level.Click += new System.EventHandler(this.btn_Level_Click);
            // 
            // btn_exitgame
            // 
            this.btn_exitgame.BackColor = System.Drawing.Color.Red;
            this.btn_exitgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitgame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitgame.ForeColor = System.Drawing.Color.White;
            this.btn_exitgame.Location = new System.Drawing.Point(297, 331);
            this.btn_exitgame.Name = "btn_exitgame";
            this.btn_exitgame.Size = new System.Drawing.Size(200, 50);
            this.btn_exitgame.TabIndex = 3;
            this.btn_exitgame.Text = "E&xit Game";
            this.btn_exitgame.UseVisualStyleBackColor = false;
            this.btn_exitgame.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_gamename
            // 
            this.lbl_gamename.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gamename.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_gamename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_gamename.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gamename.ForeColor = System.Drawing.Color.Black;
            this.lbl_gamename.Location = new System.Drawing.Point(0, 24);
            this.lbl_gamename.Name = "lbl_gamename";
            this.lbl_gamename.Size = new System.Drawing.Size(784, 96);
            this.lbl_gamename.TabIndex = 4;
            this.lbl_gamename.Text = "Snake.IO";
            this.lbl_gamename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_lvlselect
            // 
            this.pnl_lvlselect.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_lvlselect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_lvlselect.Controls.Add(this.btn_levelsave);
            this.pnl_lvlselect.Controls.Add(this.grb_menulevel);
            this.pnl_lvlselect.Enabled = false;
            this.pnl_lvlselect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_lvlselect.Location = new System.Drawing.Point(698, 36);
            this.pnl_lvlselect.Name = "pnl_lvlselect";
            this.pnl_lvlselect.Size = new System.Drawing.Size(74, 86);
            this.pnl_lvlselect.TabIndex = 5;
            this.pnl_lvlselect.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_lvlselect_Paint);
            // 
            // btn_levelsave
            // 
            this.btn_levelsave.BackColor = System.Drawing.Color.Teal;
            this.btn_levelsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_levelsave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_levelsave.ForeColor = System.Drawing.Color.White;
            this.btn_levelsave.Location = new System.Drawing.Point(81, 275);
            this.btn_levelsave.Name = "btn_levelsave";
            this.btn_levelsave.Size = new System.Drawing.Size(180, 45);
            this.btn_levelsave.TabIndex = 5;
            this.btn_levelsave.Text = "Save";
            this.btn_levelsave.UseVisualStyleBackColor = false;
            this.btn_levelsave.Click += new System.EventHandler(this.btn_levelsave_Click);
            // 
            // grb_menulevel
            // 
            this.grb_menulevel.Controls.Add(this.rdo_hard);
            this.grb_menulevel.Controls.Add(this.lbl_selectlevel);
            this.grb_menulevel.Controls.Add(this.rdo_easy);
            this.grb_menulevel.Controls.Add(this.rdo_medium);
            this.grb_menulevel.Location = new System.Drawing.Point(11, 21);
            this.grb_menulevel.Name = "grb_menulevel";
            this.grb_menulevel.Size = new System.Drawing.Size(328, 232);
            this.grb_menulevel.TabIndex = 4;
            this.grb_menulevel.TabStop = false;
            // 
            // rdo_hard
            // 
            this.rdo_hard.AutoSize = true;
            this.rdo_hard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_hard.ForeColor = System.Drawing.Color.Black;
            this.rdo_hard.Location = new System.Drawing.Point(102, 162);
            this.rdo_hard.Name = "rdo_hard";
            this.rdo_hard.Size = new System.Drawing.Size(62, 25);
            this.rdo_hard.TabIndex = 1;
            this.rdo_hard.TabStop = true;
            this.rdo_hard.Text = "Hard";
            this.rdo_hard.UseVisualStyleBackColor = true;
            // 
            // lbl_selectlevel
            // 
            this.lbl_selectlevel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectlevel.ForeColor = System.Drawing.Color.Black;
            this.lbl_selectlevel.Location = new System.Drawing.Point(6, 16);
            this.lbl_selectlevel.Name = "lbl_selectlevel";
            this.lbl_selectlevel.Size = new System.Drawing.Size(300, 50);
            this.lbl_selectlevel.TabIndex = 3;
            this.lbl_selectlevel.Text = "Select Difficulty";
            this.lbl_selectlevel.Click += new System.EventHandler(this.lbl_selectlevel_Click);
            // 
            // rdo_easy
            // 
            this.rdo_easy.AutoSize = true;
            this.rdo_easy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_easy.ForeColor = System.Drawing.Color.Black;
            this.rdo_easy.Location = new System.Drawing.Point(102, 88);
            this.rdo_easy.Name = "rdo_easy";
            this.rdo_easy.Size = new System.Drawing.Size(59, 25);
            this.rdo_easy.TabIndex = 0;
            this.rdo_easy.TabStop = true;
            this.rdo_easy.Text = "Easy";
            this.rdo_easy.UseVisualStyleBackColor = true;
            // 
            // rdo_medium
            // 
            this.rdo_medium.AutoSize = true;
            this.rdo_medium.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_medium.ForeColor = System.Drawing.Color.Black;
            this.rdo_medium.Location = new System.Drawing.Point(102, 127);
            this.rdo_medium.Name = "rdo_medium";
            this.rdo_medium.Size = new System.Drawing.Size(86, 25);
            this.rdo_medium.TabIndex = 2;
            this.rdo_medium.TabStop = true;
            this.rdo_medium.Text = "Medium";
            this.rdo_medium.UseVisualStyleBackColor = true;
            // 
            // pnl_gamepanel
            // 
            this.pnl_gamepanel.BackColor = System.Drawing.Color.Black;
            this.pnl_gamepanel.BackgroundImage = global::snakegameproject.Properties.Resources.snakegamebackground;
            this.pnl_gamepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_gamepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_gamepanel.Location = new System.Drawing.Point(0, 27);
            this.pnl_gamepanel.Name = "pnl_gamepanel";
            this.pnl_gamepanel.Size = new System.Drawing.Size(222, 114);
            this.pnl_gamepanel.TabIndex = 6;
            this.pnl_gamepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_gamepanel_Paint_1);
            // 
            // pnl_gamesidepanel
            // 
            this.pnl_gamesidepanel.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_gamesidepanel.BackgroundImage = global::snakegameproject.Properties.Resources.menuwoodbg;
            this.pnl_gamesidepanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_gamesidepanel.Controls.Add(this.lbl_highscore);
            this.pnl_gamesidepanel.Controls.Add(this.btn_pause);
            this.pnl_gamesidepanel.Controls.Add(this.lbl_displaylevel);
            this.pnl_gamesidepanel.Controls.Add(this.lbl_score);
            this.pnl_gamesidepanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_gamesidepanel.Location = new System.Drawing.Point(0, 481);
            this.pnl_gamesidepanel.Name = "pnl_gamesidepanel";
            this.pnl_gamesidepanel.Size = new System.Drawing.Size(784, 80);
            this.pnl_gamesidepanel.TabIndex = 0;
            this.pnl_gamesidepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_highscore
            // 
            this.lbl_highscore.BackColor = System.Drawing.Color.Transparent;
            this.lbl_highscore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_highscore.ForeColor = System.Drawing.Color.Black;
            this.lbl_highscore.Location = new System.Drawing.Point(329, 25);
            this.lbl_highscore.Name = "lbl_highscore";
            this.lbl_highscore.Size = new System.Drawing.Size(156, 25);
            this.lbl_highscore.TabIndex = 3;
            this.lbl_highscore.Text = "HighScore: 0";
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Black;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pause.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pause.ForeColor = System.Drawing.Color.White;
            this.btn_pause.Location = new System.Drawing.Point(612, 22);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(120, 40);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "PAUSE";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // lbl_displaylevel
            // 
            this.lbl_displaylevel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_displaylevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_displaylevel.ForeColor = System.Drawing.Color.Black;
            this.lbl_displaylevel.Location = new System.Drawing.Point(172, 27);
            this.lbl_displaylevel.Name = "lbl_displaylevel";
            this.lbl_displaylevel.Size = new System.Drawing.Size(128, 35);
            this.lbl_displaylevel.TabIndex = 1;
            this.lbl_displaylevel.Text = "Level: Easy";
            // 
            // lbl_score
            // 
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.Black;
            this.lbl_score.Location = new System.Drawing.Point(41, 27);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(100, 23);
            this.lbl_score.TabIndex = 0;
            this.lbl_score.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lbl_madeby
            // 
            this.lbl_madeby.BackColor = System.Drawing.Color.Transparent;
            this.lbl_madeby.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_madeby.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_madeby.ForeColor = System.Drawing.Color.Black;
            this.lbl_madeby.Location = new System.Drawing.Point(0, 441);
            this.lbl_madeby.Name = "lbl_madeby";
            this.lbl_madeby.Size = new System.Drawing.Size(784, 40);
            this.lbl_madeby.TabIndex = 7;
            this.lbl_madeby.Text = "MADE BY HAIDER KHAN";
            this.lbl_madeby.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::snakegameproject.Properties.Resources.snakegamebackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbl_madeby);
            this.Controls.Add(this.pnl_gamepanel);
            this.Controls.Add(this.pnl_lvlselect);
            this.Controls.Add(this.lbl_gamename);
            this.Controls.Add(this.pnl_gamesidepanel);
            this.Controls.Add(this.btn_exitgame);
            this.Controls.Add(this.btn_Level);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake.IO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_lvlselect.ResumeLayout(false);
            this.grb_menulevel.ResumeLayout(false);
            this.grb_menulevel.PerformLayout();
            this.pnl_gamesidepanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snakeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnustrip_redsnake;
        private System.Windows.Forms.ToolStripMenuItem mnustrip_greensnake;
        private System.Windows.Forms.ToolStripMenuItem mnustrip_yellowsnake;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnustrip_musicon;
        private System.Windows.Forms.ToolStripMenuItem mnustrip_musicoff;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_Level;
        private System.Windows.Forms.Button btn_exitgame;
        private System.Windows.Forms.Label lbl_gamename;
        private System.Windows.Forms.ToolStripMenuItem mnustrip_backtomenu;
        private System.Windows.Forms.Panel pnl_lvlselect;
        private System.Windows.Forms.RadioButton rdo_medium;
        private System.Windows.Forms.RadioButton rdo_hard;
        private System.Windows.Forms.RadioButton rdo_easy;
        private System.Windows.Forms.Label lbl_selectlevel;
        private System.Windows.Forms.GroupBox grb_menulevel;
        private System.Windows.Forms.Button btn_levelsave;
        private System.Windows.Forms.Panel pnl_gamepanel;
        private System.Windows.Forms.Panel pnl_gamesidepanel;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Label lbl_displaylevel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lbl_highscore;
        private System.Windows.Forms.Label lbl_madeby;
    }
}

