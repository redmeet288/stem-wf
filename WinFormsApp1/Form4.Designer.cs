namespace WinFormsApp1
{
    partial class Form4
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonCreateGame = new Button();
            textBoxNameGame = new TextBox();
            textBoxSellTenge = new TextBox();
            textBoxCreateGame = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(0, 165);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(739, 292);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonCreateGame
            // 
            buttonCreateGame.Location = new Point(69, 114);
            buttonCreateGame.Name = "buttonCreateGame";
            buttonCreateGame.Size = new Size(170, 30);
            buttonCreateGame.TabIndex = 1;
            buttonCreateGame.Text = "Добавить игру";
            buttonCreateGame.UseVisualStyleBackColor = true;
            buttonCreateGame.Click += buttonCreateGame_Click;
            // 
            // textBoxNameGame
            // 
            textBoxNameGame.Location = new Point(69, 59);
            textBoxNameGame.Multiline = true;
            textBoxNameGame.Name = "textBoxNameGame";
            textBoxNameGame.Size = new Size(170, 23);
            textBoxNameGame.TabIndex = 2;
            // 
            // textBoxSellTenge
            // 
            textBoxSellTenge.Location = new Point(506, 59);
            textBoxSellTenge.Name = "textBoxSellTenge";
            textBoxSellTenge.Size = new Size(170, 23);
            textBoxSellTenge.TabIndex = 3;
            // 
            // textBoxCreateGame
            // 
            textBoxCreateGame.Location = new Point(290, 59);
            textBoxCreateGame.Name = "textBoxCreateGame";
            textBoxCreateGame.Size = new Size(170, 23);
            textBoxCreateGame.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 41);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 5;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 41);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 6;
            label2.Text = "Создатель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(555, 41);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 7;
            label3.Text = "Цена в тенге";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 476);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCreateGame);
            Controls.Add(textBoxSellTenge);
            Controls.Add(textBoxNameGame);
            Controls.Add(buttonCreateGame);
            Controls.Add(flowLayoutPanel1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonCreateGame;
        private TextBox textBoxNameGame;
        private TextBox textBoxSellTenge;
        private TextBox textBoxCreateGame;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}