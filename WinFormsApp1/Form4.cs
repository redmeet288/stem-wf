using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp1.Form3;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }


        public class Game
        {
            public decimal Cost { get; set; }

            public string Opis { get; set; }
        }




        private void Form4_Load(object sender, EventArgs e)
        {
            string path = "game.json";

            string json = File.ReadAllText(path);
            var games = JsonSerializer.Deserialize<Dictionary<string, Game>>(json);

            if (games == null)
            {
                MessageBox.Show("Ошибка чтения файла.");
                return;
            }

            flowLayoutPanel1.Controls.Clear();

            foreach (var game in games)
            {
                var card = new UserControl1();
                card.SetData(game.Key, game.Value);

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void buttonCreateGame_Click(object sender, EventArgs e)
        {
            string path = "game.json";
            Dictionary<string, Game> games = new();

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                games = JsonSerializer.Deserialize<Dictionary<string, Game>>(json) ?? new Dictionary<string, Game>();
            }

            if (!games.ContainsKey(textBoxNameGame.Text) && textBoxCreateGame.Text != "" && textBoxSellTenge.Text != "")
            {
                games[textBoxNameGame.Text] = new Game
                {
                    Cost = Convert.ToInt32(textBoxSellTenge.Text),
                    Opis = textBoxCreateGame.Text
                };
                MessageBox.Show($"Игра добавлена {textBoxNameGame.Text}");
            }
            else
            {
                MessageBox.Show("Такая игра уже есть");
            }

            string newJson = JsonSerializer.Serialize(games, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, newJson);

        }
    }
}
