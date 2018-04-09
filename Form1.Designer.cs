namespace WindowsFormsApp1
{
    partial class Login
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Log_t = new MetroFramework.Controls.MetroTextBox();
            this.Pass_t = new MetroFramework.Controls.MetroTextBox();
            this.bt_ok = new MetroFramework.Controls.MetroButton();
            this.bt_can = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Enabled = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(243, 126);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(44, 58);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Логин";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Пароль";
            // 
            // Log_t
            // 
            this.Log_t.Location = new System.Drawing.Point(11, 38);
            this.Log_t.Name = "Log_t";
            this.Log_t.Size = new System.Drawing.Size(183, 23);
            this.Log_t.TabIndex = 3;
            // 
            // Pass_t
            // 
            this.Pass_t.Location = new System.Drawing.Point(11, 98);
            this.Pass_t.Name = "Pass_t";
            this.Pass_t.PasswordChar = '*';
            this.Pass_t.Size = new System.Drawing.Size(183, 23);
            this.Pass_t.TabIndex = 4;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(200, 38);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(60, 23);
            this.bt_ok.TabIndex = 5;
            this.bt_ok.Text = "OK";
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_can
            // 
            this.bt_can.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_can.Location = new System.Drawing.Point(200, 98);
            this.bt_can.Name = "bt_can";
            this.bt_can.Size = new System.Drawing.Size(60, 23);
            this.bt_can.TabIndex = 6;
            this.bt_can.Text = "Cancel";
            this.bt_can.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_can;
            this.ClientSize = new System.Drawing.Size(271, 140);
            this.Controls.Add(this.bt_can);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.Pass_t);
            this.Controls.Add(this.Log_t);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox Log_t;
        private MetroFramework.Controls.MetroTextBox Pass_t;
        private MetroFramework.Controls.MetroButton bt_ok;
        private MetroFramework.Controls.MetroButton bt_can;
    }
}

