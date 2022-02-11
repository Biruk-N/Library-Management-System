namespace Library_mgm
{
    partial class viewfeed
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
            this.c1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // c1
            // 
            this.c1.FormattingEnabled = true;
            this.c1.Location = new System.Drawing.Point(194, 78);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(261, 28);
            this.c1.TabIndex = 0;
            this.c1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // viewfeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 451);
            this.Controls.Add(this.c1);
            this.Name = "viewfeed";
            this.Text = "viewfeed";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox c1;
    }
}