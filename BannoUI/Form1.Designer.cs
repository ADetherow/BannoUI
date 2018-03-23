namespace BannoUI
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.authorLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.colorLabelTwo = new System.Windows.Forms.Label();
            this.colorLabelOne = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.twitterHandleLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.charCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.finInstCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pngCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.exitButton);
            this.titlePanel.Controls.Add(this.authorLabel);
            this.titlePanel.Controls.Add(this.startButton);
            this.titlePanel.Controls.Add(this.colorLabelTwo);
            this.titlePanel.Controls.Add(this.colorLabelOne);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Location = new System.Drawing.Point(-7, -28);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1012, 580);
            this.titlePanel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.exitButton.BackColor = System.Drawing.Color.Silver;
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.exitButton.Location = new System.Drawing.Point(600, 400);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 52);
            this.exitButton.TabIndex = 10;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.BackColor = System.Drawing.Color.Maroon;
            this.authorLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.ForeColor = System.Drawing.Color.Silver;
            this.authorLabel.Location = new System.Drawing.Point(229, 328);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(520, 67);
            this.authorLabel.TabIndex = 9;
            this.authorLabel.Text = "by Alex Detherow";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Silver;
            this.startButton.FlatAppearance.BorderSize = 2;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.startButton.Location = new System.Drawing.Point(300, 400);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(108, 52);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // colorLabelTwo
            // 
            this.colorLabelTwo.BackColor = System.Drawing.Color.Gray;
            this.colorLabelTwo.Location = new System.Drawing.Point(748, 0);
            this.colorLabelTwo.Name = "colorLabelTwo";
            this.colorLabelTwo.Size = new System.Drawing.Size(240, 699);
            this.colorLabelTwo.TabIndex = 4;
            // 
            // colorLabelOne
            // 
            this.colorLabelOne.BackColor = System.Drawing.Color.Gray;
            this.colorLabelOne.ForeColor = System.Drawing.Color.Maroon;
            this.colorLabelOne.Location = new System.Drawing.Point(7, 0);
            this.colorLabelOne.Name = "colorLabelOne";
            this.colorLabelOne.Size = new System.Drawing.Size(223, 699);
            this.colorLabelOne.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Silver;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(232, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(517, 395);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Banno Application Project";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.twitterHandleLabel);
            this.infoPanel.Controls.Add(this.label5);
            this.infoPanel.Controls.Add(this.charCountLabel);
            this.infoPanel.Controls.Add(this.label3);
            this.infoPanel.Controls.Add(this.finInstCountLabel);
            this.infoPanel.Controls.Add(this.label4);
            this.infoPanel.Controls.Add(this.pngCountLabel);
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Controls.Add(this.productCountLabel);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.ForeColor = System.Drawing.Color.Maroon;
            this.infoPanel.Location = new System.Drawing.Point(2, 2);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(988, 1080);
            this.infoPanel.TabIndex = 11;
            this.infoPanel.Visible = false;
            // 
            // twitterHandleLabel
            // 
            this.twitterHandleLabel.BackColor = System.Drawing.Color.DimGray;
            this.twitterHandleLabel.ForeColor = System.Drawing.Color.Silver;
            this.twitterHandleLabel.Location = new System.Drawing.Point(385, 329);
            this.twitterHandleLabel.Name = "twitterHandleLabel";
            this.twitterHandleLabel.Size = new System.Drawing.Size(593, 155);
            this.twitterHandleLabel.TabIndex = 12;
            this.twitterHandleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(609, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Twitter Handle";
            // 
            // charCountLabel
            // 
            this.charCountLabel.BackColor = System.Drawing.Color.Silver;
            this.charCountLabel.ForeColor = System.Drawing.Color.Black;
            this.charCountLabel.Location = new System.Drawing.Point(7, 22);
            this.charCountLabel.Name = "charCountLabel";
            this.charCountLabel.Size = new System.Drawing.Size(284, 289);
            this.charCountLabel.TabIndex = 9;
            this.charCountLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Character Stats Count";
            // 
            // finInstCountLabel
            // 
            this.finInstCountLabel.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finInstCountLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.finInstCountLabel.Location = new System.Drawing.Point(385, 179);
            this.finInstCountLabel.Name = "finInstCountLabel";
            this.finInstCountLabel.Size = new System.Drawing.Size(301, 40);
            this.finInstCountLabel.TabIndex = 7;
            this.finInstCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(385, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "\"Financial Institution\" use Count";
            // 
            // pngCountLabel
            // 
            this.pngCountLabel.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pngCountLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pngCountLabel.Location = new System.Drawing.Point(830, 70);
            this.pngCountLabel.Name = "pngCountLabel";
            this.pngCountLabel.Size = new System.Drawing.Size(148, 40);
            this.pngCountLabel.TabIndex = 5;
            this.pngCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(827, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = ".PNGs on Website";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productCountLabel
            // 
            this.productCountLabel.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCountLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.productCountLabel.Location = new System.Drawing.Point(420, 70);
            this.productCountLabel.Name = "productCountLabel";
            this.productCountLabel.Size = new System.Drawing.Size(211, 40);
            this.productCountLabel.TabIndex = 3;
            this.productCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(420, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Products Offered";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(992, 537);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.titlePanel);
            this.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "BannoAppForm";
            this.titlePanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label colorLabelTwo;
        private System.Windows.Forms.Label colorLabelOne;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label charCountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label finInstCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pngCountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label productCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label twitterHandleLabel;
        private System.Windows.Forms.Label label5;
    }
}

