namespace TicTacToe
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
            this.a11 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a12 = new System.Windows.Forms.Button();
            this.a13 = new System.Windows.Forms.Button();
            this.a21 = new System.Windows.Forms.Button();
            this.a22 = new System.Windows.Forms.Button();
            this.a23 = new System.Windows.Forms.Button();
            this.a31 = new System.Windows.Forms.Button();
            this.a32 = new System.Windows.Forms.Button();
            this.a33 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // a11
            // 
            this.a11.Font = new System.Drawing.Font("SimSun", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.a11.Location = new System.Drawing.Point(12, 45);
            this.a11.Name = "a11";
            this.a11.Size = new System.Drawing.Size(75, 75);
            this.a11.TabIndex = 0;
            this.a11.UseVisualStyleBackColor = true;
            this.a11.Click += new System.EventHandler(this.button_click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(263, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReStartToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // ReStartToolStripMenuItem
            // 
            this.ReStartToolStripMenuItem.Name = "ReStartToolStripMenuItem";
            this.ReStartToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.ReStartToolStripMenuItem.Text = "重新开始";
            this.ReStartToolStripMenuItem.Click += new System.EventHandler(this.ReStartToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.AboutToolStripMenuItem.Text = "关于";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // a12
            // 
            this.a12.Font = new System.Drawing.Font("SimSun", 25.8F, System.Drawing.FontStyle.Bold);
            this.a12.Location = new System.Drawing.Point(93, 45);
            this.a12.Name = "a12";
            this.a12.Size = new System.Drawing.Size(75, 75);
            this.a12.TabIndex = 2;
            this.a12.UseVisualStyleBackColor = true;
            this.a12.Click += new System.EventHandler(this.button_click);
            // 
            // a13
            // 
            this.a13.Font = new System.Drawing.Font("SimSun", 25.8F, System.Drawing.FontStyle.Bold);
            this.a13.Location = new System.Drawing.Point(174, 45);
            this.a13.Name = "a13";
            this.a13.Size = new System.Drawing.Size(75, 75);
            this.a13.TabIndex = 3;
            this.a13.UseVisualStyleBackColor = true;
            this.a13.Click += new System.EventHandler(this.button_click);
            // 
            // a21
            // 
            this.a21.Font = new System.Drawing.Font("SimSun", 25.8F, System.Drawing.FontStyle.Bold);
            this.a21.Location = new System.Drawing.Point(12, 126);
            this.a21.Name = "a21";
            this.a21.Size = new System.Drawing.Size(75, 75);
            this.a21.TabIndex = 4;
            this.a21.UseVisualStyleBackColor = true;
            this.a21.Click += new System.EventHandler(this.button_click);
            // 
            // a22
            // 
            this.a22.Font = new System.Drawing.Font("SimSun", 25.8F, System.Drawing.FontStyle.Bold);
            this.a22.Location = new System.Drawing.Point(93, 126);
            this.a22.Name = "a22";
            this.a22.Size = new System.Drawing.Size(75, 75);
            this.a22.TabIndex = 5;
            this.a22.UseVisualStyleBackColor = true;
            this.a22.Click += new System.EventHandler(this.button_click);
            // 
            // a23
            // 
            this.a23.Font = new System.Drawing.Font("SimSun", 25.8F, System.Drawing.FontStyle.Bold);
            this.a23.Location = new System.Drawing.Point(174, 126);
            this.a23.Name = "a23";
            this.a23.Size = new System.Drawing.Size(75, 75);
            this.a23.TabIndex = 6;
            this.a23.UseVisualStyleBackColor = true;
            this.a23.Click += new System.EventHandler(this.button_click);
            // 
            // a31
            // 
            this.a31.Font = new System.Drawing.Font("SimSun", 25.8F, System.Drawing.FontStyle.Bold);
            this.a31.Location = new System.Drawing.Point(12, 207);
            this.a31.Name = "a31";
            this.a31.Size = new System.Drawing.Size(75, 75);
            this.a31.TabIndex = 7;
            this.a31.UseVisualStyleBackColor = true;
            this.a31.Click += new System.EventHandler(this.button_click);
            // 
            // a32
            // 
            this.a32.Font = new System.Drawing.Font("SimSun", 25.8F, System.Drawing.FontStyle.Bold);
            this.a32.Location = new System.Drawing.Point(93, 207);
            this.a32.Name = "a32";
            this.a32.Size = new System.Drawing.Size(75, 75);
            this.a32.TabIndex = 8;
            this.a32.UseVisualStyleBackColor = true;
            this.a32.Click += new System.EventHandler(this.button_click);
            // 
            // a33
            // 
            this.a33.Font = new System.Drawing.Font("SimSun", 25.8F, System.Drawing.FontStyle.Bold);
            this.a33.Location = new System.Drawing.Point(174, 207);
            this.a33.Name = "a33";
            this.a33.Size = new System.Drawing.Size(75, 75);
            this.a33.TabIndex = 9;
            this.a33.UseVisualStyleBackColor = true;
            this.a33.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 301);
            this.Controls.Add(this.a33);
            this.Controls.Add(this.a32);
            this.Controls.Add(this.a31);
            this.Controls.Add(this.a23);
            this.Controls.Add(this.a22);
            this.Controls.Add(this.a21);
            this.Controls.Add(this.a13);
            this.Controls.Add(this.a12);
            this.Controls.Add(this.a11);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "井字棋";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button a11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Button a12;
        private System.Windows.Forms.Button a13;
        private System.Windows.Forms.Button a21;
        private System.Windows.Forms.Button a22;
        private System.Windows.Forms.Button a23;
        private System.Windows.Forms.Button a31;
        private System.Windows.Forms.Button a32;
        private System.Windows.Forms.Button a33;
    }
}

