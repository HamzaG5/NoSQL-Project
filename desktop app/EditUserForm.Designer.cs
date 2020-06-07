namespace desktop_app
{
    partial class EditUserForm
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
            this.BtnDelete_userManager = new FontAwesome.Sharp.IconButton();
            this.BtnEdit_userManager = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // BtnDelete_userManager
            // 
            this.BtnDelete_userManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDelete_userManager.FlatAppearance.BorderSize = 0;
            this.BtnDelete_userManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete_userManager.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDelete_userManager.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            this.BtnDelete_userManager.IconColor = System.Drawing.Color.Black;
            this.BtnDelete_userManager.IconSize = 32;
            this.BtnDelete_userManager.Location = new System.Drawing.Point(55, 470);
            this.BtnDelete_userManager.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelete_userManager.Name = "BtnDelete_userManager";
            this.BtnDelete_userManager.Rotation = 0D;
            this.BtnDelete_userManager.Size = new System.Drawing.Size(122, 42);
            this.BtnDelete_userManager.TabIndex = 11;
            this.BtnDelete_userManager.Text = "Delete";
            this.BtnDelete_userManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete_userManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelete_userManager.UseVisualStyleBackColor = false;
            this.BtnDelete_userManager.Click += new System.EventHandler(this.BtnDelete_userManager_Click);
            // 
            // BtnEdit_userManager
            // 
            this.BtnEdit_userManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnEdit_userManager.FlatAppearance.BorderSize = 0;
            this.BtnEdit_userManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit_userManager.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnEdit_userManager.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnEdit_userManager.IconColor = System.Drawing.Color.Black;
            this.BtnEdit_userManager.IconSize = 32;
            this.BtnEdit_userManager.Location = new System.Drawing.Point(251, 470);
            this.BtnEdit_userManager.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEdit_userManager.Name = "BtnEdit_userManager";
            this.BtnEdit_userManager.Rotation = 0D;
            this.BtnEdit_userManager.Size = new System.Drawing.Size(122, 42);
            this.BtnEdit_userManager.TabIndex = 10;
            this.BtnEdit_userManager.Text = "Edit";
            this.BtnEdit_userManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEdit_userManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEdit_userManager.UseVisualStyleBackColor = false;
            this.BtnEdit_userManager.Click += new System.EventHandler(this.BtnEdit_userManager_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 535);
            this.Controls.Add(this.BtnDelete_userManager);
            this.Controls.Add(this.BtnEdit_userManager);
            this.Name = "EditUserForm";
            this.Text = "EditUserForm";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnDelete_userManager;
        private FontAwesome.Sharp.IconButton BtnEdit_userManager;
    }
}