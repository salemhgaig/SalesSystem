namespace SalesSystem
{
    partial class Fm_Debts
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
            this.btn_cancellation = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numric_Textbox3 = new SalesSystem.Numric_Textbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_Name = new System.Windows.Forms.TextBox();
            this.numric_Textbox2 = new SalesSystem.Numric_Textbox();
            this.numric_Textbox1 = new SalesSystem.Numric_Textbox();
            this.bntsaves = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancellation
            // 
            this.btn_cancellation.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancellation.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancellation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancellation.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancellation.Location = new System.Drawing.Point(61, 13);
            this.btn_cancellation.Name = "btn_cancellation";
            this.btn_cancellation.Size = new System.Drawing.Size(136, 77);
            this.btn_cancellation.TabIndex = 1;
            this.btn_cancellation.Text = "الغاء";
            this.btn_cancellation.UseVisualStyleBackColor = false;
            this.btn_cancellation.Click += new System.EventHandler(this.btn_cancellation_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txName,
            this.invoice_number,
            this.Time,
            this.total,
            this.paid,
            this.rest});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(3, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(887, 256);
            this.dataGridView1.TabIndex = 3;
            // 
            // txName
            // 
            this.txName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txName.HeaderText = "الاسم";
            this.txName.MinimumWidth = 8;
            this.txName.Name = "txName";
            // 
            // invoice_number
            // 
            this.invoice_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.invoice_number.HeaderText = "فاتورة_رقم";
            this.invoice_number.MinimumWidth = 8;
            this.invoice_number.Name = "invoice_number";
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.HeaderText = "التاريخ";
            this.Time.MinimumWidth = 8;
            this.Time.Name = "Time";
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.HeaderText = "الاجمالي";
            this.total.MinimumWidth = 8;
            this.total.Name = "total";
            // 
            // paid
            // 
            this.paid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paid.HeaderText = "المدفوع";
            this.paid.MinimumWidth = 8;
            this.paid.Name = "paid";
            // 
            // rest
            // 
            this.rest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rest.HeaderText = "الباقي";
            this.rest.MinimumWidth = 8;
            this.rest.Name = "rest";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numric_Textbox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tx_Name);
            this.panel1.Controls.Add(this.numric_Textbox2);
            this.panel1.Controls.Add(this.numric_Textbox1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 101);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "الصافي";
            // 
            // numric_Textbox3
            // 
            this.numric_Textbox3.BackColor = System.Drawing.SystemColors.MenuText;
            this.numric_Textbox3.Enabled = false;
            this.numric_Textbox3.Location = new System.Drawing.Point(12, 74);
            this.numric_Textbox3.Name = "numric_Textbox3";
            this.numric_Textbox3.Size = new System.Drawing.Size(100, 27);
            this.numric_Textbox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "الاسم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "المجموع";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "المدفوع";
            // 
            // tx_Name
            // 
            this.tx_Name.Location = new System.Drawing.Point(280, 3);
            this.tx_Name.Name = "tx_Name";
            this.tx_Name.Size = new System.Drawing.Size(185, 27);
            this.tx_Name.TabIndex = 2;
            // 
            // numric_Textbox2
            // 
            this.numric_Textbox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.numric_Textbox2.Location = new System.Drawing.Point(12, 41);
            this.numric_Textbox2.Name = "numric_Textbox2";
            this.numric_Textbox2.Size = new System.Drawing.Size(100, 27);
            this.numric_Textbox2.TabIndex = 1;
            // 
            // numric_Textbox1
            // 
            this.numric_Textbox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.numric_Textbox1.Location = new System.Drawing.Point(12, 3);
            this.numric_Textbox1.Name = "numric_Textbox1";
            this.numric_Textbox1.Size = new System.Drawing.Size(100, 27);
            this.numric_Textbox1.TabIndex = 0;
            // 
            // bntsaves
            // 
            this.bntsaves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntsaves.BackColor = System.Drawing.Color.Blue;
            this.bntsaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntsaves.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntsaves.Location = new System.Drawing.Point(697, 10);
            this.bntsaves.Name = "bntsaves";
            this.bntsaves.Size = new System.Drawing.Size(142, 80);
            this.bntsaves.TabIndex = 0;
            this.bntsaves.Text = "حفظ";
            this.bntsaves.UseVisualStyleBackColor = false;
            this.bntsaves.Click += new System.EventHandler(this.bntsaves_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btn_cancellation);
            this.panel2.Controls.Add(this.bntsaves);
            this.panel2.Location = new System.Drawing.Point(0, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 105);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(0, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(887, 258);
            this.panel3.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(665, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(486, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "اسم المستخدم:";
            // 
            // Fm_Debts
            // 
            this.AcceptButton = this.bntsaves;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btn_cancellation;
            this.ClientSize = new System.Drawing.Size(889, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Fm_Debts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "الديون ";
            this.Load += new System.EventHandler(this.Fm_Debts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cancellation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntsaves;
        private System.Windows.Forms.TextBox tx_Name;
        private Numric_Textbox numric_Textbox2;
        private Numric_Textbox numric_Textbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Numric_Textbox numric_Textbox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn txName;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}