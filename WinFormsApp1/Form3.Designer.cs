namespace WinFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelLogin = new Label();
            labelBalans = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonPlus = new Button();
            textBoxBalans2 = new TextBox();
            button1 = new Button();
            buttonBuyGame = new Button();
            textBoxGame = new TextBox();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(156, 79);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(0, 15);
            labelLogin.TabIndex = 0;
            // 
            // labelBalans
            // 
            labelBalans.AutoSize = true;
            labelBalans.Location = new Point(594, 79);
            labelBalans.Name = "labelBalans";
            labelBalans.Size = new Size(58, 15);
            labelBalans.TabIndex = 1;
            labelBalans.Text = "баланс: 0";
            labelBalans.Click += labelBalans_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(0, 162);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(813, 417);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(679, 115);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(100, 23);
            buttonPlus.TabIndex = 3;
            buttonPlus.Text = "Пополнить";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += button1_Click;
            // 
            // textBoxBalans2
            // 
            textBoxBalans2.Location = new Point(679, 79);
            textBoxBalans2.Name = "textBoxBalans2";
            textBoxBalans2.Size = new Size(100, 23);
            textBoxBalans2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(41, 40);
            button1.Name = "button1";
            button1.Size = new Size(132, 27);
            button1.TabIndex = 5;
            button1.Text = "Магазан";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // buttonBuyGame
            // 
            buttonBuyGame.Location = new Point(332, 115);
            buttonBuyGame.Name = "buttonBuyGame";
            buttonBuyGame.Size = new Size(100, 23);
            buttonBuyGame.TabIndex = 6;
            buttonBuyGame.Text = "Купить игру";
            buttonBuyGame.UseVisualStyleBackColor = true;
            buttonBuyGame.Click += buttonBuyGame_Click;
            // 
            // textBoxGame
            // 
            textBoxGame.Location = new Point(332, 76);
            textBoxGame.Name = "textBoxGame";
            textBoxGame.Size = new Size(100, 23);
            textBoxGame.TabIndex = 7;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 580);
            Controls.Add(textBoxGame);
            Controls.Add(buttonBuyGame);
            Controls.Add(button1);
            Controls.Add(textBoxBalans2);
            Controls.Add(buttonPlus);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(labelBalans);
            Controls.Add(labelLogin);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelBalans;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonPlus;
        private TextBox textBoxBalans2;
        private Button button1;
        private Button buttonBuyGame;
        private TextBox textBoxGame;
    }
}