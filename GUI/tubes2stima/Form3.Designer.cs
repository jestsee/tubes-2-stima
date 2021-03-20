
namespace tubes2stima
{
    partial class Explore
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
            this.label4 = new System.Windows.Forms.Label();
            this.akun1 = new System.Windows.Forms.ComboBox();
            this.akun2 = new System.Windows.Forms.ComboBox();
            this.submit1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Button();
            this.recommendation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 55);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(42, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Explore Friends";
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
            this.label3.Location = new System.Drawing.Point(107, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News701 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(107, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Explore Friends With";
            // 
            // akun1
            // 
            this.akun1.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.akun1.FormattingEnabled = true;
            this.akun1.Location = new System.Drawing.Point(403, 87);
            this.akun1.Name = "akun1";
            this.akun1.Size = new System.Drawing.Size(278, 27);
            this.akun1.TabIndex = 12;
            this.akun1.SelectedIndexChanged += new System.EventHandler(this.akun1_SelectedIndexChanged);
            // 
            // akun2
            // 
            this.akun2.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.akun2.FormattingEnabled = true;
            this.akun2.Location = new System.Drawing.Point(403, 132);
            this.akun2.Name = "akun2";
            this.akun2.Size = new System.Drawing.Size(278, 27);
            this.akun2.TabIndex = 13;
            this.akun2.SelectedIndexChanged += new System.EventHandler(this.akun2_SelectedIndexChanged);
            // 
            // submit1
            // 
            this.submit1.BackColor = System.Drawing.Color.Firebrick;
            this.submit1.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submit1.Location = new System.Drawing.Point(568, 186);
            this.submit1.Name = "submit1";
            this.submit1.Size = new System.Drawing.Size(113, 34);
            this.submit1.TabIndex = 14;
            this.submit1.Text = "Submit";
            this.submit1.UseVisualStyleBackColor = false;
            this.submit1.Click += new System.EventHandler(this.submit1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.Main);
            this.panel2.Controls.Add(this.recommendation);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-1, 505);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 39);
            this.panel2.TabIndex = 15;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.Firebrick;
            this.Main.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Main.Location = new System.Drawing.Point(329, 3);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(171, 34);
            this.Main.TabIndex = 15;
            this.Main.Text = "Main Menu";
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // recommendation
            // 
            this.recommendation.BackColor = System.Drawing.Color.Firebrick;
            this.recommendation.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.recommendation.Location = new System.Drawing.Point(525, 3);
            this.recommendation.Name = "recommendation";
            this.recommendation.Size = new System.Drawing.Size(229, 34);
            this.recommendation.TabIndex = 14;
            this.recommendation.Text = "Friend Recommendation";
            this.recommendation.UseVisualStyleBackColor = false;
            this.recommendation.Click += new System.EventHandler(this.recommendation_Click);
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
            // Explore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.submit1);
            this.Controls.Add(this.akun2);
            this.Controls.Add(this.akun1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Explore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explore Friends";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox akun1;
        private System.Windows.Forms.ComboBox akun2;
        private System.Windows.Forms.Button submit1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.Button recommendation;
        private System.Windows.Forms.Label label5;
    }
}