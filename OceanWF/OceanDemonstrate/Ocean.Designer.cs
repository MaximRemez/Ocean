
namespace OceanWF.OceanDemonstrate
{
    partial class Ocean
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ocean));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.oceanStatisticPanel = new System.Windows.Forms.Panel();
            this.rimuruShowLabel = new System.Windows.Forms.Label();
            this.rimuruOceanLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.obstacleShowLabel = new System.Windows.Forms.Label();
            this.predatorShowLabel = new System.Windows.Forms.Label();
            this.preyShowLabel = new System.Windows.Forms.Label();
            this.iterationShowLabel = new System.Windows.Forms.Label();
            this.maxValueLabel = new System.Windows.Forms.Label();
            this.itearationOceanLabel = new System.Windows.Forms.Label();
            this.obstacleOceanLabel = new System.Windows.Forms.Label();
            this.predatorOceanLabel = new System.Windows.Forms.Label();
            this.preyOceanLabel = new System.Windows.Forms.Label();
            this.iterationTimer = new System.Windows.Forms.Timer(this.components);
            this.changeButton = new System.Windows.Forms.Button();
            this.oceanPanel = new System.Windows.Forms.Panel();
            this.oceanDataGridView = new System.Windows.Forms.DataGridView();
            this.oceanStatisticPanel.SuspendLayout();
            this.oceanPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oceanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // oceanStatisticPanel
            // 
            this.oceanStatisticPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oceanStatisticPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(34)))), ((int)(((byte)(179)))));
            this.oceanStatisticPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("oceanStatisticPanel.BackgroundImage")));
            this.oceanStatisticPanel.Controls.Add(this.rimuruShowLabel);
            this.oceanStatisticPanel.Controls.Add(this.rimuruOceanLabel);
            this.oceanStatisticPanel.Controls.Add(this.progressBar);
            this.oceanStatisticPanel.Controls.Add(this.obstacleShowLabel);
            this.oceanStatisticPanel.Controls.Add(this.predatorShowLabel);
            this.oceanStatisticPanel.Controls.Add(this.preyShowLabel);
            this.oceanStatisticPanel.Controls.Add(this.iterationShowLabel);
            this.oceanStatisticPanel.Controls.Add(this.maxValueLabel);
            this.oceanStatisticPanel.Controls.Add(this.itearationOceanLabel);
            this.oceanStatisticPanel.Controls.Add(this.obstacleOceanLabel);
            this.oceanStatisticPanel.Controls.Add(this.predatorOceanLabel);
            this.oceanStatisticPanel.Controls.Add(this.preyOceanLabel);
            this.oceanStatisticPanel.Location = new System.Drawing.Point(35, 40);
            this.oceanStatisticPanel.Name = "oceanStatisticPanel";
            this.oceanStatisticPanel.Size = new System.Drawing.Size(1232, 118);
            this.oceanStatisticPanel.TabIndex = 1;
            // 
            // rimuruShowLabel
            // 
            this.rimuruShowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rimuruShowLabel.AutoSize = true;
            this.rimuruShowLabel.BackColor = System.Drawing.Color.Transparent;
            this.rimuruShowLabel.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rimuruShowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(34)))), ((int)(((byte)(179)))));
            this.rimuruShowLabel.Location = new System.Drawing.Point(1134, 49);
            this.rimuruShowLabel.Name = "rimuruShowLabel";
            this.rimuruShowLabel.Size = new System.Drawing.Size(77, 35);
            this.rimuruShowLabel.TabIndex = 18;
            this.rimuruShowLabel.Text = "num";
            // 
            // rimuruOceanLabel
            // 
            this.rimuruOceanLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rimuruOceanLabel.AutoSize = true;
            this.rimuruOceanLabel.BackColor = System.Drawing.Color.Transparent;
            this.rimuruOceanLabel.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rimuruOceanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(34)))), ((int)(((byte)(179)))));
            this.rimuruOceanLabel.Location = new System.Drawing.Point(1015, 49);
            this.rimuruOceanLabel.Name = "rimuruOceanLabel";
            this.rimuruOceanLabel.Size = new System.Drawing.Size(122, 35);
            this.rimuruOceanLabel.TabIndex = 17;
            this.rimuruOceanLabel.Text = "Rimuru:";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(225, 58);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(134, 26);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 16;
            // 
            // obstacleShowLabel
            // 
            this.obstacleShowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.obstacleShowLabel.AutoSize = true;
            this.obstacleShowLabel.BackColor = System.Drawing.Color.Transparent;
            this.obstacleShowLabel.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obstacleShowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(34)))), ((int)(((byte)(179)))));
            this.obstacleShowLabel.Location = new System.Drawing.Point(936, 49);
            this.obstacleShowLabel.Name = "obstacleShowLabel";
            this.obstacleShowLabel.Size = new System.Drawing.Size(77, 35);
            this.obstacleShowLabel.TabIndex = 15;
            this.obstacleShowLabel.Text = "num";
            // 
            // predatorShowLabel
            // 
            this.predatorShowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.predatorShowLabel.AutoSize = true;
            this.predatorShowLabel.BackColor = System.Drawing.Color.Transparent;
            this.predatorShowLabel.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predatorShowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(34)))), ((int)(((byte)(179)))));
            this.predatorShowLabel.Location = new System.Drawing.Point(711, 49);
            this.predatorShowLabel.Name = "predatorShowLabel";
            this.predatorShowLabel.Size = new System.Drawing.Size(77, 35);
            this.predatorShowLabel.TabIndex = 14;
            this.predatorShowLabel.Text = "num";
            // 
            // preyShowLabel
            // 
            this.preyShowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.preyShowLabel.AutoSize = true;
            this.preyShowLabel.BackColor = System.Drawing.Color.Transparent;
            this.preyShowLabel.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preyShowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(34)))), ((int)(((byte)(179)))));
            this.preyShowLabel.Location = new System.Drawing.Point(482, 49);
            this.preyShowLabel.Name = "preyShowLabel";
            this.preyShowLabel.Size = new System.Drawing.Size(77, 35);
            this.preyShowLabel.TabIndex = 13;
            this.preyShowLabel.Text = "num";
            // 
            // iterationShowLabel
            // 
            this.iterationShowLabel.AutoSize = true;
            this.iterationShowLabel.BackColor = System.Drawing.Color.Transparent;
            this.iterationShowLabel.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationShowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(34)))), ((int)(((byte)(179)))));
            this.iterationShowLabel.Location = new System.Drawing.Point(142, 49);
            this.iterationShowLabel.Name = "iterationShowLabel";
            this.iterationShowLabel.Size = new System.Drawing.Size(77, 35);
            this.iterationShowLabel.TabIndex = 12;
            this.iterationShowLabel.Text = "num";
            // 
            // maxValueLabel
            // 
            this.maxValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxValueLabel.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(34)))), ((int)(((byte)(179)))));
            this.maxValueLabel.Location = new System.Drawing.Point(271, 33);
            this.maxValueLabel.Name = "maxValueLabel";
            this.maxValueLabel.Size = new System.Drawing.Size(98, 22);
            this.maxValueLabel.TabIndex = 11;
            this.maxValueLabel.Text = "maxValue";
            this.maxValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itearationOceanLabel
            // 
            this.itearationOceanLabel.AutoSize = true;
            this.itearationOceanLabel.BackColor = System.Drawing.Color.Transparent;
            this.itearationOceanLabel.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itearationOceanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(34)))), ((int)(((byte)(179)))));
            this.itearationOceanLabel.Location = new System.Drawing.Point(5, 49);
            this.itearationOceanLabel.Name = "itearationOceanLabel";
            this.itearationOceanLabel.Size = new System.Drawing.Size(146, 35);
            this.itearationOceanLabel.TabIndex = 5;
            this.itearationOceanLabel.Text = "Iterations:";
            // 
            // obstacleOceanLabel
            // 
            this.obstacleOceanLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.obstacleOceanLabel.AutoSize = true;
            this.obstacleOceanLabel.BackColor = System.Drawing.Color.Transparent;
            this.obstacleOceanLabel.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obstacleOceanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(34)))), ((int)(((byte)(179)))));
            this.obstacleOceanLabel.Location = new System.Drawing.Point(794, 49);
            this.obstacleOceanLabel.Name = "obstacleOceanLabel";
            this.obstacleOceanLabel.Size = new System.Drawing.Size(147, 35);
            this.obstacleOceanLabel.TabIndex = 4;
            this.obstacleOceanLabel.Text = "Obstacles:";
            // 
            // predatorOceanLabel
            // 
            this.predatorOceanLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.predatorOceanLabel.AutoSize = true;
            this.predatorOceanLabel.BackColor = System.Drawing.Color.Transparent;
            this.predatorOceanLabel.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predatorOceanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(34)))), ((int)(((byte)(179)))));
            this.predatorOceanLabel.Location = new System.Drawing.Point(565, 49);
            this.predatorOceanLabel.Name = "predatorOceanLabel";
            this.predatorOceanLabel.Size = new System.Drawing.Size(152, 35);
            this.predatorOceanLabel.TabIndex = 3;
            this.predatorOceanLabel.Text = "Predators:";
            // 
            // preyOceanLabel
            // 
            this.preyOceanLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.preyOceanLabel.AutoSize = true;
            this.preyOceanLabel.BackColor = System.Drawing.Color.Transparent;
            this.preyOceanLabel.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preyOceanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(34)))), ((int)(((byte)(179)))));
            this.preyOceanLabel.Location = new System.Drawing.Point(397, 49);
            this.preyOceanLabel.Name = "preyOceanLabel";
            this.preyOceanLabel.Size = new System.Drawing.Size(93, 35);
            this.preyOceanLabel.TabIndex = 2;
            this.preyOceanLabel.Text = "Preys:";
            // 
            // iterationTimer
            // 
            this.iterationTimer.Enabled = true;
            this.iterationTimer.Interval = 1;
            this.iterationTimer.Tick += new System.EventHandler(this.iterationTimer_Tick);
            // 
            // changeButton
            // 
            this.changeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(118)))), ((int)(((byte)(158)))));
            this.changeButton.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.changeButton.Location = new System.Drawing.Point(35, 466);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(1232, 57);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Start";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // oceanPanel
            // 
            this.oceanPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oceanPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(118)))), ((int)(((byte)(158)))));
            this.oceanPanel.Controls.Add(this.oceanDataGridView);
            this.oceanPanel.Location = new System.Drawing.Point(62, 164);
            this.oceanPanel.Name = "oceanPanel";
            this.oceanPanel.Size = new System.Drawing.Size(1170, 296);
            this.oceanPanel.TabIndex = 3;
            // 
            // oceanDataGridView
            // 
            this.oceanDataGridView.AllowUserToAddRows = false;
            this.oceanDataGridView.AllowUserToDeleteRows = false;
            this.oceanDataGridView.AllowUserToResizeColumns = false;
            this.oceanDataGridView.AllowUserToResizeRows = false;
            this.oceanDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(118)))), ((int)(((byte)(158)))));
            this.oceanDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oceanDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.oceanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oceanDataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(118)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(118)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.oceanDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.oceanDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oceanDataGridView.Location = new System.Drawing.Point(0, 0);
            this.oceanDataGridView.Name = "oceanDataGridView";
            this.oceanDataGridView.ReadOnly = true;
            this.oceanDataGridView.RowHeadersVisible = false;
            this.oceanDataGridView.RowHeadersWidth = 62;
            this.oceanDataGridView.RowTemplate.Height = 28;
            this.oceanDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.oceanDataGridView.ShowCellToolTips = false;
            this.oceanDataGridView.Size = new System.Drawing.Size(1170, 296);
            this.oceanDataGridView.TabIndex = 0;
            // 
            // Ocean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1299, 646);
            this.Controls.Add(this.oceanPanel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.oceanStatisticPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ocean";
            this.Text = "Ocean";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ocean_FormClosing);
            this.Load += new System.EventHandler(this.Ocean_Load);
            this.oceanStatisticPanel.ResumeLayout(false);
            this.oceanStatisticPanel.PerformLayout();
            this.oceanPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oceanDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel oceanStatisticPanel;
        private System.Windows.Forms.Label itearationOceanLabel;
        private System.Windows.Forms.Label obstacleOceanLabel;
        private System.Windows.Forms.Label predatorOceanLabel;
        private System.Windows.Forms.Label preyOceanLabel;
        private System.Windows.Forms.Label maxValueLabel;
        private System.Windows.Forms.Label iterationShowLabel;
        private System.Windows.Forms.Label obstacleShowLabel;
        private System.Windows.Forms.Label predatorShowLabel;
        private System.Windows.Forms.Label preyShowLabel;
        private System.Windows.Forms.Timer iterationTimer;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel oceanPanel;
        private System.Windows.Forms.DataGridView oceanDataGridView;
        private System.Windows.Forms.Label rimuruShowLabel;
        private System.Windows.Forms.Label rimuruOceanLabel;
    }
}