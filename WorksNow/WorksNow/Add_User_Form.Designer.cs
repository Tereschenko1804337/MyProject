namespace WorksNow
{
    partial class Add_User_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_User_Form));
            this.Save_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.TurnName_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.MiddleName_textBox = new System.Windows.Forms.TextBox();
            this.Age_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.White;
            this.Save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_button.Location = new System.Drawing.Point(27, 137);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.TabIndex = 0;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.White;
            this.Exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit_button.Location = new System.Drawing.Point(225, 137);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 23);
            this.Exit_button.TabIndex = 1;
            this.Exit_button.Text = "Отмена";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // TurnName_textBox
            // 
            this.TurnName_textBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TurnName_textBox.Location = new System.Drawing.Point(86, 24);
            this.TurnName_textBox.Name = "TurnName_textBox";
            this.TurnName_textBox.Size = new System.Drawing.Size(214, 20);
            this.TurnName_textBox.TabIndex = 2;
            this.TurnName_textBox.Tag = "";
            // 
            // Name_textBox
            // 
            this.Name_textBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Name_textBox.Location = new System.Drawing.Point(86, 50);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(214, 20);
            this.Name_textBox.TabIndex = 3;
            // 
            // MiddleName_textBox
            // 
            this.MiddleName_textBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MiddleName_textBox.Location = new System.Drawing.Point(86, 78);
            this.MiddleName_textBox.Name = "MiddleName_textBox";
            this.MiddleName_textBox.Size = new System.Drawing.Size(214, 20);
            this.MiddleName_textBox.TabIndex = 4;
            // 
            // Age_textBox
            // 
            this.Age_textBox.Location = new System.Drawing.Point(86, 107);
            this.Age_textBox.Name = "Age_textBox";
            this.Age_textBox.Size = new System.Drawing.Size(32, 20);
            this.Age_textBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Возраст";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 163);
            this.textBox1.TabIndex = 10;
            // 
            // Add_User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(324, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Age_textBox);
            this.Controls.Add(this.MiddleName_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.TurnName_textBox);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_User_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.TextBox TurnName_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox MiddleName_textBox;
        private System.Windows.Forms.TextBox Age_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}