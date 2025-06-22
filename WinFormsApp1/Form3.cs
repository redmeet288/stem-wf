using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {

        private string f;
        public Form3(string s)
        {
            InitializeComponent();
            f = s;

            string path = "pols.json";
            Dictionary<string, Admin> users = new();

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);

                if (!string.IsNullOrWhiteSpace(json))
                {
                    users = JsonSerializer.Deserialize<Dictionary<string, Admin>>(json) ?? new Dictionary<string, Admin>();
                }
                else
                {
                    users = new Dictionary<string, Admin>();
                }
            }
            else
            {
                users = new Dictionary<string, Admin>();
            }
            Form1 form1 = new Form1();

            string userName = f;

            if (!users.ContainsKey(userName))
            {
                users[userName] = new Admin
                {
                    Balans = 0,
                    Game = new List<string>()
                };
            }
            else
            {

                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    users = JsonSerializer.Deserialize<Dictionary<string, Admin>>(json);
                }

                if (users.ContainsKey(f))
                {
                    Admin found = users[f];
                    labelBalans.Text = found.Balans.ToString();
                    labelLogin.Text = f.ToString();
                }

            }


            string newJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, newJson);

        }
        public class Admin
        {
            public int Balans { get; set; }
            public List<string> Game { get; set; } = new();
        }

        private void labelBalans_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string path = "pols.json";

            string newGame = "CS2";


            Dictionary<string, Admin> users = new();

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                users = JsonSerializer.Deserialize<Dictionary<string, Admin>>(json) ?? new Dictionary<string, Admin>();
            }


            if (users.ContainsKey(f))
            {
                // Пополняем баланс
                users[f].Balans += Convert.ToInt32(textBoxBalans2.Text);
                labelBalans.Text = users[f].Balans.ToString();

                // Добавляем игру, если ещё нет
                if (!users[f].Game.Contains(newGame))
                {
                    users[f].Game.Add(newGame);
                }

                // Сохраняем обратно
                string updatedJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, updatedJson);

            }
        }
    }
}