namespace WorksNow
{
    partial class Description_Works
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Description_Works));
            this.write_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancle_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // write_button
            // 
            this.write_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.write_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.write_button.Location = new System.Drawing.Point(12, 213);
            this.write_button.Name = "write_button";
            this.write_button.Size = new System.Drawing.Size(75, 23);
            this.write_button.TabIndex = 1;
            this.write_button.Text = "Сохранить";
            this.write_button.UseVisualStyleBackColor = true;
            this.write_button.Click += new System.EventHandler(this.write_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите описание рабочего дня:";
            // 
            // Cancle_button
            // 
            this.Cancle_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancle_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancle_button.Location = new System.Drawing.Point(308, 213);
            this.Cancle_button.Name = "Cancle_button";
            this.Cancle_button.Size = new System.Drawing.Size(75, 23);
            this.Cancle_button.TabIndex = 3;
            this.Cancle_button.Text = "Cancel";
            this.Cancle_button.UseVisualStyleBackColor = true;
            this.Cancle_button.Click += new System.EventHandler(this.Cancle_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(15, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 155);
            this.textBox1.TabIndex = 4;
            // 
            // Description_Works
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 248);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Cancle_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.write_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Description_Works";
            this.Text = "Описание рабочего дня";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Description_Works_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button write_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancle_button;
        private System.Windows.Forms.TextBox textBox1;
    }
}