namespace SalesSystem
{
    partial class User_managment
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
            this.usersGrid = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessPermissions = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // usersGrid
            // 
            this.usersGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.usersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.accountType,
            this.Password,
            this.AccessPermissions});
            this.usersGrid.Location = new System.Drawing.Point(1, -1);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.RowHeadersWidth = 62;
            this.usersGrid.RowTemplate.Height = 29;
            this.usersGrid.Size = new System.Drawing.Size(856, 363);
            this.usersGrid.TabIndex = 2;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.HeaderText = "اسم المستخدم";
            this.username.MinimumWidth = 8;
            this.username.Name = "username";
            // 
            // accountType
            // 
            this.accountType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountType.HeaderText = "نوع الحساب";
            this.accountType.MinimumWidth = 8;
            this.accountType.Name = "accountType";
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.HeaderText = "الرمز";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            // 
            // AccessPermissions
            // 
            this.AccessPermissions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccessPermissions.HeaderText = "صلاحيات الوصول";
            this.AccessPermissions.MinimumWidth = 8;
            this.AccessPermissions.Name = "AccessPermissions";
            // 
            // User_managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(856, 582);
            this.Controls.Add(this.usersGrid);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "User_managment";
            this.Text = "ادارة مستخدمين";
            this.Resize += new System.EventHandler(this.User_managment_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AccessPermissions;
    }
}