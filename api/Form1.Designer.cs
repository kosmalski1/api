namespace api
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
            this.debugTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.USDratetextBox = new System.Windows.Forms.TextBox();
            this.CHFratetextBox = new System.Windows.Forms.TextBox();
            this.EURratetextBox = new System.Windows.Forms.TextBox();
            this.USDratelabel = new System.Windows.Forms.Label();
            this.EURratelabel = new System.Windows.Forms.Label();
            this.CHFratelabel = new System.Windows.Forms.Label();
            this.PLNammounttextbox = new System.Windows.Forms.TextBox();
            this.PLNlabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // debugTextBox
            // 
            this.debugTextBox.Location = new System.Drawing.Point(54, 292);
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.Size = new System.Drawing.Size(398, 146);
            this.debugTextBox.TabIndex = 0;
            this.debugTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "pobierz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // USDratetextBox
            // 
            this.USDratetextBox.Location = new System.Drawing.Point(118, 12);
            this.USDratetextBox.Name = "USDratetextBox";
            this.USDratetextBox.Size = new System.Drawing.Size(100, 23);
            this.USDratetextBox.TabIndex = 2;
            // 
            // CHFratetextBox
            // 
            this.CHFratetextBox.Location = new System.Drawing.Point(118, 70);
            this.CHFratetextBox.Name = "CHFratetextBox";
            this.CHFratetextBox.Size = new System.Drawing.Size(100, 23);
            this.CHFratetextBox.TabIndex = 3;
            // 
            // EURratetextBox
            // 
            this.EURratetextBox.Location = new System.Drawing.Point(118, 41);
            this.EURratetextBox.Name = "EURratetextBox";
            this.EURratetextBox.Size = new System.Drawing.Size(100, 23);
            this.EURratetextBox.TabIndex = 4;
            // 
            // USDratelabel
            // 
            this.USDratelabel.AutoSize = true;
            this.USDratelabel.Location = new System.Drawing.Point(46, 15);
            this.USDratelabel.Name = "USDratelabel";
            this.USDratelabel.Size = new System.Drawing.Size(54, 15);
            this.USDratelabel.TabIndex = 5;
            this.USDratelabel.Text = "kurs USD";
            // 
            // EURratelabel
            // 
            this.EURratelabel.AutoSize = true;
            this.EURratelabel.Location = new System.Drawing.Point(46, 44);
            this.EURratelabel.Name = "EURratelabel";
            this.EURratelabel.Size = new System.Drawing.Size(53, 15);
            this.EURratelabel.TabIndex = 6;
            this.EURratelabel.Text = "kurs EUR";
            // 
            // CHFratelabel
            // 
            this.CHFratelabel.AutoSize = true;
            this.CHFratelabel.Location = new System.Drawing.Point(46, 78);
            this.CHFratelabel.Name = "CHFratelabel";
            this.CHFratelabel.Size = new System.Drawing.Size(55, 15);
            this.CHFratelabel.TabIndex = 7;
            this.CHFratelabel.Text = "kurs CHF";
            // 
            // PLNammounttextbox
            // 
            this.PLNammounttextbox.Location = new System.Drawing.Point(12, 168);
            this.PLNammounttextbox.Name = "PLNammounttextbox";
            this.PLNammounttextbox.Size = new System.Drawing.Size(100, 23);
            this.PLNammounttextbox.TabIndex = 8;
            // 
            // PLNlabel
            // 
            this.PLNlabel.AutoSize = true;
            this.PLNlabel.Location = new System.Drawing.Point(24, 129);
            this.PLNlabel.Name = "PLNlabel";
            this.PLNlabel.Size = new System.Drawing.Size(29, 15);
            this.PLNlabel.TabIndex = 9;
            this.PLNlabel.Text = "PLN";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(139, 159);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 19);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "USD";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.Echange);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(139, 200);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 19);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "EUR";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.Echange);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(139, 247);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 19);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "CHF";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.Echange);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "kwota po wymianie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.PLNlabel);
            this.Controls.Add(this.PLNammounttextbox);
            this.Controls.Add(this.CHFratelabel);
            this.Controls.Add(this.EURratelabel);
            this.Controls.Add(this.USDratelabel);
            this.Controls.Add(this.EURratetextBox);
            this.Controls.Add(this.CHFratetextBox);
            this.Controls.Add(this.USDratetextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.debugTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox debugTextBox;
        private Button button1;
        private TextBox USDratetextBox;
        private TextBox CHFratetextBox;
        private TextBox EURratetextBox;
        private Label USDratelabel;
        private Label EURratelabel;
        private Label CHFratelabel;
        private TextBox PLNammounttextbox;
        private Label PLNlabel;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox textBox1;
        private Label label1;
    }
}