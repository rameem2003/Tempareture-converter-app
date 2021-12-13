namespace Tempareture_converter_app
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
            this.celcius_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.conv_to_farenheit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.result_fahrenheit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.result_celsius = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fahrenheit_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempareture converter app";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the Celsius value";
            // 
            // celcius_box
            // 
            this.celcius_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celcius_box.Location = new System.Drawing.Point(228, 35);
            this.celcius_box.Name = "celcius_box";
            this.celcius_box.Size = new System.Drawing.Size(209, 29);
            this.celcius_box.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "The result is";
            // 
            // conv_to_farenheit
            // 
            this.conv_to_farenheit.BackColor = System.Drawing.Color.ForestGreen;
            this.conv_to_farenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conv_to_farenheit.ForeColor = System.Drawing.Color.Transparent;
            this.conv_to_farenheit.Location = new System.Drawing.Point(6, 95);
            this.conv_to_farenheit.Name = "conv_to_farenheit";
            this.conv_to_farenheit.Size = new System.Drawing.Size(198, 41);
            this.conv_to_farenheit.TabIndex = 4;
            this.conv_to_farenheit.Text = "Convert to fahrenheit";
            this.conv_to_farenheit.UseVisualStyleBackColor = false;
            this.conv_to_farenheit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(397, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // result_fahrenheit
            // 
            this.result_fahrenheit.AutoSize = true;
            this.result_fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_fahrenheit.Location = new System.Drawing.Point(355, 102);
            this.result_fahrenheit.Name = "result_fahrenheit";
            this.result_fahrenheit.Size = new System.Drawing.Size(40, 24);
            this.result_fahrenheit.TabIndex = 6;
            this.result_fahrenheit.Text = "0 F";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.result_fahrenheit);
            this.groupBox1.Controls.Add(this.celcius_box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.conv_to_farenheit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 158);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Celsius to Fahrenheit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.result_celsius);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.fahrenheit_box);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(507, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 157);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fahrenheit to Celsius";
            // 
            // result_celsius
            // 
            this.result_celsius.AutoSize = true;
            this.result_celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_celsius.Location = new System.Drawing.Point(350, 103);
            this.result_celsius.Name = "result_celsius";
            this.result_celsius.Size = new System.Drawing.Size(41, 24);
            this.result_celsius.TabIndex = 4;
            this.result_celsius.Text = "0 C";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Convert to Celsius";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "The result is:";
            // 
            // fahrenheit_box
            // 
            this.fahrenheit_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrenheit_box.Location = new System.Drawing.Point(284, 35);
            this.fahrenheit_box.Name = "fahrenheit_box";
            this.fahrenheit_box.Size = new System.Drawing.Size(175, 29);
            this.fahrenheit_box.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter the Fahrenheit value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(390, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Designed by mahmood Hassan Rameem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 417);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Tempareture converter app by Mahmodd Hassan Rameem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox celcius_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button conv_to_farenheit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label result_fahrenheit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fahrenheit_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label result_celsius;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}

