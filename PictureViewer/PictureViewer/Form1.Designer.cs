namespace PictureViewer
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
            this.SearchDirectory = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagesFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusCurrentDirectory = new System.Windows.Forms.ToolStripStatusLabel();
            this.pause = new System.Windows.Forms.Button();
            this.WebSearchButton = new System.Windows.Forms.Button();
            this.setTimerInterval = new System.Windows.Forms.NumericUpDown();
            this.setTimerIntervalLabel = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.webURL = new System.Windows.Forms.RichTextBox();
            this.webTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureViewer = new System.Windows.Forms.PictureBox();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTimerInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchDirectory
            // 
            this.SearchDirectory.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.SearchDirectory.Location = new System.Drawing.Point(71, 66);
            this.SearchDirectory.Name = "SearchDirectory";
            this.SearchDirectory.Size = new System.Drawing.Size(69, 38);
            this.SearchDirectory.TabIndex = 1;
            this.SearchDirectory.Text = "Search Directories";
            this.SearchDirectory.UseVisualStyleBackColor = false;
            this.SearchDirectory.Click += new System.EventHandler(this.SearchDirectory_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(545, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.webImageToolStripMenuItem,
            this.imagesFromFileToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.stopTimer_Click);
            // 
            // webImageToolStripMenuItem
            // 
            this.webImageToolStripMenuItem.Name = "webImageToolStripMenuItem";
            this.webImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.webImageToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.webImageToolStripMenuItem.Text = "Images From Web";
            this.webImageToolStripMenuItem.Click += new System.EventHandler(this.webImageToolStripMenuItem_Click);
            // 
            // imagesFromFileToolStripMenuItem
            // 
            this.imagesFromFileToolStripMenuItem.Name = "imagesFromFileToolStripMenuItem";
            this.imagesFromFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.imagesFromFileToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.imagesFromFileToolStripMenuItem.Text = "Images From File";
            this.imagesFromFileToolStripMenuItem.Click += new System.EventHandler(this.imagesFromFileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.howToToolStripMenuItem.Text = "How To";
            this.howToToolStripMenuItem.Click += new System.EventHandler(this.howToToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.LightGray;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusCurrentDirectory});
            this.statusStrip.Location = new System.Drawing.Point(0, 345);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(545, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusCurrentDirectory
            // 
            this.toolStripStatusCurrentDirectory.BackColor = System.Drawing.Color.LightGray;
            this.toolStripStatusCurrentDirectory.Name = "toolStripStatusCurrentDirectory";
            this.toolStripStatusCurrentDirectory.Size = new System.Drawing.Size(172, 17);
            this.toolStripStatusCurrentDirectory.Text = "toolStripStatusCurrentDirectory";
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pause.Location = new System.Drawing.Point(15, 66);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(49, 38);
            this.pause.TabIndex = 8;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.stopTimer_Click);
            // 
            // WebSearchButton
            // 
            this.WebSearchButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.WebSearchButton.Location = new System.Drawing.Point(71, 66);
            this.WebSearchButton.Name = "WebSearchButton";
            this.WebSearchButton.Size = new System.Drawing.Size(50, 38);
            this.WebSearchButton.TabIndex = 10;
            this.WebSearchButton.Text = "Search Web";
            this.WebSearchButton.UseVisualStyleBackColor = false;
            this.WebSearchButton.Click += new System.EventHandler(this.WebSearchButton_Click);
            // 
            // setTimerInterval
            // 
            this.setTimerInterval.Location = new System.Drawing.Point(15, 40);
            this.setTimerInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.setTimerInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setTimerInterval.Name = "setTimerInterval";
            this.setTimerInterval.Size = new System.Drawing.Size(53, 20);
            this.setTimerInterval.TabIndex = 11;
            this.setTimerInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.setTimerInterval.ValueChanged += new System.EventHandler(this.setTimerInterval_ValueChanged);
            // 
            // setTimerIntervalLabel
            // 
            this.setTimerIntervalLabel.AutoSize = true;
            this.setTimerIntervalLabel.Location = new System.Drawing.Point(12, 24);
            this.setTimerIntervalLabel.Name = "setTimerIntervalLabel";
            this.setTimerIntervalLabel.Size = new System.Drawing.Size(93, 13);
            this.setTimerIntervalLabel.TabIndex = 12;
            this.setTimerIntervalLabel.Text = "Set Timer Interval:";
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Location = new System.Drawing.Point(74, 42);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(47, 13);
            this.seconds.TabIndex = 13;
            this.seconds.Text = "seconds";
            // 
            // webURL
            // 
            this.webURL.Location = new System.Drawing.Point(12, 110);
            this.webURL.Name = "webURL";
            this.webURL.Size = new System.Drawing.Size(164, 162);
            this.webURL.TabIndex = 14;
            this.webURL.Text = "";
            // 
            // webTimer
            // 
            this.webTimer.Interval = 5000;
            this.webTimer.Tick += new System.EventHandler(this.webTimer_Tick);
            // 
            // pictureViewer
            // 
            this.pictureViewer.Location = new System.Drawing.Point(182, 40);
            this.pictureViewer.Name = "pictureViewer";
            this.pictureViewer.Size = new System.Drawing.Size(350, 283);
            this.pictureViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureViewer.TabIndex = 3;
            this.pictureViewer.TabStop = false;
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ClearAll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(545, 367);
            this.Controls.Add(this.webURL);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.setTimerIntervalLabel);
            this.Controls.Add(this.setTimerInterval);
            this.Controls.Add(this.WebSearchButton);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pictureViewer);
            this.Controls.Add(this.SearchDirectory);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "PictureViewer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTimerInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchDirectory;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureViewer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCurrentDirectory;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button WebSearchButton;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagesFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown setTimerInterval;
        private System.Windows.Forms.Label setTimerIntervalLabel;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.RichTextBox webURL;
        private System.Windows.Forms.Timer webTimer;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}

