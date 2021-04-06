
namespace CircusTrein
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
            this.label1 = new System.Windows.Forms.Label();
            this.DierNaamTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GrootRB = new System.Windows.Forms.RadioButton();
            this.MiddelgrootRB = new System.Windows.Forms.RadioButton();
            this.KleinRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VleesRB = new System.Windows.Forms.RadioButton();
            this.PlantenRB = new System.Windows.Forms.RadioButton();
            this.DierToevoegenBtn = new System.Windows.Forms.Button();
            this.Wagon1 = new System.Windows.Forms.ListBox();
            this.Wagon2 = new System.Windows.Forms.ListBox();
            this.Wagon3 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Dier:";
            // 
            // DierNaamTB
            // 
            this.DierNaamTB.Location = new System.Drawing.Point(94, 13);
            this.DierNaamTB.Name = "DierNaamTB";
            this.DierNaamTB.Size = new System.Drawing.Size(131, 22);
            this.DierNaamTB.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GrootRB);
            this.groupBox1.Controls.Add(this.MiddelgrootRB);
            this.groupBox1.Controls.Add(this.KleinRB);
            this.groupBox1.Location = new System.Drawing.Point(550, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grootte";
            // 
            // GrootRB
            // 
            this.GrootRB.AutoSize = true;
            this.GrootRB.Location = new System.Drawing.Point(7, 78);
            this.GrootRB.Name = "GrootRB";
            this.GrootRB.Size = new System.Drawing.Size(65, 21);
            this.GrootRB.TabIndex = 2;
            this.GrootRB.TabStop = true;
            this.GrootRB.Text = "Groot";
            this.GrootRB.UseVisualStyleBackColor = true;
            // 
            // MiddelgrootRB
            // 
            this.MiddelgrootRB.AutoSize = true;
            this.MiddelgrootRB.Location = new System.Drawing.Point(7, 50);
            this.MiddelgrootRB.Name = "MiddelgrootRB";
            this.MiddelgrootRB.Size = new System.Drawing.Size(103, 21);
            this.MiddelgrootRB.TabIndex = 1;
            this.MiddelgrootRB.TabStop = true;
            this.MiddelgrootRB.Text = "Middelgroot";
            this.MiddelgrootRB.UseVisualStyleBackColor = true;
            // 
            // KleinRB
            // 
            this.KleinRB.AutoSize = true;
            this.KleinRB.Location = new System.Drawing.Point(7, 22);
            this.KleinRB.Name = "KleinRB";
            this.KleinRB.Size = new System.Drawing.Size(60, 21);
            this.KleinRB.TabIndex = 0;
            this.KleinRB.TabStop = true;
            this.KleinRB.Text = "Klein";
            this.KleinRB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VleesRB);
            this.groupBox2.Controls.Add(this.PlantenRB);
            this.groupBox2.Location = new System.Drawing.Point(550, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 81);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voeding";
            // 
            // VleesRB
            // 
            this.VleesRB.AutoSize = true;
            this.VleesRB.Location = new System.Drawing.Point(7, 50);
            this.VleesRB.Name = "VleesRB";
            this.VleesRB.Size = new System.Drawing.Size(64, 21);
            this.VleesRB.TabIndex = 1;
            this.VleesRB.TabStop = true;
            this.VleesRB.Text = "Vlees";
            this.VleesRB.UseVisualStyleBackColor = true;
            // 
            // PlantenRB
            // 
            this.PlantenRB.AutoSize = true;
            this.PlantenRB.Location = new System.Drawing.Point(7, 22);
            this.PlantenRB.Name = "PlantenRB";
            this.PlantenRB.Size = new System.Drawing.Size(77, 21);
            this.PlantenRB.TabIndex = 0;
            this.PlantenRB.TabStop = true;
            this.PlantenRB.Text = "Planten";
            this.PlantenRB.UseVisualStyleBackColor = true;
            // 
            // DierToevoegenBtn
            // 
            this.DierToevoegenBtn.Location = new System.Drawing.Point(41, 106);
            this.DierToevoegenBtn.Name = "DierToevoegenBtn";
            this.DierToevoegenBtn.Size = new System.Drawing.Size(107, 36);
            this.DierToevoegenBtn.TabIndex = 4;
            this.DierToevoegenBtn.Text = "Voeg toe";
            this.DierToevoegenBtn.UseVisualStyleBackColor = true;
            this.DierToevoegenBtn.Click += new System.EventHandler(this.DierToevoegenBtn_Click);
            // 
            // Wagon1
            // 
            this.Wagon1.FormattingEnabled = true;
            this.Wagon1.ItemHeight = 16;
            this.Wagon1.Location = new System.Drawing.Point(16, 193);
            this.Wagon1.Name = "Wagon1";
            this.Wagon1.Size = new System.Drawing.Size(170, 132);
            this.Wagon1.TabIndex = 5;
            // 
            // Wagon2
            // 
            this.Wagon2.FormattingEnabled = true;
            this.Wagon2.ItemHeight = 16;
            this.Wagon2.Location = new System.Drawing.Point(192, 193);
            this.Wagon2.Name = "Wagon2";
            this.Wagon2.Size = new System.Drawing.Size(170, 132);
            this.Wagon2.TabIndex = 6;
            // 
            // Wagon3
            // 
            this.Wagon3.FormattingEnabled = true;
            this.Wagon3.ItemHeight = 16;
            this.Wagon3.Location = new System.Drawing.Point(368, 193);
            this.Wagon3.Name = "Wagon3";
            this.Wagon3.Size = new System.Drawing.Size(170, 132);
            this.Wagon3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.Wagon3);
            this.Controls.Add(this.Wagon2);
            this.Controls.Add(this.Wagon1);
            this.Controls.Add(this.DierToevoegenBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DierNaamTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DierNaamTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton GrootRB;
        private System.Windows.Forms.RadioButton MiddelgrootRB;
        private System.Windows.Forms.RadioButton KleinRB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton VleesRB;
        private System.Windows.Forms.RadioButton PlantenRB;
        private System.Windows.Forms.Button DierToevoegenBtn;
        private System.Windows.Forms.ListBox Wagon1;
        private System.Windows.Forms.ListBox Wagon2;
        private System.Windows.Forms.ListBox Wagon3;
    }
}

