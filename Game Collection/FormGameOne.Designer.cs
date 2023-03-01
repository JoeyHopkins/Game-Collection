namespace Game_Collection
{
    partial class FormGameOne
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
            this.components = new System.ComponentModel.Container();
            this.GameOneTimer = new System.Windows.Forms.Timer(this.components);
            this.BackgrounDirt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackgrounDirt)).BeginInit();
            this.SuspendLayout();
            // 
            // GameOneTimer
            // 
            this.GameOneTimer.Enabled = true;
            this.GameOneTimer.Interval = 50;
            this.GameOneTimer.Tick += new System.EventHandler(this.GameOneTimer_Tick);
            // 
            // BackgrounDirt
            // 
            this.BackgrounDirt.BackColor = System.Drawing.Color.Peru;
            this.BackgrounDirt.Location = new System.Drawing.Point(-22, 239);
            this.BackgrounDirt.Name = "BackgrounDirt";
            this.BackgrounDirt.Size = new System.Drawing.Size(1233, 816);
            this.BackgrounDirt.TabIndex = 3;
            this.BackgrounDirt.TabStop = false;
            this.BackgrounDirt.Tag = "Dirt";
            // 
            // FormGameOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.BackgrounDirt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "FormGameOne";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressedDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyReleased);
            ((System.ComponentModel.ISupportInitialize)(this.BackgrounDirt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameOneTimer;
        private System.Windows.Forms.PictureBox BackgrounDirt;
    }
}