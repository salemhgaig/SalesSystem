namespace SalesSystem
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
            this.قائمةالديونToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حولالمنظومةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NewInvoice_Btn = new System.Windows.Forms.Button();
            this.SaveInvoice_Btn = new System.Windows.Forms.Button();
            this.CancelInvoice_Btn = new System.Windows.Forms.Button();
            this.EditInvoice_Btn = new System.Windows.Forms.Button();
            this.PrintInvoice_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Net_textBox = new System.Windows.Forms.TextBox();
            this.Discount_textBox = new System.Windows.Forms.TextBox();
            this.Total_textBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.invoiceNumber_TextBox = new SalesSystem.Numric_Textbox();
            this.label6 = new System.Windows.Forms.Label();
            this.ItemQuantity_TextBox = new SalesSystem.Numric_Textbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.QuantityToSell_TextBox = new SalesSystem.Numric_Textbox();
            this.EnterCodeTextBox = new SalesSystem.Numric_Textbox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxSearchProducts = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DG_Salestable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantityBack_TextBox = new SalesSystem.Numric_Textbox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.OperationPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Salestable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الاعداداتToolStripMenuItem,
            this.ادارةالمستخدمينToolStripMenuItem,
            this.ادارةالمنتجاتToolStripMenuItem,
            this.اقفالالحساباتToolStripMenuItem,
            this.قائمةالديونToolStripMenuItem,
            this.حولالمنظومةToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(982, 36);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // الاعداداتToolStripMenuItem
            // 
            this.الاعداداتToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.الاعداداتToolStripMenuItem.Image = global::SalesSystem.Properties.Resources.settings;
            this.الاعداداتToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.الاعداداتToolStripMenuItem.Name = "الاعداداتToolStripMenuItem";
            this.الاعداداتToolStripMenuItem.Size = new System.Drawing.Size(116, 32);
            this.الاعداداتToolStripMenuItem.Text = "الاعدادات";
            // 
            // ادارةالمستخدمينToolStripMenuItem
            // 
            this.ادارةالمستخدمينToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ادارةالمستخدمينToolStripMenuItem.Image = global::SalesSystem.Properties.Resources.profile;
            this.ادارةالمستخدمينToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ادارةالمستخدمينToolStripMenuItem.Name = "ادارةالمستخدمينToolStripMenuItem";
            this.ادارةالمستخدمينToolStripMenuItem.Size = new System.Drawing.Size(175, 32);
            this.ادارةالمستخدمينToolStripMenuItem.Text = "ادارة المستخدمين";
            // 
            // ادارةالمنتجاتToolStripMenuItem
            // 
            this.ادارةالمنتجاتToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ادارةالمنتجاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةمنتجToolStripMenuItem,
            this.حذفمنتجToolStripMenuItem,
            this.تعديلToolStripMenuItem,
            this.عرضالمنتجاتToolStripMenuItem,
            this.المنتجاتالتالفةToolStripMenuItem});
            this.ادارةالمنتجاتToolStripMenuItem.Image = global::SalesSystem.Properties.Resources.box;
            this.ادارةالمنتجاتToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ادارةالمنتجاتToolStripMenuItem.Name = "ادارةالمنتجاتToolStripMenuItem";
            this.ادارةالمنتجاتToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ادارةالمنتجاتToolStripMenuItem.Size = new System.Drawing.Size(150, 32);
            this.ادارةالمنتجاتToolStripMenuItem.Text = "ادارة المنتجات";
            // 
            // اضافةمنتجToolStripMenuItem
            // 
            this.اضافةمنتجToolStripMenuItem.Name = "اضافةمنتجToolStripMenuItem";
            this.اضافةمنتجToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.اضافةمنتجToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.اضافةمنتجToolStripMenuItem.Text = "اضافة منتج";
            // 
            // حذفمنتجToolStripMenuItem
            // 
            this.حذفمنتجToolStripMenuItem.Name = "حذفمنتجToolStripMenuItem";
            this.حذفمنتجToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.حذفمنتجToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.حذفمنتجToolStripMenuItem.Text = "حذف منتج";
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            // 
            // عرضالمنتجاتToolStripMenuItem
            // 
            this.عرضالمنتجاتToolStripMenuItem.Name = "عرضالمنتجاتToolStripMenuItem";
            this.عرضالمنتجاتToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.عرضالمنتجاتToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.عرضالمنتجاتToolStripMenuItem.Text = "عرض المنتجات";
            // 
            // المنتجاتالتالفةToolStripMenuItem
            // 
            this.المنتجاتالتالفةToolStripMenuItem.Name = "المنتجاتالتالفةToolStripMenuItem";
            this.المنتجاتالتالفةToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.المنتجاتالتالفةToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.المنتجاتالتالفةToolStripMenuItem.Text = "المنتجات التالفة";
            // 
            // اقفالالحساباتToolStripMenuItem
            // 
            this.اقفالالحساباتToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.اقفالالحساباتToolStripMenuItem.Image = global::SalesSystem.Properties.Resources.invoice;
            this.اقفالالحساباتToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.اقفالالحساباتToolStripMenuItem.Name = "اقفالالحساباتToolStripMenuItem";
            this.اقفالالحساباتToolStripMenuItem.Size = new System.Drawing.Size(159, 32);
            this.اقفالالحساباتToolStripMenuItem.Text = "اقفال الحسابات";
            // 
            // قائمةالديونToolStripMenuItem
            // 
            this.قائمةالديونToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.قائمةالديونToolStripMenuItem.Image = global::SalesSystem.Properties.Resources.long_term_debt;
            this.قائمةالديونToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.قائمةالديونToolStripMenuItem.Name = "قائمةالديونToolStripMenuItem";
            this.قائمةالديونToolStripMenuItem.Size = new System.Drawing.Size(136, 32);
            this.قائمةالديونToolStripMenuItem.Text = "قائمة الديون";
            // 
            // حولالمنظومةToolStripMenuItem
            // 
            this.حولالمنظومةToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.حولالمنظومةToolStripMenuItem.Image = global::SalesSystem.Properties.Resources.information_button;
            this.حولالمنظومةToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.حولالمنظومةToolStripMenuItem.Name = "حولالمنظومةToolStripMenuItem";
            this.حولالمنظومةToolStripMenuItem.Size = new System.Drawing.Size(153, 32);
            this.حولالمنظومةToolStripMenuItem.Text = "حول المنظومة";
            // 
            // OperationPanel
            // 
            this.OperationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OperationPanel.Controls.Add(this.NewInvoice_Btn);
            this.OperationPanel.Controls.Add(this.SaveInvoice_Btn);
            this.OperationPanel.Controls.Add(this.CancelInvoice_Btn);
            this.OperationPanel.Controls.Add(this.EditInvoice_Btn);
            this.OperationPanel.Controls.Add(this.PrintInvoice_Btn);
            this.OperationPanel.Controls.Add(this.button1);
            this.OperationPanel.Controls.Add(this.button2);
            this.OperationPanel.Location = new System.Drawing.Point(0, 181);
            this.OperationPanel.Name = "OperationPanel";
            this.OperationPanel.Size = new System.Drawing.Size(115, 350);
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
            this.NewInvoice_Btn.Size = new System.Drawing.Size(107, 44);
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
            this.SaveInvoice_Btn.Location = new System.Drawing.Point(3, 53);
            this.SaveInvoice_Btn.Name = "SaveInvoice_Btn";
            this.SaveInvoice_Btn.Size = new System.Drawing.Size(107, 44);
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
            this.CancelInvoice_Btn.Location = new System.Drawing.Point(3, 103);
            this.CancelInvoice_Btn.Name = "CancelInvoice_Btn";
            this.CancelInvoice_Btn.Size = new System.Drawing.Size(107, 44);
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
            this.EditInvoice_Btn.Location = new System.Drawing.Point(3, 153);
            this.EditInvoice_Btn.Name = "EditInvoice_Btn";
            this.EditInvoice_Btn.Size = new System.Drawing.Size(107, 44);
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
            this.PrintInvoice_Btn.Location = new System.Drawing.Point(3, 203);
            this.PrintInvoice_Btn.Name = "PrintInvoice_Btn";
            this.PrintInvoice_Btn.Size = new System.Drawing.Size(107, 44);
            this.PrintInvoice_Btn.TabIndex = 4;
            this.PrintInvoice_Btn.Text = "طباعة فاتورة";
            this.PrintInvoice_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintInvoice_Btn.UseVisualStyleBackColor = false;
            this.PrintInvoice_Btn.Click += new System.EventHandler(this.PrintInvoice_Btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SalesSystem.Properties.Resources.cancel__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "غير خالص";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::SalesSystem.Properties.Resources.atm_card;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "دفع بالبطاقة";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
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
            this.panel1.Location = new System.Drawing.Point(0, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 123);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "الصافي";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "الخصم";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "الاجمالي";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Net_textBox
            // 
            this.Net_textBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.Net_textBox.Enabled = false;
            this.Net_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Net_textBox.ForeColor = System.Drawing.Color.Yellow;
            this.Net_textBox.Location = new System.Drawing.Point(0, 84);
            this.Net_textBox.Multiline = true;
            this.Net_textBox.Name = "Net_textBox";
            this.Net_textBox.ReadOnly = true;
            this.Net_textBox.Size = new System.Drawing.Size(78, 36);
            this.Net_textBox.TabIndex = 2;
            // 
            // Discount_textBox
            // 
            this.Discount_textBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.Discount_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount_textBox.ForeColor = System.Drawing.Color.Yellow;
            this.Discount_textBox.Location = new System.Drawing.Point(0, 42);
            this.Discount_textBox.Multiline = true;
            this.Discount_textBox.Name = "Discount_textBox";
            this.Discount_textBox.Size = new System.Drawing.Size(78, 36);
            this.Discount_textBox.TabIndex = 1;
            this.Discount_textBox.TextChanged += new System.EventHandler(this.Discount_textBox_TextChanged);
            this.Discount_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Discount_textBox_KeyPress);
            // 
            // Total_textBox
            // 
            this.Total_textBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.Total_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_textBox.ForeColor = System.Drawing.Color.Yellow;
            this.Total_textBox.Location = new System.Drawing.Point(0, 0);
            this.Total_textBox.Multiline = true;
            this.Total_textBox.Name = "Total_textBox";
            this.Total_textBox.ReadOnly = true;
            this.Total_textBox.Size = new System.Drawing.Size(78, 36);
            this.Total_textBox.TabIndex = 0;
            this.Total_textBox.Text = "0.0";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.ItemQuantityBack_TextBox);
            this.panel2.Controls.Add(this.invoiceNumber_TextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.ItemQuantity_TextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.QuantityToSell_TextBox);
            this.panel2.Controls.Add(this.EnterCodeTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 148);
            this.panel2.TabIndex = 3;
            // 
            // invoiceNumber_TextBox
            // 
            this.invoiceNumber_TextBox.Location = new System.Drawing.Point(3, 13);
            this.invoiceNumber_TextBox.Name = "invoiceNumber_TextBox";
            this.invoiceNumber_TextBox.Size = new System.Drawing.Size(107, 29);
            this.invoiceNumber_TextBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "رقم الفاتورة";
            // 
            // ItemQuantity_TextBox
            // 
            this.ItemQuantity_TextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.ItemQuantity_TextBox.ForeColor = System.Drawing.Color.Lime;
            this.ItemQuantity_TextBox.Location = new System.Drawing.Point(7, 55);
            this.ItemQuantity_TextBox.Name = "ItemQuantity_TextBox";
            this.ItemQuantity_TextBox.Size = new System.Drawing.Size(68, 29);
            this.ItemQuantity_TextBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "الكمية الموجودة فالمخزن";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(450, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "الكمية";
            // 
            // QuantityToSell_TextBox
            // 
            this.QuantityToSell_TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuantityToSell_TextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.QuantityToSell_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityToSell_TextBox.ForeColor = System.Drawing.Color.Yellow;
            this.QuantityToSell_TextBox.Location = new System.Drawing.Point(371, 43);
            this.QuantityToSell_TextBox.Multiline = true;
            this.QuantityToSell_TextBox.Name = "QuantityToSell_TextBox";
            this.QuantityToSell_TextBox.Size = new System.Drawing.Size(62, 38);
            this.QuantityToSell_TextBox.TabIndex = 15;
            // 
            // EnterCodeTextBox
            // 
            this.EnterCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterCodeTextBox.Location = new System.Drawing.Point(688, 59);
            this.EnterCodeTextBox.Multiline = true;
            this.EnterCodeTextBox.Name = "EnterCodeTextBox";
            this.EnterCodeTextBox.Size = new System.Drawing.Size(158, 29);
            this.EnterCodeTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(865, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "ادخال كود صنف";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ComboBoxSearchProducts);
            this.panel3.Location = new System.Drawing.Point(519, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 51);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "بحث عن صنف";
            // 
            // ComboBoxSearchProducts
            // 
            this.ComboBoxSearchProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSearchProducts.FormattingEnabled = true;
            this.ComboBoxSearchProducts.Location = new System.Drawing.Point(9, 13);
            this.ComboBoxSearchProducts.Name = "ComboBoxSearchProducts";
            this.ComboBoxSearchProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxSearchProducts.Size = new System.Drawing.Size(342, 36);
            this.ComboBoxSearchProducts.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.DG_Salestable);
            this.panel4.Location = new System.Drawing.Point(116, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(866, 350);
            this.panel4.TabIndex = 4;
            // 
            // DG_Salestable
            // 
            this.DG_Salestable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Salestable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DG_Salestable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Salestable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DG_Salestable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DG_Salestable.Location = new System.Drawing.Point(0, 0);
            this.DG_Salestable.Name = "DG_Salestable";
            this.DG_Salestable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DG_Salestable.RowHeadersWidth = 62;
            this.DG_Salestable.RowTemplate.Height = 29;
            this.DG_Salestable.Size = new System.Drawing.Size(866, 347);
            this.DG_Salestable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "الصنف";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "الكمية";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "السعر";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "المجموع";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "الصلاحية";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "وقت التنزيل";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // ItemQuantityBack_TextBox
            // 
            this.ItemQuantityBack_TextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.ItemQuantityBack_TextBox.ForeColor = System.Drawing.Color.Lime;
            this.ItemQuantityBack_TextBox.Location = new System.Drawing.Point(7, 99);
            this.ItemQuantityBack_TextBox.Name = "ItemQuantityBack_TextBox";
            this.ItemQuantityBack_TextBox.Size = new System.Drawing.Size(68, 29);
            this.ItemQuantityBack_TextBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(92, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "الكمية الموجودة بعد البيع";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(350, 95);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDown1.Size = new System.Drawing.Size(103, 29);
            this.numericUpDown1.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(472, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 28);
            this.label10.TabIndex = 24;
            this.label10.Text = "الكمية";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 651);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OperationPanel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبيعات";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.OperationPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Salestable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem قائمةالديونToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoxSearchProducts;
        private Numric_Textbox EnterCodeTextBox;
        private System.Windows.Forms.Label label8;
        private Numric_Textbox QuantityToSell_TextBox;
        private Numric_Textbox invoiceNumber_TextBox;
        private System.Windows.Forms.Label label6;
        private Numric_Textbox ItemQuantity_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DG_Salestable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private Numric_Textbox ItemQuantityBack_TextBox;
    }
}