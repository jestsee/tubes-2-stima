﻿
namespace tubes2stima
{
    partial class recommendation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submit1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Button();
            this.explore = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.akun1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 55);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(42, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Friend Recommendation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(507, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Aplikasi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News701 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(115, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose Account";
            // 
            // submit1
            // 
            this.submit1.BackColor = System.Drawing.Color.Firebrick;
            this.submit1.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submit1.Location = new System.Drawing.Point(513, 143);
            this.submit1.Name = "submit1";
            this.submit1.Size = new System.Drawing.Size(113, 34);
            this.submit1.TabIndex = 9;
            this.submit1.Text = "Submit";
            this.submit1.UseVisualStyleBackColor = false;
            this.submit1.Click += new System.EventHandler(this.submit1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.Main);
            this.panel2.Controls.Add(this.explore);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 39);
            this.panel2.TabIndex = 10;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.Firebrick;
            this.Main.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Main.Location = new System.Drawing.Point(385, 3);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(171, 34);
            this.Main.TabIndex = 15;
            this.Main.Text = "Main Menu";
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // explore
            // 
            this.explore.BackColor = System.Drawing.Color.Firebrick;
            this.explore.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.explore.Location = new System.Drawing.Point(583, 3);
            this.explore.Name = "explore";
            this.explore.Size = new System.Drawing.Size(171, 34);
            this.explore.TabIndex = 14;
            this.explore.Text = "Explore Friends";
            this.explore.UseVisualStyleBackColor = false;
            this.explore.Click += new System.EventHandler(this.explore_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News701 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(140, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "GO!";
            // 
            // akun1
            // 
            this.akun1.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.akun1.FormattingEnabled = true;
            this.akun1.Location = new System.Drawing.Point(348, 102);
            this.akun1.Name = "akun1";
            this.akun1.Size = new System.Drawing.Size(278, 27);
            this.akun1.TabIndex = 11;
            this.akun1.SelectedIndexChanged += new System.EventHandler(this.akun1_SelectedIndexChanged);
            // 
            // recommendation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.akun1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.submit1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "recommendation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Friend Recommendation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.Button explore;
        private System.Windows.Forms.ComboBox akun1;
    }
}