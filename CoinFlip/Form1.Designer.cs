
namespace CoinFlip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flipsTxt = new System.Windows.Forms.TextBox();
            this.headsTxt = new System.Windows.Forms.TextBox();
            this.tailsTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpTxt = new System.Windows.Forms.TextBox();
            this.hpTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtTxt = new System.Windows.Forms.TextBox();
            this.rhTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flipsTxt
            // 
            this.flipsTxt.Location = new System.Drawing.Point(111, 6);
            this.flipsTxt.Name = "flipsTxt";
            this.flipsTxt.Size = new System.Drawing.Size(100, 23);
            this.flipsTxt.TabIndex = 0;
            // 
            // headsTxt
            // 
            this.headsTxt.Location = new System.Drawing.Point(111, 35);
            this.headsTxt.Name = "headsTxt";
            this.headsTxt.ReadOnly = true;
            this.headsTxt.Size = new System.Drawing.Size(100, 23);
            this.headsTxt.TabIndex = 1;
            // 
            // tailsTxt
            // 
            this.tailsTxt.Location = new System.Drawing.Point(111, 64);
            this.tailsTxt.Name = "tailsTxt";
            this.tailsTxt.ReadOnly = true;
            this.tailsTxt.Size = new System.Drawing.Size(100, 23);
            this.tailsTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Flips";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Heads";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Tails";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Flip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(12, 241);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(93, 23);
            this.clrBtn.TabIndex = 7;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(111, 241);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 23);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "% of Tails";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "% of Heads";
            // 
            // tpTxt
            // 
            this.tpTxt.Location = new System.Drawing.Point(111, 122);
            this.tpTxt.Name = "tpTxt";
            this.tpTxt.ReadOnly = true;
            this.tpTxt.Size = new System.Drawing.Size(100, 23);
            this.tpTxt.TabIndex = 10;
            // 
            // hpTxt
            // 
            this.hpTxt.Location = new System.Drawing.Point(111, 93);
            this.hpTxt.Name = "hpTxt";
            this.hpTxt.ReadOnly = true;
            this.hpTxt.Size = new System.Drawing.Size(100, 23);
            this.hpTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Longest Run Tails";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-4, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Longest Run Heads";
            // 
            // rtTxt
            // 
            this.rtTxt.Location = new System.Drawing.Point(111, 183);
            this.rtTxt.Name = "rtTxt";
            this.rtTxt.ReadOnly = true;
            this.rtTxt.Size = new System.Drawing.Size(100, 23);
            this.rtTxt.TabIndex = 14;
            // 
            // rhTxt
            // 
            this.rhTxt.Location = new System.Drawing.Point(111, 154);
            this.rhTxt.Name = "rhTxt";
            this.rhTxt.ReadOnly = true;
            this.rhTxt.Size = new System.Drawing.Size(100, 23);
            this.rhTxt.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(221, 279);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtTxt);
            this.Controls.Add(this.rhTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tpTxt);
            this.Controls.Add(this.hpTxt);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tailsTxt);
            this.Controls.Add(this.headsTxt);
            this.Controls.Add(this.flipsTxt);
            this.Name = "Form1";
            this.Text = "Coin Flipper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox flipsTxt;
        private System.Windows.Forms.TextBox headsTxt;
        private System.Windows.Forms.TextBox tailsTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tpTxt;
        private System.Windows.Forms.TextBox hpTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rtTxt;
        private System.Windows.Forms.TextBox rhTxt;
    }
}

