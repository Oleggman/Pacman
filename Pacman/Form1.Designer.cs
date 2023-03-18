namespace Pacman
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanelGrid = new System.Windows.Forms.Panel();
            this.EnemySprite = new System.Windows.Forms.PictureBox();
            this.PacmanSprite = new System.Windows.Forms.PictureBox();
            this.GameName = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextLeveltestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.PanelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemySprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacmanSprite)).BeginInit();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGrid
            // 
            this.PanelGrid.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelGrid.BackgroundImage = global::Pacman.Properties.Resources.PacmanBackground;
            this.PanelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelGrid.Controls.Add(this.EnemySprite);
            this.PanelGrid.Controls.Add(this.PacmanSprite);
            this.PanelGrid.Location = new System.Drawing.Point(11, 86);
            this.PanelGrid.Name = "PanelGrid";
            this.PanelGrid.Size = new System.Drawing.Size(776, 380);
            this.PanelGrid.TabIndex = 0;
            // 
            // EnemySprite
            // 
            this.EnemySprite.BackgroundImage = global::Pacman.Properties.Resources.PacmanBackground;
            this.EnemySprite.Image = global::Pacman.Properties.Resources.EnemySprite_gif;
            this.EnemySprite.Location = new System.Drawing.Point(557, 130);
            this.EnemySprite.Name = "EnemySprite";
            this.EnemySprite.Size = new System.Drawing.Size(35, 35);
            this.EnemySprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemySprite.TabIndex = 1;
            this.EnemySprite.TabStop = false;
            // 
            // PacmanSprite
            // 
            this.PacmanSprite.BackgroundImage = global::Pacman.Properties.Resources.PacmanBackground;
            this.PacmanSprite.Image = global::Pacman.Properties.Resources.Pacman_sprite_gif;
            this.PacmanSprite.Location = new System.Drawing.Point(248, 192);
            this.PacmanSprite.Name = "PacmanSprite";
            this.PacmanSprite.Size = new System.Drawing.Size(70, 70);
            this.PacmanSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PacmanSprite.TabIndex = 0;
            this.PacmanSprite.TabStop = false;
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameName.Location = new System.Drawing.Point(623, 27);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(174, 60);
            this.GameName.TabIndex = 1;
            this.GameName.Text = "Pacman";
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.Font = new System.Drawing.Font("ROG Fonts", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelScore.Location = new System.Drawing.Point(12, 42);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(218, 40);
            this.LabelScore.TabIndex = 2;
            this.LabelScore.Text = "Score: 0";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.Color.LightSlateGray;
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(799, 33);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "MainMenuStrip";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundToolStripMenuItem,
            this.nextLeveltestToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // soundToolStripMenuItem
            // 
            this.soundToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.soundToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Size = new System.Drawing.Size(250, 30);
            this.soundToolStripMenuItem.Text = "Sound";
            this.soundToolStripMenuItem.Click += new System.EventHandler(this.soundToolStripMenuItem_Click);
            // 
            // nextLeveltestToolStripMenuItem
            // 
            this.nextLeveltestToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.nextLeveltestToolStripMenuItem.Name = "nextLeveltestToolStripMenuItem";
            this.nextLeveltestToolStripMenuItem.Size = new System.Drawing.Size(250, 30);
            this.nextLeveltestToolStripMenuItem.Text = "Next Level (test)";
            this.nextLeveltestToolStripMenuItem.Click += new System.EventHandler(this.nextLeveltestToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.gameToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.loadToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LevelLabel.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LevelLabel.Location = new System.Drawing.Point(293, 35);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(229, 50);
            this.LevelLabel.TabIndex = 3;
            this.LevelLabel.Text = "Level: 1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(799, 478);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.PanelGrid);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.LabelScore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Pacman";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.PanelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EnemySprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacmanSprite)).EndInit();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Panel PanelGrid;
        private PictureBox EnemySprite;
        private PictureBox PacmanSprite;
        private Label GameName;
        private Label LabelScore;
        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem soundToolStripMenuItem;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label LevelLabel;
        private ToolStripMenuItem nextLeveltestToolStripMenuItem;
    }
}