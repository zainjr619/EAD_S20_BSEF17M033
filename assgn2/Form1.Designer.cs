namespace assgn2
{
    partial class Form1
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(164, 67);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(129, 41);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New User";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExist
            // 
            this.btnExist.Location = new System.Drawing.Point(164, 127);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(129, 41);
            this.btnExist.TabIndex = 1;
            this.btnExist.Text = "Existing User";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(164, 187);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(129, 41);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(164, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 41);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 307);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnNew);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnExit;
    }
}

