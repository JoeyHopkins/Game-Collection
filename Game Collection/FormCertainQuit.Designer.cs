namespace Game_Collection
{
    partial class FormCertainQuit
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
            this.LabelAreYouSure = new System.Windows.Forms.Label();
            this.ButtonYesCertainQuit = new System.Windows.Forms.Button();
            this.ButtonNoCertainQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelAreYouSure
            // 
            this.LabelAreYouSure.AutoSize = true;
            this.LabelAreYouSure.Font = new System.Drawing.Font("Niagara Engraved", 51.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAreYouSure.Location = new System.Drawing.Point(10, 9);
            this.LabelAreYouSure.Name = "LabelAreYouSure";
            this.LabelAreYouSure.Size = new System.Drawing.Size(258, 73);
            this.LabelAreYouSure.TabIndex = 0;
            this.LabelAreYouSure.Text = "Are you sure?";
            // 
            // ButtonYesCertainQuit
            // 
            this.ButtonYesCertainQuit.Font = new System.Drawing.Font("Niagara Engraved", 35.25F);
            this.ButtonYesCertainQuit.Location = new System.Drawing.Point(12, 85);
            this.ButtonYesCertainQuit.Name = "ButtonYesCertainQuit";
            this.ButtonYesCertainQuit.Size = new System.Drawing.Size(119, 62);
            this.ButtonYesCertainQuit.TabIndex = 1;
            this.ButtonYesCertainQuit.Text = "Yes";
            this.ButtonYesCertainQuit.UseVisualStyleBackColor = true;
            this.ButtonYesCertainQuit.Click += new System.EventHandler(this.ButtonYesCertainQuit_Click);
            // 
            // ButtonNoCertainQuit
            // 
            this.ButtonNoCertainQuit.Font = new System.Drawing.Font("Niagara Engraved", 35.25F);
            this.ButtonNoCertainQuit.Location = new System.Drawing.Point(137, 85);
            this.ButtonNoCertainQuit.Name = "ButtonNoCertainQuit";
            this.ButtonNoCertainQuit.Size = new System.Drawing.Size(118, 62);
            this.ButtonNoCertainQuit.TabIndex = 2;
            this.ButtonNoCertainQuit.Text = "No";
            this.ButtonNoCertainQuit.UseVisualStyleBackColor = true;
            this.ButtonNoCertainQuit.Click += new System.EventHandler(this.ButtonNoCertainQuit_Click);
            // 
            // FormCertainQuit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(280, 164);
            this.Controls.Add(this.ButtonNoCertainQuit);
            this.Controls.Add(this.ButtonYesCertainQuit);
            this.Controls.Add(this.LabelAreYouSure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCertainQuit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCertainQuit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAreYouSure;
        private System.Windows.Forms.Button ButtonYesCertainQuit;
        private System.Windows.Forms.Button ButtonNoCertainQuit;
    }
}