using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SocketIOSharp.Common;
using SocketIOSharp.Server;
using System;
using System.Data.Entity;
using System.Windows.Forms;


namespace MercuryClient
{
    public partial class Server : Form
    {
        private SocketIOServer server;
        private bool startSetver = false;
        private string connectionString = "DATA SOURCE=localhost:1521/xepdb1;PASSWORD=vetis;USER ID=VETIS";
        private DataBase dataBase;
        public Server()
        {
            InitializeComponent();
            labelStatus.Text = "Сервер отключен";
            textBoxMessage.ReadOnly = true;
            dataBase = new DataBase(connectionString);
        }

        private void Server_Load(object sender, EventArgs e)
        {
            
        }
        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (startSetver == true)
            {
                server.Stop();
            }
        }

        private void button_Open_Click(object sender, EventArgs e)
        {

                server = new SocketIOServer(new SocketIOServerOption(9005));

                textBoxMessage.AppendText("Прослушивание порта " + server.Option.Port + Environment.NewLine);
                textBoxMessage.AppendText("----------------------------" + Environment.NewLine);
                server.OnConnection((socket) =>
                {
                    textBoxMessage.AppendText($"{DateTime.Now:HH:mm} Клиент подключился!" + Environment.NewLine);
                    textBoxMessage.AppendText("----------------------------" + Environment.NewLine);
                    socket.On("accepted", (data) =>
                    {
                        textBoxMessage.AppendText($"{DateTime.Now:HH:mm} Товар принят -> ");
                        foreach (JToken token in data)
                        {
                            textBoxMessage.AppendText(token + " ");
                        }

                        textBoxMessage.AppendText(Environment.NewLine);
                        textBoxMessage.AppendText("----------------------------" + Environment.NewLine);
                    });

                    socket.On(SocketIOEvent.DISCONNECT, () =>
                    {
                        textBoxMessage.AppendText($"{DateTime.Now:HH:mm} Клиент отключился!" + Environment.NewLine);
                    });

                    socket.On("getVSD", () =>
                    {
                        try
                        {
                            dataBase.OpenConnection();
                            var VSDs = dataBase.FetchVSDs();
                            string jsonData = JsonConvert.SerializeObject(VSDs, Formatting.Indented);
                            socket.Emit("echo", jsonData);
                            dataBase.CloseConnection();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    });


                });
                server.Start();
                startSetver = true;
                labelStatus.Text = "Сервер включен";
        }
  

        private void button_Close_Click(object sender, EventArgs e)
        {
            if (startSetver == true)
            {
                server.Stop();
                labelStatus.Text = "Сервер отключен";
            }
        }

        private void labelStatus_TextChanged(object sender, EventArgs e)
        {
            if (labelStatus.Text == "Сервер отключен")
            {
                labelStatus.ForeColor = System.Drawing.Color.Red;

            } else labelStatus.ForeColor= System.Drawing.Color.Green;

        }
    }
}
