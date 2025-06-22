using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("data.json");
            var dict = JsonSerializer.Deserialize<Dictionary<string, object>>(json);


            string userName = textBoxLogin.Text; 




            if (dict.ContainsKey(textBoxLogin.Text) && dict[textBoxLogin.Text].ToString() == textBoxPassword.Text)
            {
                Form3 form3 = new Form3(userName);
                form3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("неправильный логин или пароль", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
            }

            Console.WriteLine(json);
        }
    }
}
