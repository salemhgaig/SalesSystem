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
            this.label5 = new System.Windows.Forms.Label();
            this.NT_debtValue = new SalesSystem.Numric_Textbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NT_Paid = new SalesSystem.Numric_Textbox();
            this.LB_Comments = new System.Windows.Forms.ListBox();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TX_Name
            // 
            this.TX_Name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_Name.Location = new System.Drawing.Point(158, 1);
            this.TX_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TX_Name.Multiline = true;
            this.TX_Name.Name = "TX_Name";
            this.TX_Name.Size = new System.Drawing.Size(167, 28);
            this.TX_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "الاسم:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "ملاحظات:";
            // 
            // NT_debtValue
            // 
            this.NT_debtValue.Location = new System.Drawing.Point(245, 50);
            this.NT_debtValue.Multiline = true;
            this.NT_debtValue.Name = "NT_debtValue";
            this.NT_debtValue.Size = new System.Drawing.Size(80, 28);
            this.NT_debtValue.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "قيمة الدين";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "المدفوع";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // NT_Paid
            // 
            this.NT_Paid.Location = new System.Drawing.Point(245, 114);
            this.NT_Paid.Multiline = true;
            this.NT_Paid.Name = "NT_Paid";
            this.NT_Paid.Size = new System.Drawing.Size(80, 28);
            this.NT_Paid.TabIndex = 14;
            // 
            // LB_Comments
            // 
            this.LB_Comments.FormattingEnabled = true;
            this.LB_Comments.Location = new System.Drawing.Point(39, 176);
            this.LB_Comments.Name = "LB_Comments";
            this.LB_Comments.Size = new System.Drawing.Size(286, 134);
            this.LB_Comments.TabIndex = 16;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Cancel.Location = new System.Drawing.Point(39, 340);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(104, 42);
            this.Button_Cancel.TabIndex = 27;
            this.Button_Cancel.Text = "الغاء";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.Blue;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Add.Location = new System.Drawing.Point(253, 340);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(104, 42);
            this.Button_Add.TabIndex = 26;
            this.Button_Add.Text = "حفظ";
            this.Button_Add.UseVisualStyleBackColor = false;
            // 
            // Fmimpure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(400, 412);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.LB_Comments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NT_Paid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NT_debtValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TX_Name);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Fmimpure";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فواتير غير خالص";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TX_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Numric_Textbox NT_debtValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Numric_Textbox NT_Paid;
        private System.Windows.Forms.ListBox LB_Comments;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Add;
    }
}