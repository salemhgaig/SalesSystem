﻿namespace SalesSystem
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.الاعداداتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالمستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالمنتجاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةمنتجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفمنتجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالمنتجاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المنتجاتالتالفةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اقفالالحساباتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NewInvoice_Btn = new System.Windows.Forms.Button();
            this.SaveInvoice_Btn = new System.Windows.Forms.Button();
            this.CancelInvoice_Btn = new System.Windows.Forms.Button();
            this.EditInvoice_Btn = new System.Windows.Forms.Button();
            this.PrintInvoice_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Net_textBox = new System.Windows.Forms.TextBox();
            this.Discount_textBox = new System.Windows.Forms.TextBox();
            this.Total_textBox = new System.Windows.Forms.TextBox();
            this.حولالمنظومةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.OperationPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الاعداداتToolStripMenuItem,
            this.ادارةالمستخدمينToolStripMenuItem,
            this.ادارةالمنتجاتToolStripMenuItem,
            this.اقفالالحساباتToolStripMenuItem,
            this.حولالمنظومةToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(923, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // الاعداداتToolStripMenuItem
            // 
            this.الاعداداتToolStripMenuItem.Name = "الاعداداتToolStripMenuItem";
            this.الاعداداتToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.الاعداداتToolStripMenuItem.Text = "الاعدادات";
            // 
            // ادارةالمستخدمينToolStripMenuItem
            // 
            this.ادارةالمستخدمينToolStripMenuItem.Name = "ادارةالمستخدمينToolStripMenuItem";
            this.ادارةالمستخدمينToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.ادارةالمستخدمينToolStripMenuItem.Text = "ادارة المستخدمين";
            // 
            // ادارةالمنتجاتToolStripMenuItem
            // 
            this.ادارةالمنتجاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةمنتجToolStripMenuItem,
            this.حذفمنتجToolStripMenuItem,
            this.تعديلToolStripMenuItem,
            this.عرضالمنتجاتToolStripMenuItem,
            this.المنتجاتالتالفةToolStripMenuItem});
            this.ادارةالمنتجاتToolStripMenuItem.Name = "ادارةالمنتجاتToolStripMenuItem";
            this.ادارةالمنتجاتToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ادارةالمنتجاتToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.ادارةالمنتجاتToolStripMenuItem.Text = "ادارة المنتجات";
            // 
            // اضافةمنتجToolStripMenuItem
            // 
            this.اضافةمنتجToolStripMenuItem.Name = "اضافةمنتجToolStripMenuItem";
            this.اضافةمنتجToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.اضافةمنتجToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.اضافةمنتجToolStripMenuItem.Text = "اضافة منتج";
            // 
            // حذفمنتجToolStripMenuItem
            // 
            this.حذفمنتجToolStripMenuItem.Name = "حذفمنتجToolStripMenuItem";
            this.حذفمنتجToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.حذفمنتجToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.حذفمنتجToolStripMenuItem.Text = "حذف منتج";
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            // 
            // عرضالمنتجاتToolStripMenuItem
            // 
            this.عرضالمنتجاتToolStripMenuItem.Name = "عرضالمنتجاتToolStripMenuItem";
            this.عرضالمنتجاتToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.عرضالمنتجاتToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.عرضالمنتجاتToolStripMenuItem.Text = "عرض المنتجات";
            // 
            // المنتجاتالتالفةToolStripMenuItem
            // 
            this.المنتجاتالتالفةToolStripMenuItem.Name = "المنتجاتالتالفةToolStripMenuItem";
            this.المنتجاتالتالفةToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.المنتجاتالتالفةToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.المنتجاتالتالفةToolStripMenuItem.Text = "المنتجات التالفة";
            // 
            // اقفالالحساباتToolStripMenuItem
            // 
            this.اقفالالحساباتToolStripMenuItem.Name = "اقفالالحساباتToolStripMenuItem";
            this.اقفالالحساباتToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.اقفالالحساباتToolStripMenuItem.Text = "اقفال الحسابات";
            // 
            // OperationPanel
            // 
            this.OperationPanel.Controls.Add(this.NewInvoice_Btn);
            this.OperationPanel.Controls.Add(this.SaveInvoice_Btn);
            this.OperationPanel.Controls.Add(this.CancelInvoice_Btn);
            this.OperationPanel.Controls.Add(this.EditInvoice_Btn);
            this.OperationPanel.Controls.Add(this.PrintInvoice_Btn);
            this.OperationPanel.Location = new System.Drawing.Point(0, 25);
            this.OperationPanel.Name = "OperationPanel";
            this.OperationPanel.Size = new System.Drawing.Size(115, 360);
            this.OperationPanel.TabIndex = 1;
            // 
            // NewInvoice_Btn
            // 
            this.NewInvoice_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NewInvoice_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OperationPanel.SetFlowBreak(this.NewInvoice_Btn, true);
            this.NewInvoice_Btn.Image = global::SalesSystem.Properties.Resources.plus__1_;
            this.NewInvoice_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewInvoice_Btn.Location = new System.Drawing.Point(3, 3);
            this.NewInvoice_Btn.Name = "NewInvoice_Btn";
            this.NewInvoice_Btn.Size = new System.Drawing.Size(107, 64);
            this.NewInvoice_Btn.TabIndex = 0;
            this.NewInvoice_Btn.Text = "فاتورة جديدة";
            this.NewInvoice_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewInvoice_Btn.UseVisualStyleBackColor = false;
            this.NewInvoice_Btn.Click += new System.EventHandler(this.NewInvoice_Btn_Click);
            // 
            // SaveInvoice_Btn
            // 
            this.SaveInvoice_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SaveInvoice_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveInvoice_Btn.Image = global::SalesSystem.Properties.Resources.diskette__1_;
            this.SaveInvoice_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveInvoice_Btn.Location = new System.Drawing.Point(3, 73);
            this.SaveInvoice_Btn.Name = "SaveInvoice_Btn";
            this.SaveInvoice_Btn.Size = new System.Drawing.Size(107, 64);
            this.SaveInvoice_Btn.TabIndex = 1;
            this.SaveInvoice_Btn.Text = "حفظ فاتورة";
            this.SaveInvoice_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveInvoice_Btn.UseVisualStyleBackColor = false;
            // 
            // CancelInvoice_Btn
            // 
            this.CancelInvoice_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelInvoice_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelInvoice_Btn.Image = global::SalesSystem.Properties.Resources.close__1_;
            this.CancelInvoice_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelInvoice_Btn.Location = new System.Drawing.Point(3, 143);
            this.CancelInvoice_Btn.Name = "CancelInvoice_Btn";
            this.CancelInvoice_Btn.Size = new System.Drawing.Size(107, 64);
            this.CancelInvoice_Btn.TabIndex = 3;
            this.CancelInvoice_Btn.Text = "الغاء فاتورة";
            this.CancelInvoice_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelInvoice_Btn.UseVisualStyleBackColor = false;
            // 
            // EditInvoice_Btn
            // 
            this.EditInvoice_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EditInvoice_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditInvoice_Btn.Image = global::SalesSystem.Properties.Resources.edit__1_;
            this.EditInvoice_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditInvoice_Btn.Location = new System.Drawing.Point(3, 213);
            this.EditInvoice_Btn.Name = "EditInvoice_Btn";
            this.EditInvoice_Btn.Size = new System.Drawing.Size(107, 64);
            this.EditInvoice_Btn.TabIndex = 2;
            this.EditInvoice_Btn.Text = "تعديل فاتورة";
            this.EditInvoice_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditInvoice_Btn.UseVisualStyleBackColor = false;
            // 
            // PrintInvoice_Btn
            // 
            this.PrintInvoice_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PrintInvoice_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintInvoice_Btn.Image = global::SalesSystem.Properties.Resources.printer__1_;
            this.PrintInvoice_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintInvoice_Btn.Location = new System.Drawing.Point(3, 283);
            this.PrintInvoice_Btn.Name = "PrintInvoice_Btn";
            this.PrintInvoice_Btn.Size = new System.Drawing.Size(107, 64);
            this.PrintInvoice_Btn.TabIndex = 4;
            this.PrintInvoice_Btn.Text = "طباعة فاتورة";
            this.PrintInvoice_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintInvoice_Btn.UseVisualStyleBackColor = false;
            this.PrintInvoice_Btn.Click += new System.EventHandler(this.PrintInvoice_Btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Net_textBox);
            this.panel1.Controls.Add(this.Discount_textBox);
            this.panel1.Controls.Add(this.Total_textBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 177);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "الصافي";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "الخصم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "الاجمالي";
            // 
            // Net_textBox
            // 
            this.Net_textBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.Net_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Net_textBox.ForeColor = System.Drawing.Color.Yellow;
            this.Net_textBox.Location = new System.Drawing.Point(3, 132);
            this.Net_textBox.Multiline = true;
            this.Net_textBox.Name = "Net_textBox";
            this.Net_textBox.Size = new System.Drawing.Size(78, 36);
            this.Net_textBox.TabIndex = 2;
            // 
            // Discount_textBox
            // 
            this.Discount_textBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.Discount_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount_textBox.ForeColor = System.Drawing.Color.Yellow;
            this.Discount_textBox.Location = new System.Drawing.Point(3, 75);
            this.Discount_textBox.Multiline = true;
            this.Discount_textBox.Name = "Discount_textBox";
            this.Discount_textBox.Size = new System.Drawing.Size(78, 36);
            this.Discount_textBox.TabIndex = 1;
            // 
            // Total_textBox
            // 
            this.Total_textBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.Total_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_textBox.ForeColor = System.Drawing.Color.Yellow;
            this.Total_textBox.Location = new System.Drawing.Point(3, 18);
            this.Total_textBox.Multiline = true;
            this.Total_textBox.Name = "Total_textBox";
            this.Total_textBox.Size = new System.Drawing.Size(78, 36);
            this.Total_textBox.TabIndex = 0;
            this.Total_textBox.Text = "0.0";
            // 
            // حولالمنظومةToolStripMenuItem
            // 
            this.حولالمنظومةToolStripMenuItem.Name = "حولالمنظومةToolStripMenuItem";
            this.حولالمنظومةToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.حولالمنظومةToolStripMenuItem.Text = "حول المنظومة";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(923, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OperationPanel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبيعات";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.OperationPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem الاعداداتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ادارةالمستخدمينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ادارةالمنتجاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةمنتجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفمنتجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالمنتجاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المنتجاتالتالفةToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel OperationPanel;
        private System.Windows.Forms.Button NewInvoice_Btn;
        private System.Windows.Forms.Button SaveInvoice_Btn;
        private System.Windows.Forms.Button EditInvoice_Btn;
        private System.Windows.Forms.Button CancelInvoice_Btn;
        private System.Windows.Forms.Button PrintInvoice_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Total_textBox;
        private System.Windows.Forms.TextBox Net_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem اقفالالحساباتToolStripMenuItem;
        private System.Windows.Forms.TextBox Discount_textBox;
        private System.Windows.Forms.ToolStripMenuItem حولالمنظومةToolStripMenuItem;
    }
}