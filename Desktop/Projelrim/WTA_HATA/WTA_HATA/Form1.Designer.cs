﻿namespace WTA_HATA
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
            this.btnOrnek1 = new System.Windows.Forms.Button();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.btnOrnek3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOrnek4 = new System.Windows.Forms.Button();
            this.btnOrnek5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Location = new System.Drawing.Point(12, 47);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(126, 23);
            this.btnOrnek1.TabIndex = 0;
            this.btnOrnek1.Text = "Hata Yönetimsiz";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.BtnOrnek1_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Location = new System.Drawing.Point(12, 76);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(126, 23);
            this.btnOrnek2.TabIndex = 0;
            this.btnOrnek2.Text = "Hata Yönetimi";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.BtnOrnek2_Click);
            // 
            // btnOrnek3
            // 
            this.btnOrnek3.Location = new System.Drawing.Point(12, 105);
            this.btnOrnek3.Name = "btnOrnek3";
            this.btnOrnek3.Size = new System.Drawing.Size(126, 23);
            this.btnOrnek3.TabIndex = 0;
            this.btnOrnek3.Text = "Hata Yönetimli Mesaj";
            this.btnOrnek3.UseVisualStyleBackColor = true;
            this.btnOrnek3.Click += new System.EventHandler(this.BtnOrnek3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnOrnek4
            // 
            this.btnOrnek4.Location = new System.Drawing.Point(12, 134);
            this.btnOrnek4.Name = "btnOrnek4";
            this.btnOrnek4.Size = new System.Drawing.Size(126, 23);
            this.btnOrnek4.TabIndex = 0;
            this.btnOrnek4.Text = "Hata Yönetimli mesaj";
            this.btnOrnek4.UseVisualStyleBackColor = true;
            this.btnOrnek4.Click += new System.EventHandler(this.BtnOrnek4_Click);
            // 
            // btnOrnek5
            // 
            this.btnOrnek5.Location = new System.Drawing.Point(12, 163);
            this.btnOrnek5.Name = "btnOrnek5";
            this.btnOrnek5.Size = new System.Drawing.Size(126, 23);
            this.btnOrnek5.TabIndex = 0;
            this.btnOrnek5.Text = "Hata Yönetimli Finaly";
            this.btnOrnek5.UseVisualStyleBackColor = true;
            this.btnOrnek5.Click += new System.EventHandler(this.BtnOrnek5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 244);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOrnek5);
            this.Controls.Add(this.btnOrnek4);
            this.Controls.Add(this.btnOrnek3);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnOrnek1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.Button btnOrnek3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOrnek4;
        private System.Windows.Forms.Button btnOrnek5;
    }
}

