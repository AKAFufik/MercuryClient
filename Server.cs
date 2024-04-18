using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SocketIOSharp.Common;
using SocketIOSharp.Server;
using System;
using System.Windows.Forms;


namespace MercuryClient
{
    public partial class Server : Form
    {
        SocketIOServer server;
        bool startSetver = false;
        public Server()
        {
            InitializeComponent();
            labelStatus.Text = "Сервер отключен";
            textBoxMessage.ReadOnly = true;
        }

        private void Server_Load(object sender, EventArgs e)
        {
            
        }
        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            // TODO: Добавить проверу работу сервера
            if (server.Option.Port == 9005)
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
                        var jsonObject = new
                        {
                            ItemVSDs = new[]
                            {
                                new { Name = "John", Description = "111111111111111111111" },
                                new { Name = "Alice", Description = "22222222222222222222" },
                                new { Name = "Bob", Description = "3333333333333333333333" }
                            }
                        };
                        string jsonData = JsonConvert.SerializeObject(jsonObject);
                        socket.Emit("echo", jsonData);
                    });
                    

                });
                server.Start();
                labelStatus.Text = "Сервер включен";
        }
  

        private void button_Close_Click(object sender, EventArgs e)
        {
           
                server.Stop();
                labelStatus.Text = "Сервер отключен";
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
