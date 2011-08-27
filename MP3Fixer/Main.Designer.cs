namespace MP3Fixer
{
    partial class Main
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
            this.go = new System.Windows.Forms.Button();
            this.folder = new System.Windows.Forms.TextBox();
            this.files = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.go.Location = new System.Drawing.Point(437, 313);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(151, 23);
            this.go.TabIndex = 0;
            this.go.Text = "Go!";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // folder
            // 
            this.folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folder.Location = new System.Drawing.Point(12, 12);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(576, 20);
            this.folder.TabIndex = 1;
            // 
            // files
            // 
            this.files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.files.Location = new System.Drawing.Point(12, 38);
            this.files.Multiline = true;
            this.files.Name = "files";
            this.files.ReadOnly = true;
            this.files.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.files.Size = new System.Drawing.Size(576, 269);
            this.files.TabIndex = 2;
            // 
            // pin
            // 
            this.pin.BackColor = System.Drawing.Color.Gray;
            this.pin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pin.Location = new System.Drawing.Point(12, 313);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(75, 23);
            this.pin.TabIndex = 3;
            this.pin.Text = "Pin";
            this.pin.UseVisualStyleBackColor = false;
            this.pin.Click += new System.EventHandler(this.pin_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 348);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.files);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.go);
            this.MinimumSize = new System.Drawing.Size(250, 190);
            this.Name = "Main";
            this.Text = "MP3 Fixer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button go;
        private System.Windows.Forms.TextBox folder;
        private System.Windows.Forms.TextBox files;
        private System.Windows.Forms.Button pin;
    }
}

