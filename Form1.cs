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
    enum RowState{
        Existed, New, Modified, ModifiedNew, Deleted
    }
    public partial class Form1: Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow; //для хранения индекса строки(RowIndex) при клилке на ячейку, которая находится на этой строке


        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
        private void RefreshDataGrid(DataGridView dwg)//метод будет выводить данные вц таблицу. В параметре передаём ему datagridview
        {
            
                try
                {
                    dataGridView1.Rows.Clear(); //Сначала очищаем строки таблицы
                    string query = "select * from test_db";//Создаём переменную запроса sql на вывод данных из БД.
                    MySqlCommand command = new MySqlCommand(query, dataBase.GetConnection());//Сюда мы переносим нашу переменную. Можем и работать и без переменной, просто sql-запрос и строка подключения. Но с помощью переменных это просто удобнее и компактнее
                   dataBase.openConnection(); // Откроем связь с нашей БД

                    MySqlDataReader reader = command.ExecuteReader(); // Метода ExecuteReader() выполняет sql запрос(select) и возвращает набор строк. Его особенность-он возвращает объект DataReader.
                    while (reader.Read()) //С помощью цикла будет выводиться на DataGridView все строки, которые будут прочитаны ридером(объект reader, созданный на основе класса MySqlReader) из выполненной команды методом(ExecuteReader) объекта command(на основе класса Mysqlcommand),
                                          //в конструктор которого мы передали запрос, находящийся в переменной query и строку подключения, которую передаёт метод, хранящий в себе переменную Mysqlconnection, в которой все данные о нашей подключаемойБД
                    {
                        ReadSingleRow(dwg, reader);   //Вызывает метод ReadSingleRow, который написали ранее для того, чтобы вывести в наш DataGridView все данные из БД. Не забываем, какие параметры должны передать в этот метод (DataGridView dwg, IDataRecord record)
                         //Теперь закроем наш reader
                    }
                    reader.Close();
                dataBase.closeConnection();
                   
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message,"Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        
        //Теперь вызовем все методы, которые мы прописали выше, сразу при загрузке вы методе Form1_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //событие отвечает за отображение данных из таблицы в textBoxы блока "Запись" внизу. Сам метод вызывается при нажатие на ячейку(Cell-ячейка,Click)
        {
             selectedRow = e.RowIndex; //Вызываем переменную, которую мы прописали в самом начале(могли бы её создать только сейчас, без разницы)
            if (e.RowIndex >= 0) //проверка, по которой если индекс строки будет >= 0(помним, что отсчёт у массивов начинается с 0, а не с 1), то мы будем передавать данные из dataGrivView1 в textBoxы ниже
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow]; //Передаём, на какой строке таблицы dataGrivView1 мы сейчас находимся, когда выбрали на одну ячейку(selectedRow).
                textBox_id.Text = row.Cells[0].Value.ToString(); //В текст textBoxа мы присваиваем значение= вызываем объект row(этой переменной у нас хранится вся выбранная кликом строка) класса DataGridViewRow, который имеет метод обращения к ячейке по её индексу. Из этой ячейки функция Value принимает значение этой ячейки(row выступает, как набор ячеек. Вспоминаем, что string-это набор типа данных char), что в ней находится, а ToString() это конвертирует
                textBox_type_of.Text = row.Cells[1].Value.ToString();
                textBox_count.Text = row.Cells[2].Value.ToString(); //Почему ToString()? Потому что свойство Text объекта textBox имеет тип данных string.
                textBox_postavka.Text = row.Cells[3].Value.ToString();
                textBox_price.Text = row.Cells[4].Value.ToString();
            }
            
        }

        private void pictureBox_update_Click(object sender, EventArgs e) //Метод, обновляющий строки таблицы dataGridView1 при клике на картинку
        {
            RefreshDataGrid(dataGridView1); //Метод, обновляющий строки таблицы dataGridView1
        }

        private void button_new_record_Click(object sender, EventArgs e)
        {
            Add_Form add_Form = new Add_Form();
            add_Form.Show();
        }

        private void Search(DataGridView dwg) //метод поиска в textBox
        {
            dwg.Rows.Clear();
            string searchQuery = $"select * from test_db where concat (id,type_of,count_of,postavka,price) like '%{textBox_search.Text}%'";
            MySqlCommand command = new MySqlCommand(searchQuery, dataBase.GetConnection());

            dataBase.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dwg,reader);
            }
            reader.Close();
       
        }

        private void textBox_search_TextChanged(object sender, EventArgs e) //Вызов метода поиска в textBox при изменении текста(не в момент Clickа)
        {
            Search(dataGridView1);
        }

        private void DeleteRow() 
        {
            int index = dataGridView1.CurrentCell.RowIndex; //Создаём переменную(index), которая будет в себе хранить индекс строки(RowIndex), которую передаёт активная на данный момент ячейка(CurrentCell) нашей области данных(datagridview1)
            dataGridView1.Rows[index].Visible = false; //Убираем эту ячейку из зоны видимости
            /*
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty) //В условие мы конвертируем(ToString) значение(Value) первой ячейки(Cell[0]) того номера(который нам передаёт переменная index) строки(Row[]), являющейся объектом области данных(datagridview1)
                                                                                     //string.Empty возвращает пустую строку. Таким образом мы проверяем Row[index] на пустоту
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted; //Присваиваем нашему 6 столбцу(который не видимый был изначально) значение  из enum RowState
                
            }
            */
            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void Update_RowState()
        {
            dataBase.openConnection();
            for(int index=0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;
                if (rowState == RowState.Existed)
                    continue;
                if(rowState==RowState.Deleted)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    string deleteQuery = $"delete from test_db where id={id}";
                    MySqlCommand command = new MySqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись удалена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dataBase.closeConnection();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Update_RowState();
        }
    }
}
