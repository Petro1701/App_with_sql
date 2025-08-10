using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConsoleApp2
{
    public partial class sign_up: Form
    {
        DataBase database = new DataBase();
        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void sign_up_Load(object sender, EventArgs e)
        {
            pictureBox_eye_open.Visible = false;
            textBox_password.PasswordChar = '*';
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void pictureBox_clear_Click(object sender, EventArgs e)
        {
            textBox_login.Text = "";
            textBox_password.Text = "";
        }

        private void pictureBox_eye_open_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            pictureBox_eye_open.Visible = false;
            pictureBox_eye_closed.Visible = true;

        }

        private void pictureBox_eye_closed_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            pictureBox_eye_closed.Visible = false;
            pictureBox_eye_open.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;
           
            if (CheckUser()==true)
            {
                string query = $"insert into register(login_user,password_user) values ('{loginUser}','{passUser}');";
                MySqlCommand command = new MySqlCommand(query, database.GetConnection());
                database.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!", "Добавлен новый пользователь", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log_in form_log_in = new log_in();
                    this.Hide();
                    form_log_in.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Не получилось создать аккаунт! Возможно вы использовали неприемлимые символы...", "Повторите попытку!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                database.closeConnection();
            }
        

           
        }
        private bool CheckUser()
        {
            var loginUser = textBox_login.Text;
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"select * from register where login_user='{loginUser}';";
            MySqlCommand command = new MySqlCommand(query, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой аккаунт уже существует!", "Повторите попытку!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = textBox_login.Font.Size;
            if (textBox_login.Text.Length >= 10)
            {
                currentSize -= 2;
                if (currentSize < 10)
                    currentSize += 2;
            }else if (textBox_login.Text.Length < 10)
            {
                currentSize += 2;
                if (currentSize >= 11)
                    currentSize -= 2;
            }
             

            textBox_login.Font = new Font(textBox_login.Name, currentSize, textBox_login.Font.Style, textBox_login.Font.Unit);
        }
    }
}
