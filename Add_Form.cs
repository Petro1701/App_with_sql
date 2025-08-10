using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConsoleApp2
{
    public partial class Add_Form: Form
    {
        DataBase database = new DataBase();
        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // Выравниваем по центру add_from
        }

        private void button_add_form_Click(object sender, EventArgs e)
        {

            database.openConnection();
            var type = textBox_add_type_of.Text;
            int.TryParse(textBox_add_count.Text, out int count_of);
            var postavka = textBox_add_postavka.Text;
            int.TryParse(textBox_add_price.Text, out int price);
                var addQuery = $"insert into test_db(type_of, count_of, postavka, price) values ('{type}','{count_of}','{postavka}','{price}');";
                MySqlCommand command = new MySqlCommand(addQuery, database.GetConnection());
               int rowsAffected = command.ExecuteNonQuery();
            if(rowsAffected>0)
                MessageBox.Show("Запись успешно добавлена!", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Запись не сохранилась в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            database.closeConnection();
        }
    }
}
