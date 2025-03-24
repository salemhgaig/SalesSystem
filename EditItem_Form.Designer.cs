namespace SalesSystem
{
    partial class EditItem_Form
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
            this.Textbox_ItemCode = new SalesSystem.Numric_Textbox();
            this.numericUpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.Textbox_sellingPrice = new SalesSystem.Numric_Textbox();
            this.Textbox_PurchaseCost = new SalesSystem.Numric_Textbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ItemName = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // Textbox_ItemCode
            // 
            this.Textbox_ItemCode.Location = new System.Drawing.Point(34, 81);
            this.Textbox_ItemCode.Name = "Textbox_ItemCode";
            this.Textbox_ItemCode.Size = new System.Drawing.Size(210, 37);
            this.Textbox_ItemCode.TabIndex = 23;
            // 
            // numericUpDown_Quantity
            // 
            this.numericUpDown_Quantity.Location = new System.Drawing.Point(171, 154);
            this.numericUpDown_Quantity.Name = "numericUpDown_Quantity";
            this.numericUpDown_Quantity.Size = new System.Drawing.Size(72, 37);
            this.numericUpDown_Quantity.TabIndex = 22;
            // 
            // Textbox_sellingPrice
            // 
            this.Textbox_sellingPrice.Location = new System.Drawing.Point(144, 281);
            this.Textbox_sellingPrice.Name = "Textbox_sellingPrice";
            this.Textbox_sellingPrice.Size = new System.Drawing.Size(100, 37);
            this.Textbox_sellingPrice.TabIndex = 21;
            // 
            // Textbox_PurchaseCost
            // 
            this.Textbox_PurchaseCost.Location = new System.Drawing.Point(144, 222);
            this.Textbox_PurchaseCost.Name = "Textbox_PurchaseCost";
            this.Textbox_PurchaseCost.Size = new System.Drawing.Size(100, 37);
            this.Textbox_PurchaseCost.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "سعر البيع";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "تكلفة الشراء";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "الكمية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "كود الصنف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "اسم الصنف";
            // 
            // textBox_ItemName
            // 
            this.textBox_ItemName.Location = new System.Drawing.Point(34, 14);
            this.textBox_ItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_ItemName.Name = "textBox_ItemName";
            this.textBox_ItemName.Size = new System.Drawing.Size(210, 37);
            this.textBox_ItemName.TabIndex = 14;
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.Blue;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Add.Location = new System.Drawing.Point(244, 327);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 42);
            this.Button_Add.TabIndex = 24;
            this.Button_Add.Text = "حفظ";
            this.Button_Add.UseVisualStyleBackColor = false;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Cancel.Location = new System.Drawing.Point(81, 327);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 42);
            this.Button_Cancel.TabIndex = 25;
            this.Button_Cancel.Text = "الغاء";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            // 
            // EditItem_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 381);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Textbox_ItemCode);
            this.Controls.Add(this.numericUpDown_Quantity);
            this.Controls.Add(this.Textbox_sellingPrice);
            this.Controls.Add(this.Textbox_PurchaseCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ItemName);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditItem_Form";
            this.Text = "EditItem_Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Numric_Textbox Textbox_ItemCode;
        private System.Windows.Forms.NumericUpDown numericUpDown_Quantity;
        private Numric_Textbox Textbox_sellingPrice;
        private Numric_Textbox Textbox_PurchaseCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ItemName;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Cancel;
    }
}