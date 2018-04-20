namespace WeatherApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cityBox
            // 
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Items.AddRange(new object[] {
            "Винница",
            "Днепр",
            "Донецк",
            "Житомир",
            "Запорожье",
            "Киев",
            "Кропивницкий",
            "Луганск",
            "Луцк",
            "Львов",
            "Николаев",
            "Одесса",
            "Полтава",
            "Ровно",
            "Севастополь",
            "Симферополь",
            "Сумы",
            "Тернополь",
            "Ужгород",
            "Харьков",
            "Херсон",
            "Хмельницкий",
            "Черкассы",
            "Чернигов",
            "Черновцы"});
            this.cityBox.Location = new System.Drawing.Point(12, 29);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(121, 21);
            this.cityBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Город";
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(169, 9);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(194, 41);
            this.findBtn.TabIndex = 2;
            this.findBtn.Text = "Показать погоду!";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBox.Location = new System.Drawing.Point(16, 58);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(369, 554);
            this.outputBox.TabIndex = 3;
            this.outputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 624);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Погодный информер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.TextBox outputBox;
    }
}

