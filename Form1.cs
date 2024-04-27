using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace MercuryClient
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private bool isPanelOpen = false;
        private string connectionString = "DATA SOURCE=localhost:1521/xepdb1;PASSWORD=vetis;USER ID=VETIS";

        
        private DataBase dataBase;
        private OracleDataReader data;
        private DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
            panelMenu.Width = 60;
            groupBox.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataBase = new DataBase(connectionString);
            dataBase.OpenConnection();
            
            // Настройки таймера
            timer = new Timer();
            timer.Interval = 10; // Интервал времени между изменениями ширины панели
            timer.Tick += Timer_Tick;
        }

 
        private void buttonBatch_Click(object sender, EventArgs e)
        {
            try
            {
                labelName.Text = "Журнал Продукции";
                groupBox.Visible =true;
                DeleteButton();

                data = dataBase.Pruduct();
                dataTable = new DataTable();
                dataTable.Load(data);
                dataGridView.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        
        private void buttonVSD_Click(object sender, EventArgs e)
        {
            try
            {
                labelName.Text = "ВСД";
                groupBox.Visible = false;
                DeleteButton();
                data = dataBase.VSD();
                dataTable = new DataTable();
                dataTable.Load(data);
                dataGridView.DataSource = dataTable;
                dataGridView.Columns.Add(new DataGridViewButtonColumn()
                {
                    Name = "Подготовить",
                    Text = "+",
                    UseColumnTextForButtonValue = true
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDamping_Click(object sender, EventArgs e)
        {
            try
            {
                labelName.Text = "Гашение ВСД";
                groupBox.Visible = false;
                DeleteButton();

                data = dataBase.VSDamping();
                dataTable = new DataTable();
                dataTable.Load(data);
                dataGridView.DataSource = dataTable;
                dataGridView.Columns.Add(new DataGridViewButtonColumn()
                {
                    Name = "Гашение",
                    Text = "Погасить",
                    UseColumnTextForButtonValue = true
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
           Server newServer = new Server();
           newServer.Show();
        }

        private void DeleteButton()
        {
            if (dataGridView.Columns.Contains("Подготовить"))
            {
                // Находим индекс столбца "Action" и удаляем его
                int columnIndex = dataGridView.Columns["Подготовить"].Index;
                dataGridView.Columns.RemoveAt(columnIndex);
            }

            if (dataGridView.Columns.Contains("Гашение"))
            {
                // Находим индекс столбца "Action" и удаляем его
                int columnIndex = dataGridView.Columns["Гашение"].Index;
                dataGridView.Columns.RemoveAt(columnIndex);
                
            }

        }
        
      

       private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (!isPanelOpen)
            {
                timer.Start();
            }
            else
            {
                // Закрыть панель
                timer.Start();
            }

            isPanelOpen = !isPanelOpen;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // Очистить фильтр
            dataGridView.DataSource = null;

            // Применить фильтр
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                dataGridView.DataSource = dataTable;
            }
            else
            {
                var filteredDataTable = dataTable.Clone();
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        if (row[column].ToString().Contains(textBoxSearch.Text))
                        {
                            filteredDataTable.Rows.Add(row.ItemArray);
                            break;
                        }
                    }
                }

                dataGridView.DataSource = filteredDataTable;
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isPanelOpen)
            {
                // Плавное открытие
                panelMenu.Width = Math.Min(panelMenu.Width + 10, 180);
                
                if (panelMenu.Width == 180)
                {
                    
                    timer.Stop();
                }
            }
            else
            {
                // Плавное закрытие
                panelMenu.Width = Math.Max(panelMenu.Width - 10, 60);
                if (panelMenu.Width == 0)
                {
                 
                    timer.Stop();
                    panelMenu.Visible = false;
                }
            }
        }
       
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
   
            if (e.Value.ToString() == "2" || e.Value.ToString() == "INCOMING")
            {
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    dataGridView[i, e.RowIndex].Style.BackColor = Color.LightGreen;
                }
            }


            if (e.Value.ToString() == "0" || e.Value.ToString() == "OUTGOING" || e.Value.ToString() == "PRODUCTIVE")
            {
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    dataGridView[i, e.RowIndex].Style.BackColor = Color.LightYellow;
                }
            }
        }
      
        // Закрытия соедининия при закрытии формы
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataBase.CloseConnection();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView.Columns["Подготовить"] != null && e.ColumnIndex == dataGridView.Columns["Подготовить"].Index && e.RowIndex >= 0)
                {
                    var dataFromRow = dataGridView.Rows[e.RowIndex].Cells["UUID"].Value.ToString();
                    var message = dataBase.PrepareIncomingVSD(dataFromRow);
                    MessageBox.Show("Документ подготовлен!");
                }

                if (dataGridView.Columns["Гашение"] != null && e.ColumnIndex == dataGridView.Columns["Гашение"].Index && e.RowIndex >= 0)
                {
                    var dataFromRow = dataGridView.Rows[e.RowIndex].Cells["UUID"].Value.ToString();
                    dataBase.IncomeVSD(dataFromRow);
                    MessageBox.Show("Документ погашен!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 2)
            {
                textBoxFirst.Text = dataGridView.SelectedRows[1].Cells["UUID"].Value.ToString();
                textBoxSecond.Text= dataGridView.SelectedRows[0].Cells["UUID"].Value.ToString();
            }

        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            try
            {
                var message = dataBase.PrepareMergeStockEntry(textBoxFirst.Text, textBoxSecond.Text, "MERGE");
                dataBase.MergeStockKEntry(message);
                MessageBox.Show("Продукты объединены!" + message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAttach_Click(object sender, EventArgs e)
        {
            try
            {
                var message = dataBase.PrepareMergeStockEntry(textBoxFirst.Text, textBoxSecond.Text, "ATTACH");
                dataBase.MergeStockKEntry(message);
                MessageBox.Show("Продукты присоединен!" + message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
