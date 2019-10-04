using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int move = 0, moveX = 0, moveY = 0;
            panel_Top.MouseDown += (s, e) => { move = 1; moveX = e.X; moveY = e.Y; };
            panel_Top.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY); };
            panel_Top.MouseUp += (s, e) => { move = 0; };

            btn_close.Click += (s, e) => { Close(); };
            txtPassword.TextChanged += (s, e) => { txtPassword.UseSystemPasswordChar = true; };
            show_password.MouseDown += (s, e) => { txtPassword.UseSystemPasswordChar = false; };
            show_password.MouseUp += (s, e) => { txtPassword.UseSystemPasswordChar = true; };
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                Btn_login_Click(btn_login, null);
        }

        void Btn_login_Click(object sender, EventArgs e)
        {
            // процесс авторизации
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbRBTDataSet.tbl_WS2". При необходимости она может быть перемещена или удалена.
            this.tbl_WS2TableAdapter.Fill(this.dbRBTDataSet.tbl_WS2);

        }
    }
}
