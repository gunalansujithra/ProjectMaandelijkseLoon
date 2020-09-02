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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lbWerknemer.SelectedIndexChanged += new System.EventHandler(this.lbWerknemer_SelectedIndexChanged);
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
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(296, 179);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 38);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(414, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddWerknemer);
            this.Controls.Add(this.lbWerknemer);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWerknemer;
        private System.Windows.Forms.Button btnAddWerknemer;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
    }
}

