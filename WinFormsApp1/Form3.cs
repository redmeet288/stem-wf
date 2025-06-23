using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using static WinFormsApp1.Form4;

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
            this.Load += Form3_Load;
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

                users[f].Balans += Convert.ToInt32(textBoxBalans2.Text);
                labelBalans.Text = users[f].Balans.ToString();


                if (!users[f].Game.Contains(newGame))
                {
                    users[f].Game.Add(newGame);
                }


                string updatedJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, updatedJson);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }




        private void Form3_Load(object sender, EventArgs e)
        {

            string pathUsers = "pols.json";
            string pathGames = "game.json";

            if (!File.Exists(pathUsers) || !File.Exists(pathGames))
            {
                MessageBox.Show("Файлы пользователей или игр не найдены.");
                return;
            }


            string jsonUsers = File.ReadAllText(pathUsers);
            var users = JsonSerializer.Deserialize<Dictionary<string, Admin>>(jsonUsers);

            string jsonGames = File.ReadAllText(pathGames);
            var games = JsonSerializer.Deserialize<Dictionary<string, Game>>(jsonGames);

            string currentUser = labelLogin.Text.Trim();

            if (users != null && users.ContainsKey(currentUser))
            {
                Admin admin = users[currentUser];
                flowLayoutPanel1.Controls.Clear();

                foreach (string gameName in admin.Game)
                {
                    
                    if (games.ContainsKey(gameName))
                    {
                        Game game = games[gameName];
                        var card = new UserControl1();
                        card.SetData(gameName, game);
                        flowLayoutPanel1.Controls.Add(card);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден.");
            }
        }

        private void buttonBuyGame_Click(object sender, EventArgs e)
        {
            string pathUsers = "pols.json";
            string pathGames = "game.json";
            string jsonUsers = File.ReadAllText(pathUsers);
            var users = JsonSerializer.Deserialize<Dictionary<string, Admin>>(jsonUsers);
            string jsonGames = File.ReadAllText(pathGames);
            var games = JsonSerializer.Deserialize<Dictionary<string, Game>>(jsonGames);
            string currentUser = labelLogin.Text.Trim();


            if (textBoxGame.Text!="" && games.ContainsKey(textBoxGame.Text) && Convert.ToInt32(labelBalans.Text) > games[textBoxGame.Text].Cost)
            {
                Admin admin = users[currentUser];
                users[currentUser].Game.Add(textBoxGame.Text);
                labelBalans.Text = (Convert.ToInt32(labelBalans.Text) - Convert.ToInt32(games[textBoxGame.Text].Cost)).ToString();
            }
            else
            {
                MessageBox.Show("нету денег или неправильная игра");
            }

            if (users != null && users.ContainsKey(currentUser))
            {
                Admin admin = users[currentUser];
                flowLayoutPanel1.Controls.Clear();

                foreach (string gameName in admin.Game)
                {

                    if (games.ContainsKey(gameName))
                    {
                        Game game = games[gameName];
                        var card = new UserControl1();
                        card.SetData(gameName, game);
                        flowLayoutPanel1.Controls.Add(card);
                    }
                }
            }



            string newJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            string newJson2 = JsonSerializer.Serialize(games, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(pathUsers, newJson);
            File.WriteAllText(pathGames, newJson2);

        }
    }
}