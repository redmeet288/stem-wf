namespace WinFormsApp1
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            labelCreate = new Label();
            labelCost = new Label();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(78, 16);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 15);
            labelName.TabIndex = 0;
            // 
            // labelCreate
            // 
            labelCreate.AutoSize = true;
            labelCreate.Location = new Point(107, 104);
            labelCreate.Name = "labelCreate";
            labelCreate.Size = new Size(0, 15);
            labelCreate.TabIndex = 1;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(204, 62);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(0, 15);
            labelCost.TabIndex = 3;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelCost);
            Controls.Add(labelCreate);
            Controls.Add(labelName);
            Name = "UserControl1";
            Size = new Size(599, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelCreate;
        private Label labelCost;
    }
}
