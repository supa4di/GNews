namespace WindowsFormsApp1
{
    partial class Browser
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
            this.Browser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // Browser1
            // 
            this.Browser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser1.Location = new System.Drawing.Point(0, 0);
            this.Browser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser1.Name = "Browser1";
            this.Browser1.Size = new System.Drawing.Size(800, 450);
            this.Browser1.TabIndex = 0;
            this.Browser1.Url = new System.Uri("", System.UriKind.Relative);
            this.Browser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Browser1);
            this.Name = "Browser";
            this.Text = "Browser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser Browser1;
    }
}