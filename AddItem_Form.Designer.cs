namespace SalesSystem
{
    partial class AddItem_Form
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
            this.textBox_ItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Textbox_PurchaseCost = new SalesSystem.Numric_Textbox();
            this.Textbox_sellingPrice = new SalesSystem.Numric_Textbox();
            this.numericUpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.Textbox_ItemCode = new SalesSystem.Numric_Textbox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ItemName
            // 
            this.textBox_ItemName.Location = new System.Drawing.Point(37, 14);
            this.textBox_ItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_ItemName.Name = "textBox_ItemName";
            this.textBox_ItemName.Size = new System.Drawing.Size(210, 27);
            this.textBox_ItemName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم الصنف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "كود الصنف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "الكمية";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "تكلفة الشراء";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "سعر البيع";
            // 
            // Textbox_PurchaseCost
            // 
            this.Textbox_PurchaseCost.Location = new System.Drawing.Point(147, 222);
            this.Textbox_PurchaseCost.Name = "Textbox_PurchaseCost";
            this.Textbox_PurchaseCost.Size = new System.Drawing.Size(100, 27);
            this.Textbox_PurchaseCost.TabIndex = 10;
            // 
            // Textbox_sellingPrice
            // 
            this.Textbox_sellingPrice.Location = new System.Drawing.Point(147, 281);
            this.Textbox_sellingPrice.Name = "Textbox_sellingPrice";
            this.Textbox_sellingPrice.Size = new System.Drawing.Size(100, 27);
            this.Textbox_sellingPrice.TabIndex = 11;
            // 
            // numericUpDown_Quantity
            // 
            this.numericUpDown_Quantity.Location = new System.Drawing.Point(174, 154);
            this.numericUpDown_Quantity.Name = "numericUpDown_Quantity";
            this.numericUpDown_Quantity.Size = new System.Drawing.Size(72, 27);
            this.numericUpDown_Quantity.TabIndex = 12;
            // 
            // Textbox_ItemCode
            // 
            this.Textbox_ItemCode.Location = new System.Drawing.Point(37, 81);
            this.Textbox_ItemCode.Name = "Textbox_ItemCode";
            this.Textbox_ItemCode.Size = new System.Drawing.Size(210, 27);
            this.Textbox_ItemCode.TabIndex = 13;
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.LimeGreen;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Add.Location = new System.Drawing.Point(242, 333);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 42);
            this.Button_Add.TabIndex = 14;
            this.Button_Add.Text = "اضافة";
            this.Button_Add.UseVisualStyleBackColor = false;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Cancel.Location = new System.Drawing.Point(85, 333);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 42);
            this.Button_Cancel.TabIndex = 19;
            this.Button_Cancel.Text = "الغاء";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            // 
            // AddItem_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 381);
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
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddItem_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة صنف";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Numric_Textbox Textbox_PurchaseCost;
        private Numric_Textbox Textbox_sellingPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown_Quantity;
        private Numric_Textbox Textbox_ItemCode;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Cancel;
    }
}