using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegister2_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("data.json");

            JsonObject jsonObj = JsonNode.Parse(json).AsObject();
            var dict = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
            if (textBoxPassword.Text == textBoxReapetPassword.Text && dict.ContainsKey(textBoxLogin.Text) == false)
            {
                jsonObj[textBoxLogin.Text] = textBoxPassword.Text;
            }
            else if (textBoxPassword.Text != textBoxReapetPassword.Text)
            {
                MessageBox.Show("пароли не совпадают", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                textBoxReapetPassword.Text = "";
            }
            else
            {
                MessageBox.Show("такой пользователь уже есть", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                textBoxReapetPassword.Text = "";
            }



                File.WriteAllText("data.json", jsonObj.ToJsonString(new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}
