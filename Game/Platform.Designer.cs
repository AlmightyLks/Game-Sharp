namespace Game
{
    partial class Platform
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.DragPanel = new System.Windows.Forms.Button();
            this.GameArea = new System.Windows.Forms.Panel();
            this.PlayerObj = new Game.Game_Objects.Player();
            this.GameArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(782, -2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(19, 20);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "x";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DragPanel
            // 
            this.DragPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DragPanel.Location = new System.Drawing.Point(-4, -2);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(789, 20);
            this.DragPanel.TabIndex = 1;
            this.DragPanel.TabStop = false;
            this.DragPanel.Text = "Kades Game Engine";
            this.DragPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DragPanel.UseVisualStyleBackColor = true;
            // 
            // GameArea
            // 
            this.GameArea.Controls.Add(this.PlayerObj);
            this.GameArea.Location = new System.Drawing.Point(0, 17);
            this.GameArea.Name = "GameArea";
            this.GameArea.Size = new System.Drawing.Size(801, 435);
            this.GameArea.TabIndex = 2;
            // 
            // PlayerObj
            // 
            this.PlayerObj.BackColor = System.Drawing.Color.Lime;
            this.PlayerObj.Location = new System.Drawing.Point(416, 210);
            this.PlayerObj.Name = "PlayerObj";
            this.PlayerObj.Size = new System.Drawing.Size(37, 37);
            this.PlayerObj.TabIndex = 0;
            // 
            // Platform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GameArea);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Platform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Platform_Load);
            this.GameArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DragPanel;
        private System.Windows.Forms.Panel GameArea;
        private Game_Objects.Player PlayerObj;
    }
}

