namespace Calculator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.MemoryScreen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MemoryScreen
            // 
            this.MemoryScreen.BackColor = System.Drawing.SystemColors.Control;
            this.MemoryScreen.Location = new System.Drawing.Point(70, 51);
            this.MemoryScreen.Margin = new System.Windows.Forms.Padding(0);
            this.MemoryScreen.Name = "MemoryScreen";
            this.MemoryScreen.ReadOnly = true;
            this.MemoryScreen.Size = new System.Drawing.Size(297, 27);
            this.MemoryScreen.TabIndex = 28;
            this.MemoryScreen.Text = "Sa nu mai vad ca faci asa !!!!";
            this.MemoryScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 147);
            this.Controls.Add(this.MemoryScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox MemoryScreen;
    }
}