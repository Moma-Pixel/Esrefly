
namespace Esrefly.Gui.GuiCategory
{
    partial class Frm_AddCat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.cboCatTyp = new System.Windows.Forms.ComboBox();
            this.RTB_Details = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSave_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave_Exit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 70);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RTB_Details);
            this.groupBox1.Controls.Add(this.cboCatTyp);
            this.groupBox1.Controls.Add(this.txtBalance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الصنف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الصنف";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 28);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "نوع الصنف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "التفاصيل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "الرصيد";
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Location = new System.Drawing.Point(50, 335);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(312, 28);
            this.txtBalance.TabIndex = 1;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboCatTyp
            // 
            this.cboCatTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCatTyp.FormattingEnabled = true;
            this.cboCatTyp.Items.AddRange(new object[] {
            "صرف",
            "قبض"});
            this.cboCatTyp.Location = new System.Drawing.Point(50, 120);
            this.cboCatTyp.Name = "cboCatTyp";
            this.cboCatTyp.Size = new System.Drawing.Size(312, 29);
            this.cboCatTyp.TabIndex = 2;
            // 
            // RTB_Details
            // 
            this.RTB_Details.Location = new System.Drawing.Point(50, 201);
            this.RTB_Details.Name = "RTB_Details";
            this.RTB_Details.Size = new System.Drawing.Size(312, 84);
            this.RTB_Details.TabIndex = 3;
            this.RTB_Details.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave.Image = global::Esrefly.Properties.Resources.icons8_save_as_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(226, 10);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 55);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSave_Exit
            // 
            this.btnSave_Exit.BackColor = System.Drawing.Color.White;
            this.btnSave_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSave_Exit.FlatAppearance.BorderSize = 2;
            this.btnSave_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave_Exit.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave_Exit.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave_Exit.Image = global::Esrefly.Properties.Resources.icons8_save_all_48;
            this.btnSave_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave_Exit.Location = new System.Drawing.Point(61, 10);
            this.btnSave_Exit.Margin = new System.Windows.Forms.Padding(10);
            this.btnSave_Exit.Name = "btnSave_Exit";
            this.btnSave_Exit.Size = new System.Drawing.Size(147, 55);
            this.btnSave_Exit.TabIndex = 2;
            this.btnSave_Exit.Text = "حفظ+غلق";
            this.btnSave_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave_Exit.UseVisualStyleBackColor = true;
            this.btnSave_Exit.Click += new System.EventHandler(this.btnSave_Exit_Click);
            // 
            // Frm_AddCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AddCat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "إضافة و تعديل صنف";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox RTB_Details;
        private System.Windows.Forms.ComboBox cboCatTyp;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave_Exit;
        private System.Windows.Forms.Button btnSave;
    }
}