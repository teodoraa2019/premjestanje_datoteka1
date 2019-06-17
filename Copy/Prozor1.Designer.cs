using System;

namespace Copy
{
    partial class Prozor1
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
            this.button1 = new System.Windows.Forms.Button();
            this.sourceFolder = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.targetFolder = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceListBox = new System.Windows.Forms.ListBox();
            this.targetListBox = new System.Windows.Forms.ListBox();
            this.currentFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Otvori: ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sourceFolder
            // 
            this.sourceFolder.Location = new System.Drawing.Point(93, 17);
            this.sourceFolder.Name = "sourceFolder";
            this.sourceFolder.Size = new System.Drawing.Size(300, 20);
            this.sourceFolder.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Otvori: ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // targetFolder
            // 
            this.targetFolder.Location = new System.Drawing.Point(490, 16);
            this.targetFolder.Name = "targetFolder";
            this.targetFolder.Size = new System.Drawing.Size(289, 20);
            this.targetFolder.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(354, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 32);
            this.button5.TabIndex = 8;
            this.button5.Text = "Kopiraj >";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Odredišni folder: ";
            // 
            // sourceListBox
            // 
            this.sourceListBox.FormattingEnabled = true;
            this.sourceListBox.Location = new System.Drawing.Point(12, 89);
            this.sourceListBox.Name = "sourceListBox";
            this.sourceListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.sourceListBox.Size = new System.Drawing.Size(336, 394);
            this.sourceListBox.TabIndex = 10;
            // 
            // targetListBox
            // 
            this.targetListBox.FormattingEnabled = true;
            this.targetListBox.Location = new System.Drawing.Point(457, 89);
            this.targetListBox.Name = "targetListBox";
            this.targetListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.targetListBox.Size = new System.Drawing.Size(322, 394);
            this.targetListBox.TabIndex = 11;
            this.targetListBox.SelectedIndexChanged += new System.EventHandler(this.targetListBox_SelectedIndexChanged);
            // 
            // currentFile
            // 
            this.currentFile.Location = new System.Drawing.Point(157, 42);
            this.currentFile.Name = "currentFile";
            this.currentFile.Size = new System.Drawing.Size(609, 20);
            this.currentFile.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Datoteka koja se obrađuje: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Polazni folder: ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 32);
            this.button3.TabIndex = 21;
            this.button3.Text = "< Kopiraj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(354, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 32);
            this.button4.TabIndex = 22;
            this.button4.Text = "< Obriši";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(354, 208);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 32);
            this.button6.TabIndex = 23;
            this.button6.Text = "Premjesti >";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Prozor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 525);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentFile);
            this.Controls.Add(this.targetListBox);
            this.Controls.Add(this.sourceListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.targetFolder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sourceFolder);
            this.Controls.Add(this.button1);
            this.Name = "Prozor1";
            this.Text = "Aplikacija - premještanje i kopiranje datoteka";
            this.Load += new System.EventHandler(this.Prozor1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void targetListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sourceFolder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox targetFolder;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox sourceListBox;
        private System.Windows.Forms.ListBox targetListBox;
        private System.Windows.Forms.TextBox currentFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
    }
}

