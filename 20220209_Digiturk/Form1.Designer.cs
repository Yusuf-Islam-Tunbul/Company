namespace _20220209_Digiturk
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
            this.employees_combobox = new System.Windows.Forms.ComboBox();
            this.info_listbox = new System.Windows.Forms.ListBox();
            this.total_salary_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employees_combobox
            // 
            this.employees_combobox.FormattingEnabled = true;
            this.employees_combobox.Location = new System.Drawing.Point(12, 12);
            this.employees_combobox.Name = "employees_combobox";
            this.employees_combobox.Size = new System.Drawing.Size(121, 21);
            this.employees_combobox.TabIndex = 0;
            this.employees_combobox.SelectedIndexChanged += new System.EventHandler(this.employees_combobox_SelectedIndexChanged);
            // 
            // info_listbox
            // 
            this.info_listbox.FormattingEnabled = true;
            this.info_listbox.Location = new System.Drawing.Point(12, 52);
            this.info_listbox.Name = "info_listbox";
            this.info_listbox.Size = new System.Drawing.Size(120, 95);
            this.info_listbox.TabIndex = 1;
            // 
            // total_salary_label
            // 
            this.total_salary_label.AutoSize = true;
            this.total_salary_label.Location = new System.Drawing.Point(12, 171);
            this.total_salary_label.Name = "total_salary_label";
            this.total_salary_label.Size = new System.Drawing.Size(35, 13);
            this.total_salary_label.TabIndex = 2;
            this.total_salary_label.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.total_salary_label);
            this.Controls.Add(this.info_listbox);
            this.Controls.Add(this.employees_combobox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox employees_combobox;
        private System.Windows.Forms.ListBox info_listbox;
        private System.Windows.Forms.Label total_salary_label;
    }
}

