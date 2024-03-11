namespace WindowsFormsApp1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_rating = new System.Windows.Forms.TextBox();
            this.textBox_fullname = new System.Windows.Forms.TextBox();
            this.textBox_interest = new System.Windows.Forms.TextBox();
            this.button_frissit = new System.Windows.Forms.Button();
            this.button_modosit = new System.Windows.Forms.Button();
            this.button_uj = new System.Windows.Forms.Button();
            this.button_torol = new System.Windows.Forms.Button();
            this.textBox_entry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 290);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fullname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Interest";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(310, 13);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(136, 20);
            this.textBox_id.TabIndex = 6;
            // 
            // textBox_rating
            // 
            this.textBox_rating.Location = new System.Drawing.Point(310, 91);
            this.textBox_rating.Name = "textBox_rating";
            this.textBox_rating.Size = new System.Drawing.Size(136, 20);
            this.textBox_rating.TabIndex = 8;
            // 
            // textBox_fullname
            // 
            this.textBox_fullname.Location = new System.Drawing.Point(310, 132);
            this.textBox_fullname.Name = "textBox_fullname";
            this.textBox_fullname.Size = new System.Drawing.Size(136, 20);
            this.textBox_fullname.TabIndex = 9;
            // 
            // textBox_interest
            // 
            this.textBox_interest.Location = new System.Drawing.Point(310, 173);
            this.textBox_interest.Name = "textBox_interest";
            this.textBox_interest.Size = new System.Drawing.Size(136, 20);
            this.textBox_interest.TabIndex = 10;
            // 
            // button_frissit
            // 
            this.button_frissit.Location = new System.Drawing.Point(253, 219);
            this.button_frissit.Name = "button_frissit";
            this.button_frissit.Size = new System.Drawing.Size(75, 23);
            this.button_frissit.TabIndex = 11;
            this.button_frissit.Text = "Frissít";
            this.button_frissit.UseVisualStyleBackColor = true;
            this.button_frissit.Click += new System.EventHandler(this.button_frissit_Click);
            // 
            // button_modosit
            // 
            this.button_modosit.Location = new System.Drawing.Point(371, 219);
            this.button_modosit.Name = "button_modosit";
            this.button_modosit.Size = new System.Drawing.Size(75, 23);
            this.button_modosit.TabIndex = 12;
            this.button_modosit.Text = "Módosít";
            this.button_modosit.UseVisualStyleBackColor = true;
            this.button_modosit.Click += new System.EventHandler(this.button_modosit_Click);
            // 
            // button_uj
            // 
            this.button_uj.Location = new System.Drawing.Point(253, 265);
            this.button_uj.Name = "button_uj";
            this.button_uj.Size = new System.Drawing.Size(75, 23);
            this.button_uj.TabIndex = 13;
            this.button_uj.Text = "Új";
            this.button_uj.UseVisualStyleBackColor = true;
            this.button_uj.Click += new System.EventHandler(this.button_uj_Click);
            // 
            // button_torol
            // 
            this.button_torol.Location = new System.Drawing.Point(371, 265);
            this.button_torol.Name = "button_torol";
            this.button_torol.Size = new System.Drawing.Size(75, 23);
            this.button_torol.TabIndex = 14;
            this.button_torol.Text = "Töröl";
            this.button_torol.UseVisualStyleBackColor = true;
            this.button_torol.Click += new System.EventHandler(this.button_torol_Click);
            // 
            // textBox_entry
            // 
            this.textBox_entry.Location = new System.Drawing.Point(310, 50);
            this.textBox_entry.Name = "textBox_entry";
            this.textBox_entry.Size = new System.Drawing.Size(136, 20);
            this.textBox_entry.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 303);
            this.Controls.Add(this.textBox_entry);
            this.Controls.Add(this.button_torol);
            this.Controls.Add(this.button_uj);
            this.Controls.Add(this.button_modosit);
            this.Controls.Add(this.button_frissit);
            this.Controls.Add(this.textBox_interest);
            this.Controls.Add(this.textBox_fullname);
            this.Controls.Add(this.textBox_rating);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_rating;
        private System.Windows.Forms.TextBox textBox_fullname;
        private System.Windows.Forms.TextBox textBox_interest;
        private System.Windows.Forms.Button button_frissit;
        private System.Windows.Forms.Button button_modosit;
        private System.Windows.Forms.Button button_uj;
        private System.Windows.Forms.Button button_torol;
        private System.Windows.Forms.TextBox textBox_entry;
    }
}

