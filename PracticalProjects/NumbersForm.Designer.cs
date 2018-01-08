namespace PracticalProjects
{
    partial class NumbersForm
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
            this.ucNumbers1 = new PracticalProjects.UCNumbers();
            this.SuspendLayout();
            // 
            // ucNumbers1
            // 
            this.ucNumbers1.Location = new System.Drawing.Point(12, 12);
            this.ucNumbers1.Name = "ucNumbers1";
            this.ucNumbers1.Size = new System.Drawing.Size(1010, 687);
            this.ucNumbers1.TabIndex = 0;
            // 
            // NumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1034, 711);
            this.Controls.Add(this.ucNumbers1);
            this.Name = "NumbersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NumbersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UCNumbers ucNumbers1;
    }
}