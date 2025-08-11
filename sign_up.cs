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
            textBox_password.UseSystemPasswordChar = true;
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
            textBox_password.UseSystemPasswordChar = true;
            pictureBox_eye_open.Visible = false;
            pictureBox_eye_closed.Visible = true;

        }

        private void pictureBox_eye_closed_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
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
                    form_log_in.ShowDialog();
                    this.Close();
                    
                    
                }
                else
                {
                    MessageBox.Show("Не получилось создать аккаунт! Возможно вы использовали неприемлимые символы...", "Повторите попытку!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                database.closeConnection();
            }
            log_in login_In= new log_in();
            login_In.Show();
            this.Close();

           
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

        private void Label_back_to_sign_up_MouseMove(object sender, MouseEventArgs e)
        {
            Label_back_to_sign_up.ForeColor = Color.Green;
        }

        private void Label_back_to_sign_up_MouseLeave(object sender, EventArgs e)
        {
            Label_back_to_sign_up.ForeColor = Color.Gray;
        }
        
        private void sign_up_MouseMove(object sender, MouseEventArgs e) //метод передвигает форму в последнюю указаную точку
        {
            if (e.Button == MouseButtons.Left) //метод будет передвигать при условии если нажата ЛКМ
            {
                this.Left += e.X - lastpoint.X; //this.left говорит, на каком расстоянии от левой границы экрана будет форма
                this.Top += e.Y - lastpoint.Y; //this.Top говорит, на каком расстоянии от верхней границы экрана будет форма
            }
        }
        Point lastpoint; //переменная будет в себе хранить координаты мыши, когда она будет на нашем компоненте
        private void sign_up_MouseDown(object sender, MouseEventArgs e) //Когда мышь над нашим компонентом, передаётся координаты указателя мыши в переменную lastpoint
        {
            lastpoint = new Point(e.X,e.Y);
        }

        private void Label_back_to_sign_up_Click(object sender, EventArgs e)
        {
            log_in log_In = new log_in();
            log_In.Show();
            this.Close();

        }

        private void sign_up_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
