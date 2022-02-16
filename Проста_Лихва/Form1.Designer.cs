
namespace Проста_Лихва
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxNachalnaSuma = new System.Windows.Forms.TextBox();
            this.textBoxSrok = new System.Windows.Forms.TextBox();
            this.labelKrajnaSuma = new System.Windows.Forms.Label();
            this.labelLihwaMesec = new System.Windows.Forms.Label();
            this.textBoxProzent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начална сума:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Срок (в месеци):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Лихвен процент:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Крайна сума:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Месечна лихва:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Натрупване на сумата по месеци:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(52, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Пресметни";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Изчисти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(395, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 260);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxNachalnaSuma
            // 
            this.textBoxNachalnaSuma.Location = new System.Drawing.Point(183, 35);
            this.textBoxNachalnaSuma.Name = "textBoxNachalnaSuma";
            this.textBoxNachalnaSuma.Size = new System.Drawing.Size(138, 22);
            this.textBoxNachalnaSuma.TabIndex = 9;
            // 
            // textBoxSrok
            // 
            this.textBoxSrok.Location = new System.Drawing.Point(183, 69);
            this.textBoxSrok.Name = "textBoxSrok";
            this.textBoxSrok.Size = new System.Drawing.Size(138, 22);
            this.textBoxSrok.TabIndex = 10;
            // 
            // labelKrajnaSuma
            // 
            this.labelKrajnaSuma.AutoSize = true;
            this.labelKrajnaSuma.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKrajnaSuma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKrajnaSuma.Location = new System.Drawing.Point(183, 214);
            this.labelKrajnaSuma.MinimumSize = new System.Drawing.Size(138, 22);
            this.labelKrajnaSuma.Name = "labelKrajnaSuma";
            this.labelKrajnaSuma.Size = new System.Drawing.Size(138, 22);
            this.labelKrajnaSuma.TabIndex = 11;
            // 
            // labelLihwaMesec
            // 
            this.labelLihwaMesec.AutoSize = true;
            this.labelLihwaMesec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLihwaMesec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLihwaMesec.Location = new System.Drawing.Point(183, 248);
            this.labelLihwaMesec.MinimumSize = new System.Drawing.Size(138, 22);
            this.labelLihwaMesec.Name = "labelLihwaMesec";
            this.labelLihwaMesec.Size = new System.Drawing.Size(138, 22);
            this.labelLihwaMesec.TabIndex = 12;
            // 
            // textBoxProzent
            // 
            this.textBoxProzent.Location = new System.Drawing.Point(183, 104);
            this.textBoxProzent.Name = "textBoxProzent";
            this.textBoxProzent.Size = new System.Drawing.Size(138, 22);
            this.textBoxProzent.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxProzent);
            this.Controls.Add(this.labelLihwaMesec);
            this.Controls.Add(this.labelKrajnaSuma);
            this.Controls.Add(this.textBoxSrok);
            this.Controls.Add(this.textBoxNachalnaSuma);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxNachalnaSuma;
        private System.Windows.Forms.TextBox textBoxSrok;
        private System.Windows.Forms.Label labelKrajnaSuma;
        private System.Windows.Forms.Label labelLihwaMesec;
        private System.Windows.Forms.TextBox textBoxProzent;
    }
}

