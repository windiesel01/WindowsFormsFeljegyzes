namespace WindowsFormsFeljegyzes
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
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_datum = new System.Windows.Forms.DateTimePicker();
            this.richTextBox_szoveg = new System.Windows.Forms.RichTextBox();
            this.button_open = new System.Windows.Forms.Button();
            this.button1_save = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_nev.Location = new System.Drawing.Point(30, 58);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(145, 31);
            this.textBox_nev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dátum";
            // 
            // dateTimePicker_datum
            // 
            this.dateTimePicker_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_datum.Location = new System.Drawing.Point(30, 120);
            this.dateTimePicker_datum.Name = "dateTimePicker_datum";
            this.dateTimePicker_datum.Size = new System.Drawing.Size(145, 31);
            this.dateTimePicker_datum.TabIndex = 3;
            // 
            // richTextBox_szoveg
            // 
            this.richTextBox_szoveg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox_szoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox_szoveg.Location = new System.Drawing.Point(0, 157);
            this.richTextBox_szoveg.Name = "richTextBox_szoveg";
            this.richTextBox_szoveg.Size = new System.Drawing.Size(800, 293);
            this.richTextBox_szoveg.TabIndex = 4;
            this.richTextBox_szoveg.Text = "";
            // 
            // button_open
            // 
            this.button_open.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_open.Location = new System.Drawing.Point(327, 120);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(138, 31);
            this.button_open.TabIndex = 5;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button1_save
            // 
            this.button1_save.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_save.Location = new System.Drawing.Point(183, 120);
            this.button1_save.Name = "button1_save";
            this.button1_save.Size = new System.Drawing.Size(138, 31);
            this.button1_save.TabIndex = 6;
            this.button1_save.Text = "Save";
            this.button1_save.UseVisualStyleBackColor = true;
            this.button1_save.Click += new System.EventHandler(this.button1_save_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_save);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.richTextBox_szoveg);
            this.Controls.Add(this.dateTimePicker_datum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datum;
        private System.Windows.Forms.RichTextBox richTextBox_szoveg;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button1_save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

