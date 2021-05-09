
namespace MovieSelector
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
            this.label1 = new System.Windows.Forms.Label();
            this.outputAllTimes = new System.Windows.Forms.Label();
            this.selectedMovieTime = new System.Windows.Forms.Label();
            this.listBoxMovies = new System.Windows.Forms.ListBox();
            this.outputMovieTimes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(204, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Movie";
            // 
            // outputAllTimes
            // 
            this.outputAllTimes.AutoSize = true;
            this.outputAllTimes.Location = new System.Drawing.Point(594, 63);
            this.outputAllTimes.Name = "outputAllTimes";
            this.outputAllTimes.Size = new System.Drawing.Size(11, 15);
            this.outputAllTimes.TabIndex = 1;
            this.outputAllTimes.Text = "t";
            // 
            // selectedMovieTime
            // 
            this.selectedMovieTime.AutoSize = true;
            this.selectedMovieTime.Location = new System.Drawing.Point(-361, 301);
            this.selectedMovieTime.Name = "selectedMovieTime";
            this.selectedMovieTime.Size = new System.Drawing.Size(0, 15);
            this.selectedMovieTime.TabIndex = 2;
            // 
            // listBoxMovies
            // 
            this.listBoxMovies.FormattingEnabled = true;
            this.listBoxMovies.ItemHeight = 15;
            this.listBoxMovies.Items.AddRange(new object[] {
            "Thor",
            "Avengers Endgame",
            "Too Fast Too Furious",
            "Predator",
            "War for the Planet of the Apes"});
            this.listBoxMovies.Location = new System.Drawing.Point(254, 124);
            this.listBoxMovies.Name = "listBoxMovies";
            this.listBoxMovies.Size = new System.Drawing.Size(136, 154);
            this.listBoxMovies.TabIndex = 3;
            this.listBoxMovies.SelectedIndexChanged += new System.EventHandler(this.listBoxMovies_SelectedIndexChanged);
            this.listBoxMovies.MouseEnter += new System.EventHandler(this.listBoxMovies_mouseEnter);
            this.listBoxMovies.MouseLeave += new System.EventHandler(this.listBoxMovies_mouseLeave);
            // 
            // outputMovieTimes
            // 
            this.outputMovieTimes.AutoSize = true;
            this.outputMovieTimes.Location = new System.Drawing.Point(204, 398);
            this.outputMovieTimes.Name = "outputMovieTimes";
            this.outputMovieTimes.Size = new System.Drawing.Size(10, 15);
            this.outputMovieTimes.TabIndex = 4;
            this.outputMovieTimes.Text = "l";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputMovieTimes);
            this.Controls.Add(this.listBoxMovies);
            this.Controls.Add(this.selectedMovieTime);
            this.Controls.Add(this.outputAllTimes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputAllTimes;
        private System.Windows.Forms.Label selectedMovieTime;
        private System.Windows.Forms.ListBox listBoxMovies;
        private System.Windows.Forms.Label outputMovieTimes;
    }
}

