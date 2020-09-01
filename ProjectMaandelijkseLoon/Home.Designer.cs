namespace ProjectMaandelijkseLoon
{
    partial class Home
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
            this.lbWerknemer = new System.Windows.Forms.ListBox();
            this.btnAddWerknemer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWerknemer
            // 
            this.lbWerknemer.FormattingEnabled = true;
            this.lbWerknemer.ItemHeight = 16;
            this.lbWerknemer.Location = new System.Drawing.Point(58, 58);
            this.lbWerknemer.Name = "lbWerknemer";
            this.lbWerknemer.Size = new System.Drawing.Size(199, 180);
            this.lbWerknemer.TabIndex = 0;
            // 
            // btnAddWerknemer
            // 
            this.btnAddWerknemer.Location = new System.Drawing.Point(365, 79);
            this.btnAddWerknemer.Name = "btnAddWerknemer";
            this.btnAddWerknemer.Size = new System.Drawing.Size(192, 46);
            this.btnAddWerknemer.TabIndex = 1;
            this.btnAddWerknemer.Text = "Add Werknemer";
            this.btnAddWerknemer.UseVisualStyleBackColor = true;
            this.btnAddWerknemer.Click += new System.EventHandler(this.btnAddWerknemer_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddWerknemer);
            this.Controls.Add(this.lbWerknemer);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbWerknemer;
        private System.Windows.Forms.Button btnAddWerknemer;
    }
}

