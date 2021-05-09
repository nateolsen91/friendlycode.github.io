
namespace addListLecture
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.editTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(125, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 229);
            this.listBox1.TabIndex = 0;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(543, 120);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 36);
            this.addItemButton.TabIndex = 1;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(543, 218);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 36);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(543, 313);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 36);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // editTextBox
            // 
            this.editTextBox.Location = new System.Drawing.Point(125, 52);
            this.editTextBox.Name = "editTextBox";
            this.editTextBox.Size = new System.Drawing.Size(266, 23);
            this.editTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox editTextBox;
    }
}

