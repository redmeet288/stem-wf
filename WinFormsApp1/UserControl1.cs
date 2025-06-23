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
using static WinFormsApp1.Form4;

namespace WinFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();


        }

        public void SetData(string userName, Game game)
        {
            labelName.Text = $"Игра: {userName}";
            labelCreate.Text = $"Создатель: {game.Opis}";
            labelCost.Text = $"Цена: {game.Cost}";
        }


    }
}
