namespace SalesSystem
{
    partial class Fmimpure
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
            this.TX_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NT_Paid = new SalesSystem.Numric_Textbox();
            this.NT_Total = new SalesSystem.Numric_Textbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NT_pure = new SalesSystem.Numric_Textbox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_note = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TX_Name
            // 
            this.TX_Name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_Name.Location = new System.Drawing.Point(298, 9);
            this.TX_Name.Multiline = true;
            this.TX_Name.Name = "TX_Name";
            this.TX_Name.Size = new System.Drawing.Size(207, 39);
            this.TX_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "الاسم:";
            // 
            // NT_Paid
            // 
            this.NT_Paid.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NT_Paid.ForeColor = System.Drawing.Color.Yellow;
            this.NT_Paid.Location = new System.Drawing.Point(1, 76);
            this.NT_Paid.Multiline = true;
            this.NT_Paid.Name = "NT_Paid";
            this.NT_Paid.Size = new System.Drawing.Size(116, 35);
            this.NT_Paid.TabIndex = 2;
            // 
            // NT_Total
            // 
            this.NT_Total.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NT_Total.ForeColor = System.Drawing.Color.Yellow;
            this.NT_Total.Location = new System.Drawing.Point(1, 9);
            this.NT_Total.Multiline = true;
            this.NT_Total.Name = "NT_Total";
            this.NT_Total.Size = new System.Drawing.Size(116, 36);
            this.NT_Total.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "الاجمالي:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "المدفوع:";
            // 
            // NT_pure
            // 
            this.NT_pure.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NT_pure.Enabled = false;
            this.NT_pure.ForeColor = System.Drawing.Color.Yellow;
            this.NT_pure.Location = new System.Drawing.Point(1, 145);
            this.NT_pure.Multiline = true;
            this.NT_pure.Name = "NT_pure";
            this.NT_pure.Size = new System.Drawing.Size(116, 35);
            this.NT_pure.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "الصافي:";
            // 
            // TB_note
            // 
            this.TB_note.Location = new System.Drawing.Point(1, 186);
            this.TB_note.Multiline = true;
            this.TB_note.Name = "TB_note";
            this.TB_note.Size = new System.Drawing.Size(509, 144);
            this.TB_note.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "ملاحظات:";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Blue;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(421, 336);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(155, 58);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "حفظ";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncanel
            // 
            this.btncanel.BackColor = System.Drawing.Color.Red;
            this.btncanel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncanel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncanel.Location = new System.Drawing.Point(12, 331);
            this.btncanel.Name = "btncanel";
            this.btncanel.Size = new System.Drawing.Size(155, 58);
            this.btncanel.TabIndex = 11;
            this.btncanel.Text = "الغاء";
            this.btncanel.UseVisualStyleBackColor = false;
            // 
            // Fmimpure
            // 
            this.AcceptButton = this.btnsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.btncanel;
            this.ClientSize = new System.Drawing.Size(611, 391);
            this.Controls.Add(this.btncanel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_note);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NT_pure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NT_Total);
            this.Controls.Add(this.NT_Paid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TX_Name);
            this.Name = "Fmimpure";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فواتير غير خالص";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TX_Name;
        private System.Windows.Forms.Label label1;
        private Numric_Textbox NT_Paid;
        private Numric_Textbox NT_Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Numric_Textbox NT_pure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_note;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncanel;
    }
}