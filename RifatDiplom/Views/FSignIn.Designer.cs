
namespace RifatDiplom
{
    partial class FSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSignIn));
            this.LLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.bsubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LLogin
            // 
            this.LLogin.AutoSize = true;
            this.LLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LLogin.Location = new System.Drawing.Point(66, 57);
            this.LLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(72, 26);
            this.LLogin.TabIndex = 0;
            this.LLogin.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbLogin.Location = new System.Drawing.Point(71, 85);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(251, 32);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbPassword.Location = new System.Drawing.Point(71, 163);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(251, 32);
            this.tbPassword.TabIndex = 3;
            // 
            // bsubmit
            // 
            this.bsubmit.BackColor = System.Drawing.Color.White;
            this.bsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bsubmit.Location = new System.Drawing.Point(125, 215);
            this.bsubmit.Margin = new System.Windows.Forms.Padding(2);
            this.bsubmit.Name = "bsubmit";
            this.bsubmit.Size = new System.Drawing.Size(136, 33);
            this.bsubmit.TabIndex = 5;
            this.bsubmit.Text = "Войти";
            this.bsubmit.UseVisualStyleBackColor = false;
            this.bsubmit.Click += new System.EventHandler(this.bsubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(57, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Не верно введен логин или пароль";
            this.label2.Visible = false;
            // 
            // FSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(384, 267);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bsubmit);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Войти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button bsubmit;
        private System.Windows.Forms.Label label2;
    }
}

