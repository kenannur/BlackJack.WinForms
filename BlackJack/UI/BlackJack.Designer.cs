namespace BlackJack
{
    partial class BlackJackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJackForm));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newGameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dc1 = new System.Windows.Forms.PictureBox();
            this.dc2 = new System.Windows.Forms.PictureBox();
            this.pc1 = new System.Windows.Forms.PictureBox();
            this.pc2 = new System.Windows.Forms.PictureBox();
            this.pc3 = new System.Windows.Forms.PictureBox();
            this.pc4 = new System.Windows.Forms.PictureBox();
            this.pc5 = new System.Windows.Forms.PictureBox();
            this.dc3 = new System.Windows.Forms.PictureBox();
            this.dc4 = new System.Windows.Forms.PictureBox();
            this.dc5 = new System.Windows.Forms.PictureBox();
            this.dealerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerTotalLabel = new System.Windows.Forms.Label();
            this.dealerTotalLabel = new System.Windows.Forms.Label();
            this.dealButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc5)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Spade1.png");
            this.imageList.Images.SetKeyName(1, "Spade2.png");
            this.imageList.Images.SetKeyName(2, "Spade3.png");
            this.imageList.Images.SetKeyName(3, "Spade4.png");
            this.imageList.Images.SetKeyName(4, "Spade5.png");
            this.imageList.Images.SetKeyName(5, "Spade6.png");
            this.imageList.Images.SetKeyName(6, "Spade7.png");
            this.imageList.Images.SetKeyName(7, "Spade8.png");
            this.imageList.Images.SetKeyName(8, "Spade9.png");
            this.imageList.Images.SetKeyName(9, "Spade10.png");
            this.imageList.Images.SetKeyName(10, "Spade11.png");
            this.imageList.Images.SetKeyName(11, "Spade12.png");
            this.imageList.Images.SetKeyName(12, "Spade13.png");
            this.imageList.Images.SetKeyName(13, "Heart1.png");
            this.imageList.Images.SetKeyName(14, "Heart2.png");
            this.imageList.Images.SetKeyName(15, "Heart3.png");
            this.imageList.Images.SetKeyName(16, "Heart4.png");
            this.imageList.Images.SetKeyName(17, "Heart5.png");
            this.imageList.Images.SetKeyName(18, "Heart6.png");
            this.imageList.Images.SetKeyName(19, "Heart7.png");
            this.imageList.Images.SetKeyName(20, "Heart8.png");
            this.imageList.Images.SetKeyName(21, "Heart9.png");
            this.imageList.Images.SetKeyName(22, "Heart10.png");
            this.imageList.Images.SetKeyName(23, "Heart11.png");
            this.imageList.Images.SetKeyName(24, "Heart12.png");
            this.imageList.Images.SetKeyName(25, "Heart13.png");
            this.imageList.Images.SetKeyName(26, "Diamond1.png");
            this.imageList.Images.SetKeyName(27, "Diamond2.png");
            this.imageList.Images.SetKeyName(28, "Diamond3.png");
            this.imageList.Images.SetKeyName(29, "Diamond4.png");
            this.imageList.Images.SetKeyName(30, "Diamond5.png");
            this.imageList.Images.SetKeyName(31, "Diamond6.png");
            this.imageList.Images.SetKeyName(32, "Diamond7.png");
            this.imageList.Images.SetKeyName(33, "Diamond8.png");
            this.imageList.Images.SetKeyName(34, "Diamond9.png");
            this.imageList.Images.SetKeyName(35, "Diamond10.png");
            this.imageList.Images.SetKeyName(36, "Diamond11.png");
            this.imageList.Images.SetKeyName(37, "Diamond12.png");
            this.imageList.Images.SetKeyName(38, "Diamond13.png");
            this.imageList.Images.SetKeyName(39, "Club1.png");
            this.imageList.Images.SetKeyName(40, "Club2.png");
            this.imageList.Images.SetKeyName(41, "Club3.png");
            this.imageList.Images.SetKeyName(42, "Club4.png");
            this.imageList.Images.SetKeyName(43, "Club5.png");
            this.imageList.Images.SetKeyName(44, "Club6.png");
            this.imageList.Images.SetKeyName(45, "Club7.png");
            this.imageList.Images.SetKeyName(46, "Club8.png");
            this.imageList.Images.SetKeyName(47, "Club9.png");
            this.imageList.Images.SetKeyName(48, "Club10.png");
            this.imageList.Images.SetKeyName(49, "Club11.png");
            this.imageList.Images.SetKeyName(50, "Club12.png");
            this.imageList.Images.SetKeyName(51, "Club13.png");
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1326, 36);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // newGameToolStripButton
            // 
            this.newGameToolStripButton.Font = new System.Drawing.Font("AR DESTINE", 15F);
            this.newGameToolStripButton.ForeColor = System.Drawing.Color.Black;
            this.newGameToolStripButton.Image = global::BlackJack.Properties.Resources._21transparent;
            this.newGameToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newGameToolStripButton.Name = "newGameToolStripButton";
            this.newGameToolStripButton.Size = new System.Drawing.Size(166, 33);
            this.newGameToolStripButton.Text = "NEW GAME";
            this.newGameToolStripButton.Click += new System.EventHandler(this.newGameToolStripButton_Click);
            // 
            // dc1
            // 
            this.dc1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dc1.Location = new System.Drawing.Point(130, 110);
            this.dc1.Name = "dc1";
            this.dc1.Size = new System.Drawing.Size(120, 150);
            this.dc1.TabIndex = 35;
            this.dc1.TabStop = false;
            // 
            // dc2
            // 
            this.dc2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dc2.Location = new System.Drawing.Point(180, 110);
            this.dc2.Name = "dc2";
            this.dc2.Size = new System.Drawing.Size(120, 150);
            this.dc2.TabIndex = 36;
            this.dc2.TabStop = false;
            // 
            // pc1
            // 
            this.pc1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pc1.Location = new System.Drawing.Point(130, 453);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(120, 150);
            this.pc1.TabIndex = 37;
            this.pc1.TabStop = false;
            // 
            // pc2
            // 
            this.pc2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pc2.Location = new System.Drawing.Point(180, 453);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(120, 150);
            this.pc2.TabIndex = 38;
            this.pc2.TabStop = false;
            // 
            // pc3
            // 
            this.pc3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pc3.Location = new System.Drawing.Point(230, 453);
            this.pc3.Name = "pc3";
            this.pc3.Size = new System.Drawing.Size(120, 150);
            this.pc3.TabIndex = 39;
            this.pc3.TabStop = false;
            // 
            // pc4
            // 
            this.pc4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pc4.Location = new System.Drawing.Point(280, 453);
            this.pc4.Name = "pc4";
            this.pc4.Size = new System.Drawing.Size(120, 150);
            this.pc4.TabIndex = 40;
            this.pc4.TabStop = false;
            // 
            // pc5
            // 
            this.pc5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pc5.Location = new System.Drawing.Point(330, 453);
            this.pc5.Name = "pc5";
            this.pc5.Size = new System.Drawing.Size(120, 150);
            this.pc5.TabIndex = 41;
            this.pc5.TabStop = false;
            // 
            // dc3
            // 
            this.dc3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dc3.Location = new System.Drawing.Point(230, 110);
            this.dc3.Name = "dc3";
            this.dc3.Size = new System.Drawing.Size(120, 150);
            this.dc3.TabIndex = 42;
            this.dc3.TabStop = false;
            // 
            // dc4
            // 
            this.dc4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dc4.Location = new System.Drawing.Point(280, 110);
            this.dc4.Name = "dc4";
            this.dc4.Size = new System.Drawing.Size(120, 150);
            this.dc4.TabIndex = 43;
            this.dc4.TabStop = false;
            // 
            // dc5
            // 
            this.dc5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dc5.Location = new System.Drawing.Point(330, 110);
            this.dc5.Name = "dc5";
            this.dc5.Size = new System.Drawing.Size(120, 150);
            this.dc5.TabIndex = 44;
            this.dc5.TabStop = false;
            // 
            // dealerLabel
            // 
            this.dealerLabel.AutoSize = true;
            this.dealerLabel.Font = new System.Drawing.Font("AR DESTINE", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.dealerLabel.Location = new System.Drawing.Point(126, 87);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(51, 20);
            this.dealerLabel.TabIndex = 45;
            this.dealerLabel.Text = "KASA";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("AR DESTINE", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.playerLabel.Location = new System.Drawing.Point(126, 606);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(70, 20);
            this.playerLabel.TabIndex = 46;
            this.playerLabel.Text = "OYUNCU";
            // 
            // playerTotalLabel
            // 
            this.playerTotalLabel.AutoSize = true;
            this.playerTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTotalLabel.Location = new System.Drawing.Point(127, 421);
            this.playerTotalLabel.Name = "playerTotalLabel";
            this.playerTotalLabel.Size = new System.Drawing.Size(27, 29);
            this.playerTotalLabel.TabIndex = 47;
            this.playerTotalLabel.Text = "0";
            // 
            // dealerTotalLabel
            // 
            this.dealerTotalLabel.AutoSize = true;
            this.dealerTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerTotalLabel.Location = new System.Drawing.Point(127, 263);
            this.dealerTotalLabel.Name = "dealerTotalLabel";
            this.dealerTotalLabel.Size = new System.Drawing.Size(27, 29);
            this.dealerTotalLabel.TabIndex = 48;
            this.dealerTotalLabel.Text = "0";
            // 
            // dealButton
            // 
            this.dealButton.Font = new System.Drawing.Font("AR DESTINE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealButton.Location = new System.Drawing.Point(396, 304);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(90, 33);
            this.dealButton.TabIndex = 49;
            this.dealButton.Text = "DEAL";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.Font = new System.Drawing.Font("AR DESTINE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.Location = new System.Drawing.Point(348, 343);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(90, 33);
            this.hitButton.TabIndex = 50;
            this.hitButton.Text = "HIT";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.Font = new System.Drawing.Font("AR DESTINE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standButton.Location = new System.Drawing.Point(444, 343);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(90, 33);
            this.standButton.TabIndex = 51;
            this.standButton.Text = "STAND";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BlackJackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1326, 699);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.dealerTotalLabel);
            this.Controls.Add(this.playerTotalLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.dealerLabel);
            this.Controls.Add(this.dc5);
            this.Controls.Add(this.dc4);
            this.Controls.Add(this.dc3);
            this.Controls.Add(this.pc5);
            this.Controls.Add(this.pc4);
            this.Controls.Add(this.pc3);
            this.Controls.Add(this.pc2);
            this.Controls.Add(this.pc1);
            this.Controls.Add(this.dc2);
            this.Controls.Add(this.dc1);
            this.Controls.Add(this.toolStrip);
            this.Name = "BlackJackForm";
            this.Text = "BlackJack";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton newGameToolStripButton;
        private System.Windows.Forms.PictureBox dc1;
        private System.Windows.Forms.PictureBox dc2;
        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.PictureBox pc2;
        private System.Windows.Forms.PictureBox pc3;
        private System.Windows.Forms.PictureBox pc4;
        private System.Windows.Forms.PictureBox pc5;
        private System.Windows.Forms.PictureBox dc3;
        private System.Windows.Forms.PictureBox dc4;
        private System.Windows.Forms.PictureBox dc5;
        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label playerTotalLabel;
        private System.Windows.Forms.Label dealerTotalLabel;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Timer timer;
    }
}

