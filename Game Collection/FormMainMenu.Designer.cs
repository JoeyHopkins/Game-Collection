namespace Game_Collection
{
    partial class FormMainMenu
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
            this.LabelGameCollectionMainMenu = new System.Windows.Forms.Label();
            this.LabelGameOneMainMenu = new System.Windows.Forms.Label();
            this.ButtonPlayMainMenu = new System.Windows.Forms.Button();
            this.ButtonNextGameMainMenu = new System.Windows.Forms.Button();
            this.ButtonPreviousGameMainMenu = new System.Windows.Forms.Button();
            this.LabelGameTwoMainMenu = new System.Windows.Forms.Label();
            this.TimerMainMenu = new System.Windows.Forms.Timer(this.components);
            this.LabelTest = new System.Windows.Forms.Label();
            this.ButtonQuitMainMenu = new System.Windows.Forms.Button();
            this.LabelGameThreeMainMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelGameCollectionMainMenu
            // 
            this.LabelGameCollectionMainMenu.AutoSize = true;
            this.LabelGameCollectionMainMenu.Font = new System.Drawing.Font("Vladimir Script", 101.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameCollectionMainMenu.Location = new System.Drawing.Point(235, 9);
            this.LabelGameCollectionMainMenu.Name = "LabelGameCollectionMainMenu";
            this.LabelGameCollectionMainMenu.Size = new System.Drawing.Size(530, 326);
            this.LabelGameCollectionMainMenu.TabIndex = 0;
            this.LabelGameCollectionMainMenu.Text = "Game\r\nCollection\r\n";
            this.LabelGameCollectionMainMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelGameOneMainMenu
            // 
            this.LabelGameOneMainMenu.AutoSize = true;
            this.LabelGameOneMainMenu.Font = new System.Drawing.Font("Brush Script MT", 75.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameOneMainMenu.Location = new System.Drawing.Point(330, 435);
            this.LabelGameOneMainMenu.Name = "LabelGameOneMainMenu";
            this.LabelGameOneMainMenu.Size = new System.Drawing.Size(290, 124);
            this.LabelGameOneMainMenu.TabIndex = 1;
            this.LabelGameOneMainMenu.Text = "Game 1";
            this.LabelGameOneMainMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonPlayMainMenu
            // 
            this.ButtonPlayMainMenu.Font = new System.Drawing.Font("Script MT Bold", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlayMainMenu.Location = new System.Drawing.Point(320, 645);
            this.ButtonPlayMainMenu.Name = "ButtonPlayMainMenu";
            this.ButtonPlayMainMenu.Size = new System.Drawing.Size(360, 102);
            this.ButtonPlayMainMenu.TabIndex = 2;
            this.ButtonPlayMainMenu.Text = "Play";
            this.ButtonPlayMainMenu.UseVisualStyleBackColor = true;
            this.ButtonPlayMainMenu.Click += new System.EventHandler(this.ButtonPlayMainMenu_Click);
            // 
            // ButtonNextGameMainMenu
            // 
            this.ButtonNextGameMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNextGameMainMenu.Location = new System.Drawing.Point(686, 645);
            this.ButtonNextGameMainMenu.Name = "ButtonNextGameMainMenu";
            this.ButtonNextGameMainMenu.Size = new System.Drawing.Size(103, 102);
            this.ButtonNextGameMainMenu.TabIndex = 3;
            this.ButtonNextGameMainMenu.Text = "Next Game";
            this.ButtonNextGameMainMenu.UseVisualStyleBackColor = true;
            this.ButtonNextGameMainMenu.Click += new System.EventHandler(this.ButtonNextGameMainMenu_Click);
            // 
            // ButtonPreviousGameMainMenu
            // 
            this.ButtonPreviousGameMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPreviousGameMainMenu.Location = new System.Drawing.Point(211, 645);
            this.ButtonPreviousGameMainMenu.Name = "ButtonPreviousGameMainMenu";
            this.ButtonPreviousGameMainMenu.Size = new System.Drawing.Size(103, 102);
            this.ButtonPreviousGameMainMenu.TabIndex = 4;
            this.ButtonPreviousGameMainMenu.Text = "Previous Game";
            this.ButtonPreviousGameMainMenu.UseVisualStyleBackColor = true;
            this.ButtonPreviousGameMainMenu.Click += new System.EventHandler(this.ButtonPreviousGameMainMenu_Click);
            // 
            // LabelGameTwoMainMenu
            // 
            this.LabelGameTwoMainMenu.AutoSize = true;
            this.LabelGameTwoMainMenu.Font = new System.Drawing.Font("Brush Script MT", 80.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameTwoMainMenu.Location = new System.Drawing.Point(330, 435);
            this.LabelGameTwoMainMenu.Name = "LabelGameTwoMainMenu";
            this.LabelGameTwoMainMenu.Size = new System.Drawing.Size(325, 131);
            this.LabelGameTwoMainMenu.TabIndex = 5;
            this.LabelGameTwoMainMenu.Text = "Game 2";
            this.LabelGameTwoMainMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimerMainMenu
            // 
            this.TimerMainMenu.Enabled = true;
            this.TimerMainMenu.Interval = 10;
            this.TimerMainMenu.Tick += new System.EventHandler(this.TimerMainMenu_Tick);
            // 
            // LabelTest
            // 
            this.LabelTest.AutoSize = true;
            this.LabelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTest.Location = new System.Drawing.Point(128, 324);
            this.LabelTest.Name = "LabelTest";
            this.LabelTest.Size = new System.Drawing.Size(186, 138);
            this.LabelTest.TabIndex = 6;
            this.LabelTest.Text = "Prev =\r\nCurrent =\r\nNext =";
            this.LabelTest.Visible = false;
            // 
            // ButtonQuitMainMenu
            // 
            this.ButtonQuitMainMenu.Font = new System.Drawing.Font("Script MT Bold", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuitMainMenu.Location = new System.Drawing.Point(320, 788);
            this.ButtonQuitMainMenu.Name = "ButtonQuitMainMenu";
            this.ButtonQuitMainMenu.Size = new System.Drawing.Size(360, 102);
            this.ButtonQuitMainMenu.TabIndex = 7;
            this.ButtonQuitMainMenu.Text = "Quit";
            this.ButtonQuitMainMenu.UseVisualStyleBackColor = true;
            this.ButtonQuitMainMenu.Click += new System.EventHandler(this.ButtonQuitMainMenu_Click);
            // 
            // LabelGameThreeMainMenu
            // 
            this.LabelGameThreeMainMenu.AutoSize = true;
            this.LabelGameThreeMainMenu.Font = new System.Drawing.Font("Brush Script MT", 80.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameThreeMainMenu.Location = new System.Drawing.Point(330, 435);
            this.LabelGameThreeMainMenu.Name = "LabelGameThreeMainMenu";
            this.LabelGameThreeMainMenu.Size = new System.Drawing.Size(333, 131);
            this.LabelGameThreeMainMenu.TabIndex = 8;
            this.LabelGameThreeMainMenu.Text = "Game 3";
            this.LabelGameThreeMainMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.LabelGameThreeMainMenu);
            this.Controls.Add(this.ButtonQuitMainMenu);
            this.Controls.Add(this.LabelTest);
            this.Controls.Add(this.LabelGameTwoMainMenu);
            this.Controls.Add(this.ButtonPreviousGameMainMenu);
            this.Controls.Add(this.ButtonNextGameMainMenu);
            this.Controls.Add(this.ButtonPlayMainMenu);
            this.Controls.Add(this.LabelGameOneMainMenu);
            this.Controls.Add(this.LabelGameCollectionMainMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "FormMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Collection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelGameCollectionMainMenu;
        private System.Windows.Forms.Label LabelGameOneMainMenu;
        private System.Windows.Forms.Button ButtonPlayMainMenu;
        private System.Windows.Forms.Button ButtonNextGameMainMenu;
        private System.Windows.Forms.Button ButtonPreviousGameMainMenu;
        private System.Windows.Forms.Label LabelGameTwoMainMenu;
        private System.Windows.Forms.Timer TimerMainMenu;
        private System.Windows.Forms.Label LabelTest;
        private System.Windows.Forms.Button ButtonQuitMainMenu;
        private System.Windows.Forms.Label LabelGameThreeMainMenu;
    }
}

