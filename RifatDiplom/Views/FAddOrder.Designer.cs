﻿
namespace RifatDiplom
{
    partial class FAddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.cbDrivers = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LWarning = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.RadioButton();
            this.cbArea = new System.Windows.Forms.RadioButton();
            this.cbRegion = new System.Windows.Forms.RadioButton();
            this.LWarningPoint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Откуда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Куда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(454, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Водитель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "По району";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "По области";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "По городу";
            // 
            // tbFrom
            // 
            this.tbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFrom.Location = new System.Drawing.Point(18, 41);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(233, 30);
            this.tbFrom.TabIndex = 11;
            // 
            // tbTo
            // 
            this.tbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTo.Location = new System.Drawing.Point(18, 111);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(233, 30);
            this.tbTo.TabIndex = 12;
            // 
            // cbDrivers
            // 
            this.cbDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDrivers.FormattingEnabled = true;
            this.cbDrivers.Location = new System.Drawing.Point(384, 47);
            this.cbDrivers.Name = "cbDrivers";
            this.cbDrivers.Size = new System.Drawing.Size(173, 33);
            this.cbDrivers.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(410, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LWarning
            // 
            this.LWarning.AutoSize = true;
            this.LWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LWarning.ForeColor = System.Drawing.Color.Red;
            this.LWarning.Location = new System.Drawing.Point(13, 252);
            this.LWarning.Name = "LWarning";
            this.LWarning.Size = new System.Drawing.Size(321, 25);
            this.LWarning.TabIndex = 15;
            this.LWarning.Text = "Необходимо выбрать один пункт";
            this.LWarning.Visible = false;
            // 
            // cbCity
            // 
            this.cbCity.AutoSize = true;
            this.cbCity.Location = new System.Drawing.Point(147, 294);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(17, 16);
            this.cbCity.TabIndex = 16;
            this.cbCity.TabStop = true;
            this.cbCity.UseVisualStyleBackColor = true;
            // 
            // cbArea
            // 
            this.cbArea.AutoSize = true;
            this.cbArea.Location = new System.Drawing.Point(147, 319);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(17, 16);
            this.cbArea.TabIndex = 17;
            this.cbArea.TabStop = true;
            this.cbArea.UseVisualStyleBackColor = true;
            // 
            // cbRegion
            // 
            this.cbRegion.AutoSize = true;
            this.cbRegion.Location = new System.Drawing.Point(147, 344);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(17, 16);
            this.cbRegion.TabIndex = 18;
            this.cbRegion.TabStop = true;
            this.cbRegion.UseVisualStyleBackColor = true;
            // 
            // LWarningPoint
            // 
            this.LWarningPoint.AutoSize = true;
            this.LWarningPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LWarningPoint.ForeColor = System.Drawing.Color.Red;
            this.LWarningPoint.Location = new System.Drawing.Point(13, 144);
            this.LWarningPoint.Name = "LWarningPoint";
            this.LWarningPoint.Size = new System.Drawing.Size(273, 25);
            this.LWarningPoint.TabIndex = 19;
            this.LWarningPoint.Text = "Необходимо ввести данные";
            this.LWarningPoint.Visible = false;
            // 
            // FAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 376);
            this.Controls.Add(this.LWarningPoint);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.LWarning);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbDrivers);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FAddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить заказ";
            this.Load += new System.EventHandler(this.FAddOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.ComboBox cbDrivers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LWarning;
        private System.Windows.Forms.RadioButton cbCity;
        private System.Windows.Forms.RadioButton cbArea;
        private System.Windows.Forms.RadioButton cbRegion;
        private System.Windows.Forms.Label LWarningPoint;
    }
}