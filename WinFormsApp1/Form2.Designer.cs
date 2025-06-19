namespace WinFormsApp1
{
    partial class Form2
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            buttonRegister2 = new Button();
            label4 = new Label();
            textBoxReapetPassword = new TextBox();
            buttonReturnLogin = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(387, 49);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 13;
            label3.Text = "Stem";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(383, 183);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 12;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(385, 117);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 11;
            label1.Text = "Логин";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxPassword.Location = new Point(277, 207);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(263, 23);
            textBoxPassword.TabIndex = 10;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxLogin.Location = new Point(277, 147);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(263, 23);
            textBoxLogin.TabIndex = 9;
            // 
            // buttonRegister2
            // 
            buttonRegister2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonRegister2.Location = new Point(256, 327);
            buttonRegister2.Name = "buttonRegister2";
            buttonRegister2.Size = new Size(310, 27);
            buttonRegister2.TabIndex = 8;
            buttonRegister2.Text = "Регистрация и вход";
            buttonRegister2.UseVisualStyleBackColor = true;
            buttonRegister2.Click += buttonRegister2_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(359, 247);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 15;
            label4.Text = "Повтори пароль";
            label4.Click += label4_Click;
            // 
            // textBoxReapetPassword
            // 
            textBoxReapetPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxReapetPassword.Location = new Point(277, 271);
            textBoxReapetPassword.Name = "textBoxReapetPassword";
            textBoxReapetPassword.Size = new Size(263, 23);
            textBoxReapetPassword.TabIndex = 14;
            // 
            // buttonReturnLogin
            // 
            buttonReturnLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonReturnLogin.Location = new Point(256, 382);
            buttonReturnLogin.Name = "buttonReturnLogin";
            buttonReturnLogin.Size = new Size(310, 27);
            buttonReturnLogin.TabIndex = 16;
            buttonReturnLogin.Text = "Вернуться к входу";
            buttonReturnLogin.UseVisualStyleBackColor = true;
            buttonReturnLogin.Click += buttonReturnLogin_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(buttonReturnLogin);
            Controls.Add(label4);
            Controls.Add(textBoxReapetPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(buttonRegister2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Button buttonRegister2;
        private Label label4;
        private TextBox textBoxReapetPassword;
        private Button buttonReturnLogin;
    }
}