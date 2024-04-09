namespace BaycentricCoordinateSystem
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
            this.DrawButton = new System.Windows.Forms.Button();
            this.trianglePictureBox = new System.Windows.Forms.PictureBox();
            this.V1Label = new System.Windows.Forms.Label();
            this.V2Label = new System.Windows.Forms.Label();
            this.V3Label = new System.Windows.Forms.Label();
            this.V1Button = new System.Windows.Forms.Button();
            this.V2Button = new System.Windows.Forms.Button();
            this.V3Button = new System.Windows.Forms.Button();
            this.DrawPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trianglePictureBox)).BeginInit();
            this.DrawPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(282, 626);
            this.DrawButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(200, 55);
            this.DrawButton.TabIndex = 0;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // trianglePictureBox
            // 
            this.trianglePictureBox.Location = new System.Drawing.Point(66, 59);
            this.trianglePictureBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.trianglePictureBox.Name = "trianglePictureBox";
            this.trianglePictureBox.Size = new System.Drawing.Size(577, 388);
            this.trianglePictureBox.TabIndex = 1;
            this.trianglePictureBox.TabStop = false;
            // 
            // V1Label
            // 
            this.V1Label.AutoSize = true;
            this.V1Label.Location = new System.Drawing.Point(6, 22);
            this.V1Label.Name = "V1Label";
            this.V1Label.Size = new System.Drawing.Size(49, 32);
            this.V1Label.TabIndex = 2;
            this.V1Label.Text = "V1";
            // 
            // V2Label
            // 
            this.V2Label.AutoSize = true;
            this.V2Label.Location = new System.Drawing.Point(686, 71);
            this.V2Label.Name = "V2Label";
            this.V2Label.Size = new System.Drawing.Size(49, 32);
            this.V2Label.TabIndex = 3;
            this.V2Label.Text = "V2";
            // 
            // V3Label
            // 
            this.V3Label.AutoSize = true;
            this.V3Label.Location = new System.Drawing.Point(329, 466);
            this.V3Label.Name = "V3Label";
            this.V3Label.Size = new System.Drawing.Size(49, 32);
            this.V3Label.TabIndex = 4;
            this.V3Label.Text = "V3";
            // 
            // V1Button
            // 
            this.V1Button.Location = new System.Drawing.Point(946, 114);
            this.V1Button.Name = "V1Button";
            this.V1Button.Size = new System.Drawing.Size(356, 64);
            this.V1Button.TabIndex = 5;
            this.V1Button.Tag = "1";
            this.V1Button.Text = "Choose V1 color";
            this.V1Button.UseVisualStyleBackColor = true;
            this.V1Button.Click += new System.EventHandler(this.ChooseColorButton_Click);
            // 
            // V2Button
            // 
            this.V2Button.Location = new System.Drawing.Point(946, 273);
            this.V2Button.Name = "V2Button";
            this.V2Button.Size = new System.Drawing.Size(356, 64);
            this.V2Button.TabIndex = 6;
            this.V2Button.Tag = "2";
            this.V2Button.Text = "Choose V2 color";
            this.V2Button.UseVisualStyleBackColor = true;
            this.V2Button.Click += new System.EventHandler(this.ChooseColorButton_Click);
            // 
            // V3Button
            // 
            this.V3Button.Location = new System.Drawing.Point(946, 432);
            this.V3Button.Name = "V3Button";
            this.V3Button.Size = new System.Drawing.Size(356, 64);
            this.V3Button.TabIndex = 7;
            this.V3Button.Tag = "3";
            this.V3Button.Text = "Choose V3 color";
            this.V3Button.UseVisualStyleBackColor = true;
            this.V3Button.Click += new System.EventHandler(this.ChooseColorButton_Click);
            // 
            // DrawPanel
            // 
            this.DrawPanel.Controls.Add(this.V3Label);
            this.DrawPanel.Controls.Add(this.V2Label);
            this.DrawPanel.Controls.Add(this.V1Label);
            this.DrawPanel.Controls.Add(this.trianglePictureBox);
            this.DrawPanel.Location = new System.Drawing.Point(26, 49);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(759, 508);
            this.DrawPanel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 799);
            this.Controls.Add(this.V3Button);
            this.Controls.Add(this.V2Button);
            this.Controls.Add(this.V1Button);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.DrawPanel);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trianglePictureBox)).EndInit();
            this.DrawPanel.ResumeLayout(false);
            this.DrawPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.PictureBox trianglePictureBox;
        private System.Windows.Forms.Label V1Label;
        private System.Windows.Forms.Label V2Label;
        private System.Windows.Forms.Label V3Label;
        private System.Windows.Forms.Button V1Button;
        private System.Windows.Forms.Button V2Button;
        private System.Windows.Forms.Button V3Button;
        private System.Windows.Forms.Panel DrawPanel;
    }
}

