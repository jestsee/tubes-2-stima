
namespace tubes2stima
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.file = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bfsbutton = new System.Windows.Forms.RadioButton();
            this.dfsbutton = new System.Windows.Forms.RadioButton();
            this.submit1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.explore = new System.Windows.Forms.Button();
            this.recommendation = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(268, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Aplikasi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Location = new System.Drawing.Point(-3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 55);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News701 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(93, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Graph File";
            // 
            // file
            // 
            this.file.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file.Location = new System.Drawing.Point(233, 106);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(332, 27);
            this.file.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(571, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "test1.txt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News701 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(93, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Algorithm";
            // 
            // bfsbutton
            // 
            this.bfsbutton.AutoSize = true;
            this.bfsbutton.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfsbutton.Location = new System.Drawing.Point(233, 150);
            this.bfsbutton.Name = "bfsbutton";
            this.bfsbutton.Size = new System.Drawing.Size(60, 23);
            this.bfsbutton.TabIndex = 6;
            this.bfsbutton.TabStop = true;
            this.bfsbutton.Text = "BFS";
            this.bfsbutton.UseVisualStyleBackColor = true;
            // 
            // dfsbutton
            // 
            this.dfsbutton.AutoSize = true;
            this.dfsbutton.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfsbutton.Location = new System.Drawing.Point(365, 150);
            this.dfsbutton.Name = "dfsbutton";
            this.dfsbutton.Size = new System.Drawing.Size(61, 23);
            this.dfsbutton.TabIndex = 7;
            this.dfsbutton.TabStop = true;
            this.dfsbutton.Text = "DFS";
            this.dfsbutton.UseVisualStyleBackColor = true;
            // 
            // submit1
            // 
            this.submit1.BackColor = System.Drawing.Color.Firebrick;
            this.submit1.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submit1.Location = new System.Drawing.Point(535, 170);
            this.submit1.Name = "submit1";
            this.submit1.Size = new System.Drawing.Size(113, 34);
            this.submit1.TabIndex = 8;
            this.submit1.Text = "Submit";
            this.submit1.UseVisualStyleBackColor = false;
            this.submit1.Click += new System.EventHandler(this.submit1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News701 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(129, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "GO!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.explore);
            this.panel2.Controls.Add(this.recommendation);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-3, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 39);
            this.panel2.TabIndex = 2;
            // 
            // explore
            // 
            this.explore.BackColor = System.Drawing.Color.Firebrick;
            this.explore.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.explore.Location = new System.Drawing.Point(578, 2);
            this.explore.Name = "explore";
            this.explore.Size = new System.Drawing.Size(171, 34);
            this.explore.TabIndex = 13;
            this.explore.Text = "Explore Friends";
            this.explore.UseVisualStyleBackColor = false;
            this.explore.Click += new System.EventHandler(this.explore_Click);
            // 
            // recommendation
            // 
            this.recommendation.BackColor = System.Drawing.Color.Firebrick;
            this.recommendation.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.recommendation.Location = new System.Drawing.Point(306, 2);
            this.recommendation.Name = "recommendation";
            this.recommendation.Size = new System.Drawing.Size(241, 34);
            this.recommendation.TabIndex = 12;
            this.recommendation.Text = "Friend Recommendation";
            this.recommendation.UseVisualStyleBackColor = false;
            this.recommendation.Click += new System.EventHandler(this.recommendation_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.submit1);
            this.Controls.Add(this.dfsbutton);
            this.Controls.Add(this.bfsbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.file);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nama Aplikasi";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox file;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton bfsbutton;
        private System.Windows.Forms.RadioButton dfsbutton;
        private System.Windows.Forms.Button submit1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button recommendation;
        private System.Windows.Forms.Button explore;
    }
}

