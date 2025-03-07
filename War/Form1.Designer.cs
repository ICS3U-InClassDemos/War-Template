namespace War
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.warButton = new System.Windows.Forms.Button();
            this.playerCardLabel = new System.Windows.Forms.Label();
            this.cpuCardLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.recordLabel = new System.Windows.Forms.Label();
            this.pWinsLabel = new System.Windows.Forms.Label();
            this.cWinsLabel = new System.Windows.Forms.Label();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.cpuScoreLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // warButton
            // 
            this.warButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.warButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warButton.ForeColor = System.Drawing.Color.White;
            this.warButton.Location = new System.Drawing.Point(138, 124);
            this.warButton.Margin = new System.Windows.Forms.Padding(2);
            this.warButton.Name = "warButton";
            this.warButton.Size = new System.Drawing.Size(59, 45);
            this.warButton.TabIndex = 0;
            this.warButton.Text = "War";
            this.warButton.UseVisualStyleBackColor = true;
            this.warButton.Click += new System.EventHandler(this.warButton_Click);
            // 
            // playerCardLabel
            // 
            this.playerCardLabel.BackColor = System.Drawing.Color.White;
            this.playerCardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerCardLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCardLabel.ForeColor = System.Drawing.Color.Black;
            this.playerCardLabel.Image = ((System.Drawing.Image)(resources.GetObject("playerCardLabel.Image")));
            this.playerCardLabel.Location = new System.Drawing.Point(39, 101);
            this.playerCardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerCardLabel.Name = "playerCardLabel";
            this.playerCardLabel.Size = new System.Drawing.Size(61, 85);
            this.playerCardLabel.TabIndex = 1;
            this.playerCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuCardLabel
            // 
            this.cpuCardLabel.BackColor = System.Drawing.Color.White;
            this.cpuCardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpuCardLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuCardLabel.ForeColor = System.Drawing.Color.Black;
            this.cpuCardLabel.Image = ((System.Drawing.Image)(resources.GetObject("cpuCardLabel.Image")));
            this.cpuCardLabel.Location = new System.Drawing.Point(235, 101);
            this.cpuCardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuCardLabel.Name = "cpuCardLabel";
            this.cpuCardLabel.Size = new System.Drawing.Size(61, 85);
            this.cpuCardLabel.TabIndex = 2;
            this.cpuCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerLabel
            // 
            this.playerLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.White;
            this.playerLabel.Location = new System.Drawing.Point(39, 68);
            this.playerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(61, 25);
            this.playerLabel.TabIndex = 3;
            this.playerLabel.Text = "Player";
            this.playerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuLabel
            // 
            this.cpuLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLabel.ForeColor = System.Drawing.Color.White;
            this.cpuLabel.Location = new System.Drawing.Point(231, 68);
            this.cpuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(69, 25);
            this.cpuLabel.TabIndex = 4;
            this.cpuLabel.Text = "Computer";
            this.cpuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(42, 205);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(254, 30);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Press War button to begin";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backLabel
            // 
            this.backLabel.BackColor = System.Drawing.Color.White;
            this.backLabel.Location = new System.Drawing.Point(327, 6);
            this.backLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(120, 244);
            this.backLabel.TabIndex = 7;
            this.backLabel.Text = "label1";
            // 
            // recordLabel
            // 
            this.recordLabel.BackColor = System.Drawing.Color.Black;
            this.recordLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordLabel.Location = new System.Drawing.Point(330, 9);
            this.recordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(115, 40);
            this.recordLabel.TabIndex = 8;
            this.recordLabel.Text = "Win/Loss Record";
            this.recordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pWinsLabel
            // 
            this.pWinsLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pWinsLabel.Location = new System.Drawing.Point(330, 75);
            this.pWinsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pWinsLabel.Name = "pWinsLabel";
            this.pWinsLabel.Size = new System.Drawing.Size(115, 25);
            this.pWinsLabel.TabIndex = 9;
            this.pWinsLabel.Text = "Player";
            this.pWinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cWinsLabel
            // 
            this.cWinsLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cWinsLabel.Location = new System.Drawing.Point(330, 161);
            this.cWinsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cWinsLabel.Name = "cWinsLabel";
            this.cWinsLabel.Size = new System.Drawing.Size(115, 25);
            this.cWinsLabel.TabIndex = 10;
            this.cWinsLabel.Text = "Computer";
            this.cWinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.BackColor = System.Drawing.Color.White;
            this.playerScoreLabel.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.playerScoreLabel.Location = new System.Drawing.Point(363, 101);
            this.playerScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(47, 48);
            this.playerScoreLabel.TabIndex = 11;
            this.playerScoreLabel.Text = "0";
            this.playerScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuScoreLabel
            // 
            this.cpuScoreLabel.BackColor = System.Drawing.Color.White;
            this.cpuScoreLabel.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.cpuScoreLabel.Location = new System.Drawing.Point(363, 187);
            this.cpuScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuScoreLabel.Name = "cpuScoreLabel";
            this.cpuScoreLabel.Size = new System.Drawing.Size(47, 48);
            this.cpuScoreLabel.TabIndex = 12;
            this.cpuScoreLabel.Text = "0";
            this.cpuScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(42, 19);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(254, 30);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Card War... kind of";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(455, 255);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cpuScoreLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.cWinsLabel);
            this.Controls.Add(this.pWinsLabel);
            this.Controls.Add(this.recordLabel);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.cpuCardLabel);
            this.Controls.Add(this.playerCardLabel);
            this.Controls.Add(this.warButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "War";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button warButton;
        private System.Windows.Forms.Label playerCardLabel;
        private System.Windows.Forms.Label cpuCardLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label recordLabel;
        private System.Windows.Forms.Label pWinsLabel;
        private System.Windows.Forms.Label cWinsLabel;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label cpuScoreLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}

