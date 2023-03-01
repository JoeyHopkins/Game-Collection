namespace Game_Collection
{
    partial class FormPauseMenu
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
            this.ContinuePauseMenu = new System.Windows.Forms.Button();
            this.QuitPauseMenu = new System.Windows.Forms.Button();
            this.LabelPauseMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContinuePauseMenu
            // 
            this.ContinuePauseMenu.Font = new System.Drawing.Font("Niagara Engraved", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinuePauseMenu.Location = new System.Drawing.Point(100, 175);
            this.ContinuePauseMenu.Name = "ContinuePauseMenu";
            this.ContinuePauseMenu.Size = new System.Drawing.Size(200, 56);
            this.ContinuePauseMenu.TabIndex = 0;
            this.ContinuePauseMenu.Text = "Continue";
            this.ContinuePauseMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ContinuePauseMenu.UseVisualStyleBackColor = true;
            this.ContinuePauseMenu.Click += new System.EventHandler(this.ContinuePauseMenu_Click);
            // 
            // QuitPauseMenu
            // 
            this.QuitPauseMenu.Font = new System.Drawing.Font("Niagara Engraved", 35.25F);
            this.QuitPauseMenu.Location = new System.Drawing.Point(100, 275);
            this.QuitPauseMenu.Name = "QuitPauseMenu";
            this.QuitPauseMenu.Size = new System.Drawing.Size(200, 56);
            this.QuitPauseMenu.TabIndex = 1;
            this.QuitPauseMenu.Text = "Quit";
            this.QuitPauseMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.QuitPauseMenu.UseVisualStyleBackColor = true;
            this.QuitPauseMenu.Click += new System.EventHandler(this.QuitPauseMenu_Click);
            // 
            // LabelPauseMenu
            // 
            this.LabelPauseMenu.AutoSize = true;
            this.LabelPauseMenu.Font = new System.Drawing.Font("Magneto", 75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPauseMenu.Location = new System.Drawing.Point(8, 9);
            this.LabelPauseMenu.Name = "LabelPauseMenu";
            this.LabelPauseMenu.Size = new System.Drawing.Size(380, 122);
            this.LabelPauseMenu.TabIndex = 2;
            this.LabelPauseMenu.Text = "Pause";
            // 
            // FormPauseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.LabelPauseMenu);
            this.Controls.Add(this.QuitPauseMenu);
            this.Controls.Add(this.ContinuePauseMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPauseMenu";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPauseMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ContinuePauseMenu;
        private System.Windows.Forms.Button QuitPauseMenu;
        private System.Windows.Forms.Label LabelPauseMenu;
    }
}