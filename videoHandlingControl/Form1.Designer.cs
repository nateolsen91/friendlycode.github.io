
namespace Video_HandlingControl
{
    partial class Form1
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
            this.agreementLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.agreeBox = new System.Windows.Forms.CheckBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agreementLabel
            // 
            this.agreementLabel.AutoSize = true;
            this.agreementLabel.Location = new System.Drawing.Point(223, 283);
            this.agreementLabel.Name = "agreementLabel";
            this.agreementLabel.Size = new System.Drawing.Size(266, 15);
            this.agreementLabel.TabIndex = 0;
            this.agreementLabel.Text = "You must agree to the terms before downloading";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(100, 22);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(146, 60);
            this.warningLabel.TabIndex = 1;
            this.warningLabel.Text = "User Agreement\r\nWe are not responsible for\r\nanthing this software does\r\n\r\n";
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.Location = new System.Drawing.Point(223, 365);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(174, 15);
            this.downloadLabel.TabIndex = 2;
            this.downloadLabel.Text = "Software is being Downnloaded";
            // 
            // agreeBox
            // 
            this.agreeBox.AutoSize = true;
            this.agreeBox.Location = new System.Drawing.Point(100, 201);
            this.agreeBox.Name = "agreeBox";
            this.agreeBox.Size = new System.Drawing.Size(57, 19);
            this.agreeBox.TabIndex = 3;
            this.agreeBox.Text = "Agree";
            this.agreeBox.UseVisualStyleBackColor = true;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(223, 197);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(94, 49);
            this.downloadButton.TabIndex = 4;
            this.downloadButton.Text = "Click to \r\nDownload";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            this.downloadButton.MouseEnter += new System.EventHandler(this.downloadButton_Enter);
            this.downloadButton.MouseLeave += new System.EventHandler(this.downloadButton_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.agreeBox);
            this.Controls.Add(this.downloadLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.agreementLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label agreementLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label downloadLabel;
        private System.Windows.Forms.CheckBox agreeBox;
        private System.Windows.Forms.Button downloadButton;
    }
}

