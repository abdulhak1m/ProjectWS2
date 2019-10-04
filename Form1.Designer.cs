namespace ProjectWS2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.cmbTypeUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.picterBoxLogo = new System.Windows.Forms.PictureBox();
            this.show_password = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.dbRBTDataSet = new ProjectWS2.dbRBTDataSet();
            this.tblWS2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_WS2TableAdapter = new ProjectWS2.dbRBTDataSetTableAdapters.tbl_WS2TableAdapter();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picterBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRBTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWS2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.DarkViolet;
            this.panel_Top.Controls.Add(this.btn_close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(792, 25);
            this.panel_Top.TabIndex = 0;
            // 
            // cmbTypeUser
            // 
            this.cmbTypeUser.DataSource = this.tblWS2BindingSource;
            this.cmbTypeUser.DisplayMember = "Type";
            this.cmbTypeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTypeUser.FormattingEnabled = true;
            this.cmbTypeUser.Location = new System.Drawing.Point(56, 73);
            this.cmbTypeUser.Name = "cmbTypeUser";
            this.cmbTypeUser.Size = new System.Drawing.Size(336, 28);
            this.cmbTypeUser.TabIndex = 1;
            this.cmbTypeUser.ValueMember = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите тип ползователя:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkViolet;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(56, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 5);
            this.panel2.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(56, 183);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(336, 19);
            this.txtUsername.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkViolet;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(56, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 5);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя пользователя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkViolet;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(56, 279);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 5);
            this.panel4.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(56, 257);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(336, 19);
            this.txtPassword.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(154, 324);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(143, 38);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Войти";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // picterBoxLogo
            // 
            this.picterBoxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.picterBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picterBoxLogo.Image")));
            this.picterBoxLogo.Location = new System.Drawing.Point(443, 25);
            this.picterBoxLogo.Name = "picterBoxLogo";
            this.picterBoxLogo.Size = new System.Drawing.Size(349, 410);
            this.picterBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picterBoxLogo.TabIndex = 6;
            this.picterBoxLogo.TabStop = false;
            // 
            // show_password
            // 
            this.show_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_password.Image = ((System.Drawing.Image)(resources.GetObject("show_password.Image")));
            this.show_password.Location = new System.Drawing.Point(398, 257);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(25, 25);
            this.show_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.show_password.TabIndex = 6;
            this.show_password.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(767, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // dbRBTDataSet
            // 
            this.dbRBTDataSet.DataSetName = "dbRBTDataSet";
            this.dbRBTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblWS2BindingSource
            // 
            this.tblWS2BindingSource.DataMember = "tbl_WS2";
            this.tblWS2BindingSource.DataSource = this.dbRBTDataSet;
            // 
            // tbl_WS2TableAdapter
            // 
            this.tbl_WS2TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 435);
            this.Controls.Add(this.picterBoxLogo);
            this.Controls.Add(this.show_password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTypeUser);
            this.Controls.Add(this.panel_Top);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "show";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picterBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRBTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWS2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.ComboBox cmbTypeUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox picterBoxLogo;
        private System.Windows.Forms.PictureBox show_password;
        private System.Windows.Forms.Button btn_close;
        private dbRBTDataSet dbRBTDataSet;
        private System.Windows.Forms.BindingSource tblWS2BindingSource;
        private dbRBTDataSetTableAdapters.tbl_WS2TableAdapter tbl_WS2TableAdapter;
    }
}

