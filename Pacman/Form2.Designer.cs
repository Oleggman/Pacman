namespace Pacman
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.SoundCheckBox = new System.Windows.Forms.CheckBox();
            this.SoundTrackBar = new System.Windows.Forms.TrackBar();
            this.SoundButtonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SoundTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SoundCheckBox
            // 
            this.SoundCheckBox.AutoSize = true;
            this.SoundCheckBox.BackColor = System.Drawing.Color.LightSlateGray;
            this.SoundCheckBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SoundCheckBox.Location = new System.Drawing.Point(43, 21);
            this.SoundCheckBox.Name = "SoundCheckBox";
            this.SoundCheckBox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SoundCheckBox.Size = new System.Drawing.Size(136, 42);
            this.SoundCheckBox.TabIndex = 0;
            this.SoundCheckBox.Text = "Music";
            this.SoundCheckBox.UseVisualStyleBackColor = false;
            this.SoundCheckBox.CheckedChanged += new System.EventHandler(this.SoundCheckBox_CheckedChanged);
            // 
            // SoundTrackBar
            // 
            this.SoundTrackBar.BackColor = System.Drawing.Color.LightSlateGray;
            this.SoundTrackBar.Location = new System.Drawing.Point(43, 86);
            this.SoundTrackBar.Name = "SoundTrackBar";
            this.SoundTrackBar.Size = new System.Drawing.Size(130, 56);
            this.SoundTrackBar.TabIndex = 1;
            this.SoundTrackBar.Scroll += new System.EventHandler(this.SoundTrackBar_Scroll);
            // 
            // SoundButtonSubmit
            // 
            this.SoundButtonSubmit.BackColor = System.Drawing.Color.LightSlateGray;
            this.SoundButtonSubmit.Location = new System.Drawing.Point(43, 164);
            this.SoundButtonSubmit.Name = "SoundButtonSubmit";
            this.SoundButtonSubmit.Size = new System.Drawing.Size(130, 48);
            this.SoundButtonSubmit.TabIndex = 2;
            this.SoundButtonSubmit.Text = "Submit";
            this.SoundButtonSubmit.UseVisualStyleBackColor = false;
            this.SoundButtonSubmit.Click += new System.EventHandler(this.SoundButtonSubmit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pacman.Properties.Resources.PacmanBackground;
            this.ClientSize = new System.Drawing.Size(224, 240);
            this.Controls.Add(this.SoundButtonSubmit);
            this.Controls.Add(this.SoundTrackBar);
            this.Controls.Add(this.SoundCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Sound";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed_1);
            ((System.ComponentModel.ISupportInitialize)(this.SoundTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox SoundCheckBox;
        private TrackBar SoundTrackBar;
        private Button SoundButtonSubmit;
    }
}