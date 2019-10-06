using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ProjectWS2
{
    public partial class Form2 : Form
    {
        // метод перехода в окно авторизации
        void SwitchForm1(){ ActiveForm.Hide(); Form1 form1 = new Form1(); form1.ShowDialog(); Close(); }
        // вывод сообщения
        void Message(string line, string line1, MessageBoxButtons messageBoxButtons,MessageBoxIcon messageBoxIcon)
        {
            MessageBox.Show(line, line1, messageBoxButtons, messageBoxIcon);
        }
        public Form2()
        {
            InitializeComponent();
            // передвижение формы
            #region
            int move = 0, moveX = 0, moveY = 0;
            panel_Top.MouseDown += (s, e) => { move = 1; moveX = e.X; moveY = e.Y; };
            panel_Top.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY); };
            panel_Top.MouseUp += (s, e) => { move = 0; };
            #endregion
            // кнопки и ссылки
            #region Buttons & Linklabel
            // закрыть программу
            btn_Close.Click += (s, e) => { Close(); };
            // вернуться с окна регистрации в окно авторизации, если регистрация прошла успешно
            linkback.Click += (s, e) => { SwitchForm1(); };
            // вернуться с окна регистрации в окно авторизации, если регистрация прошла неудачно
            linkBackError.Click += (s, e) => { SwitchForm1(); };
            // вернуться в окно авторизации с панели регистрации
            btn_back.Click += (s, e) => { SwitchForm1(); };
            // продолжить регистрацию выбрав тип пользователя
            btn_continue.Click += (s, e) => { panel_donereg.BringToFront(); };
            #endregion
        }

        readonly static string MyConn = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        // листаем панели
        void Panel(Panel panel){ panel.BringToFront(); }
        // метод добавления данных
        public bool Insert()
        {
            bool IsSuccess = false;
            try
            {
                using (SqlConnection sql = new SqlConnection(MyConn))
                {
                    sql.Open();
                    string query = $"insert into tbl_TypeUser ([Name], [Surname], [E-mail], [Gender], [Username], [Passsword], [ConfirmPassword]) VALUES" +
                        $" ('{txtName}', '{txtSurname.Text}', '{cmb_gender.Text}', '{txtEmail.Text}', '{txt_username.Text}', '{txtpassword.Text}', '{txtconfirmpassword.Text}')";
                    SqlCommand command = new SqlCommand(query, sql);
                    int row = command.ExecuteNonQuery();
                    IsSuccess = row > 0 ? true : false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source); }
            return IsSuccess;
        }
        // кнопка добавить!
        void Btn_add_Click(object sender, EventArgs e)
        {
            bool success = Insert();
            Panel(success ? panelmessdone : panelmesserror);
        }
    }
}
