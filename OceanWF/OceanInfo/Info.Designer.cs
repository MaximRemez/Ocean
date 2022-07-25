
namespace OceanWF.OceanInfo
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.preyInfoLabel = new System.Windows.Forms.Label();
            this.obstacleInfoLabel = new System.Windows.Forms.Label();
            this.predatorInfoLabel = new System.Windows.Forms.Label();
            this.rimuruInfoLabel = new System.Windows.Forms.Label();
            this.preyPictureBox = new System.Windows.Forms.PictureBox();
            this.predatorPictureBox = new System.Windows.Forms.PictureBox();
            this.octopusPictureBox = new System.Windows.Forms.PictureBox();
            this.rimuruPictureBox = new System.Windows.Forms.PictureBox();
            this.tentaclePictureBox = new System.Windows.Forms.PictureBox();
            this.languageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.preyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predatorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.octopusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimuruPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tentaclePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // preyInfoLabel
            // 
            this.preyInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.preyInfoLabel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preyInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.preyInfoLabel.Location = new System.Drawing.Point(35, 23);
            this.preyInfoLabel.Name = "preyInfoLabel";
            this.preyInfoLabel.Size = new System.Drawing.Size(540, 86);
            this.preyInfoLabel.TabIndex = 6;
            this.preyInfoLabel.Text = "Prey swims into empty cells and breeds every 6 iterations";
            // 
            // obstacleInfoLabel
            // 
            this.obstacleInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.obstacleInfoLabel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obstacleInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.obstacleInfoLabel.Location = new System.Drawing.Point(35, 256);
            this.obstacleInfoLabel.Name = "obstacleInfoLabel";
            this.obstacleInfoLabel.Size = new System.Drawing.Size(540, 130);
            this.obstacleInfoLabel.TabIndex = 7;
            this.obstacleInfoLabel.Text = "The obstacle is the octopus. He does not move and every 15 iterations he strikes " +
    "with tentacles";
            // 
            // predatorInfoLabel
            // 
            this.predatorInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.predatorInfoLabel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.predatorInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.predatorInfoLabel.Location = new System.Drawing.Point(35, 115);
            this.predatorInfoLabel.Name = "predatorInfoLabel";
            this.predatorInfoLabel.Size = new System.Drawing.Size(540, 130);
            this.predatorInfoLabel.TabIndex = 8;
            this.predatorInfoLabel.Text = "The predator eats the prey and dies if it doesn\'t eat in 6 iterations. Also divid" +
    "ed every 6th iteration";
            // 
            // rimuruInfoLabel
            // 
            this.rimuruInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.rimuruInfoLabel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rimuruInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rimuruInfoLabel.Location = new System.Drawing.Point(35, 391);
            this.rimuruInfoLabel.Name = "rimuruInfoLabel";
            this.rimuruInfoLabel.Size = new System.Drawing.Size(540, 130);
            this.rimuruInfoLabel.TabIndex = 9;
            this.rimuruInfoLabel.Text = "Rimuru fish can eat anyone. It does not reproduce and can die only from tentacles" +
    "";
            // 
            // preyPictureBox
            // 
            this.preyPictureBox.Image = global::OceanWF.Properties.Resources.pixelPrey;
            this.preyPictureBox.Location = new System.Drawing.Point(570, 23);
            this.preyPictureBox.Name = "preyPictureBox";
            this.preyPictureBox.Size = new System.Drawing.Size(100, 100);
            this.preyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.preyPictureBox.TabIndex = 10;
            this.preyPictureBox.TabStop = false;
            // 
            // predatorPictureBox
            // 
            this.predatorPictureBox.Image = global::OceanWF.Properties.Resources.pixelPredator;
            this.predatorPictureBox.Location = new System.Drawing.Point(570, 115);
            this.predatorPictureBox.Name = "predatorPictureBox";
            this.predatorPictureBox.Size = new System.Drawing.Size(100, 100);
            this.predatorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.predatorPictureBox.TabIndex = 11;
            this.predatorPictureBox.TabStop = false;
            // 
            // octopusPictureBox
            // 
            this.octopusPictureBox.Image = global::OceanWF.Properties.Resources.pixelObstacle;
            this.octopusPictureBox.Location = new System.Drawing.Point(570, 256);
            this.octopusPictureBox.Name = "octopusPictureBox";
            this.octopusPictureBox.Size = new System.Drawing.Size(100, 100);
            this.octopusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.octopusPictureBox.TabIndex = 12;
            this.octopusPictureBox.TabStop = false;
            // 
            // rimuruPictureBox
            // 
            this.rimuruPictureBox.Image = global::OceanWF.Properties.Resources.pixelRimuru;
            this.rimuruPictureBox.Location = new System.Drawing.Point(570, 391);
            this.rimuruPictureBox.Name = "rimuruPictureBox";
            this.rimuruPictureBox.Size = new System.Drawing.Size(100, 100);
            this.rimuruPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rimuruPictureBox.TabIndex = 13;
            this.rimuruPictureBox.TabStop = false;
            // 
            // tentaclePictureBox
            // 
            this.tentaclePictureBox.Image = global::OceanWF.Properties.Resources.pixelTentacle;
            this.tentaclePictureBox.Location = new System.Drawing.Point(686, 256);
            this.tentaclePictureBox.Name = "tentaclePictureBox";
            this.tentaclePictureBox.Size = new System.Drawing.Size(100, 100);
            this.tentaclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tentaclePictureBox.TabIndex = 14;
            this.tentaclePictureBox.TabStop = false;
            // 
            // languageButton
            // 
            this.languageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.languageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(4)))), ((int)(((byte)(79)))));
            this.languageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.languageButton.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageButton.ForeColor = System.Drawing.Color.Black;
            this.languageButton.Location = new System.Drawing.Point(1, 524);
            this.languageButton.Name = "languageButton";
            this.languageButton.Size = new System.Drawing.Size(84, 61);
            this.languageButton.TabIndex = 15;
            this.languageButton.Text = "Ua";
            this.languageButton.UseVisualStyleBackColor = false;
            this.languageButton.Click += new System.EventHandler(this.languageButton_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(118)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.languageButton);
            this.Controls.Add(this.tentaclePictureBox);
            this.Controls.Add(this.rimuruPictureBox);
            this.Controls.Add(this.octopusPictureBox);
            this.Controls.Add(this.predatorPictureBox);
            this.Controls.Add(this.preyPictureBox);
            this.Controls.Add(this.rimuruInfoLabel);
            this.Controls.Add(this.predatorInfoLabel);
            this.Controls.Add(this.obstacleInfoLabel);
            this.Controls.Add(this.preyInfoLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Info";
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.preyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predatorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.octopusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimuruPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tentaclePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label preyInfoLabel;
        private System.Windows.Forms.Label obstacleInfoLabel;
        private System.Windows.Forms.Label predatorInfoLabel;
        private System.Windows.Forms.Label rimuruInfoLabel;
        private System.Windows.Forms.PictureBox preyPictureBox;
        private System.Windows.Forms.PictureBox predatorPictureBox;
        private System.Windows.Forms.PictureBox octopusPictureBox;
        private System.Windows.Forms.PictureBox rimuruPictureBox;
        private System.Windows.Forms.PictureBox tentaclePictureBox;
        private System.Windows.Forms.Button languageButton;
    }
}