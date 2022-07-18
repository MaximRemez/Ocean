
namespace OceanWF.OceanMenu
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.startMenuButton = new System.Windows.Forms.Button();
            this.settingsMenuButton = new System.Windows.Forms.Button();
            this.exitMenuButton = new System.Windows.Forms.Button();
            this.titleMenuPictureBox = new System.Windows.Forms.PictureBox();
            this.defaultSettingsButton = new System.Windows.Forms.Button();
            this.menuToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.titleMenuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startMenuButton
            // 
            this.startMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.startMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(4)))), ((int)(((byte)(79)))));
            this.startMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startMenuButton.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMenuButton.ForeColor = System.Drawing.Color.Black;
            this.startMenuButton.Location = new System.Drawing.Point(35, 255);
            this.startMenuButton.Name = "startMenuButton";
            this.startMenuButton.Size = new System.Drawing.Size(130, 75);
            this.startMenuButton.TabIndex = 1;
            this.startMenuButton.Text = "Start";
            this.startMenuButton.UseVisualStyleBackColor = false;
            this.startMenuButton.Click += new System.EventHandler(this.startMenuButton_Click);
            // 
            // settingsMenuButton
            // 
            this.settingsMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.settingsMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.settingsMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(4)))), ((int)(((byte)(79)))));
            this.settingsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsMenuButton.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsMenuButton.ForeColor = System.Drawing.Color.Black;
            this.settingsMenuButton.Location = new System.Drawing.Point(230, 255);
            this.settingsMenuButton.Name = "settingsMenuButton";
            this.settingsMenuButton.Size = new System.Drawing.Size(130, 75);
            this.settingsMenuButton.TabIndex = 1;
            this.settingsMenuButton.Text = "Settings";
            this.settingsMenuButton.UseVisualStyleBackColor = false;
            this.settingsMenuButton.Click += new System.EventHandler(this.settingsMenuButton_Click);
            // 
            // exitMenuButton
            // 
            this.exitMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exitMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(4)))), ((int)(((byte)(79)))));
            this.exitMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitMenuButton.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMenuButton.ForeColor = System.Drawing.Color.Black;
            this.exitMenuButton.Location = new System.Drawing.Point(425, 255);
            this.exitMenuButton.Name = "exitMenuButton";
            this.exitMenuButton.Size = new System.Drawing.Size(130, 75);
            this.exitMenuButton.TabIndex = 1;
            this.exitMenuButton.Text = "Exit";
            this.exitMenuButton.UseVisualStyleBackColor = false;
            this.exitMenuButton.Click += new System.EventHandler(this.exitMenuButton_Click);
            // 
            // titleMenuPictureBox
            // 
            this.titleMenuPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleMenuPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.titleMenuPictureBox.BackgroundImage = global::OceanWF.Properties.Resources.labelMenu;
            this.titleMenuPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.titleMenuPictureBox.Location = new System.Drawing.Point(50, 30);
            this.titleMenuPictureBox.Name = "titleMenuPictureBox";
            this.titleMenuPictureBox.Size = new System.Drawing.Size(500, 100);
            this.titleMenuPictureBox.TabIndex = 2;
            this.titleMenuPictureBox.TabStop = false;
            // 
            // defaultSettingsButton
            // 
            this.defaultSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.defaultSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.defaultSettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(4)))), ((int)(((byte)(79)))));
            this.defaultSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultSettingsButton.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultSettingsButton.ForeColor = System.Drawing.Color.Black;
            this.defaultSettingsButton.Location = new System.Drawing.Point(161, 255);
            this.defaultSettingsButton.Name = "defaultSettingsButton";
            this.defaultSettingsButton.Size = new System.Drawing.Size(34, 75);
            this.defaultSettingsButton.TabIndex = 3;
            this.defaultSettingsButton.Text = "⚙";
            this.menuToolTip.SetToolTip(this.defaultSettingsButton, "set default settings");
            this.defaultSettingsButton.UseVisualStyleBackColor = false;
            this.defaultSettingsButton.Click += new System.EventHandler(this.defaultSettingsButton_Click);
            // 
            // menuToolTip
            // 
            this.menuToolTip.BackColor = System.Drawing.Color.Black;
            this.menuToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OceanWF.Properties.Resources.defaul_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 384);
            this.Controls.Add(this.defaultSettingsButton);
            this.Controls.Add(this.titleMenuPictureBox);
            this.Controls.Add(this.exitMenuButton);
            this.Controls.Add(this.settingsMenuButton);
            this.Controls.Add(this.startMenuButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Ocean model";
            ((System.ComponentModel.ISupportInitialize)(this.titleMenuPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startMenuButton;
        private System.Windows.Forms.Button settingsMenuButton;
        private System.Windows.Forms.Button exitMenuButton;
        private System.Windows.Forms.PictureBox titleMenuPictureBox;
        private System.Windows.Forms.Button defaultSettingsButton;
        private System.Windows.Forms.ToolTip menuToolTip;
    }
}

