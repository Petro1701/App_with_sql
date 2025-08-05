using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace ConsoleApp2
{
    enum RowState{
        Existed, New, Modified, ModifiedNew, Deleted
    }
    public partial class Form1: Form
    {
        DataBase dataBase = new DataBase();
        int SelectRow;
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID"); //первый параметр-имя колонки в MySQL, второй параметр-будем видеть при запуске программы
            dataGridView1.Columns.Add("type_of", "Тип товара"); //При запуске таблицы, мы будем видеть не type_of, а Тип товара. Т.е. второй параметр указываем лишь в том случае, если хотим переименовать колонку
            dataGridView1.Columns.Add("count_of", "Количетство");
            dataGridView1.Columns.Add("postavka", "Поставщик");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }   
        private void ReadSingleRow(DataGridView dwg, IDataRecord record) //IDataRecord предоставляет доступ к значениям столбцов для каждой строки. Используется для DataReader
        {
            dwg.Rows.Add(record.GetInt32(0),record.GetString(1),record.GetInt32(2),record.GetString(3),record.GetInt32(4), RowState.ModifiedNew); //Входные данные мы конвертируем в тот тип данных, который будет читаться в C# компилятором.
//С помощью параметра dwg(назвать можем как угодно, назвали первыми буквами datagridview)
//строку(Row) добавляем(Add) с параметрами, которые конвертируются в нужный нам тип данных.
//record.GetInt(0) - Так как первая строка id будет целочисленная, конвертируем запись с помощью метода GetInt32 в int
 //0 - позиция колонки, которую будем добавлять. 0 это отсчёт первой колонки(помним, что прежде всего это массив данных, а остчёт массивов с 0 индекса).
//-второе поле-Тип товара, имеет текстовый тип данных(GetString) и вторая по счёту(индекса в массиве (1))
//Не забываем, что у нас есть список в enum RowState. Мы также хотим видеть его в строке, поэтому тоже добавляем его, обращаясь к элементу списка энама(name_enum.Element)
        }
        private void RefreshDataGrid(DataGridView dwg)//метод будет выводить данные в таблицу. В параметре передаём ему datagridview
        {
            dataGridView1.Rows.Clear(); //Сначала очищаем строки таблицы
            string query = "select * from test_db";//Запрос sql на вывод данных из БД.
            
        }

      
    }
}
