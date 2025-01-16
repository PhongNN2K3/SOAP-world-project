namespace WorldSearchClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonGetAllCountries = new Button();
            listBoxResults = new ListBox();
            textBoxCountryCode = new TextBox();
            textBoxCityName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonGetCountryByCode = new Button();
            buttonGetCityByName = new Button();
            buttonGetCitiesByCountry = new Button();
            SuspendLayout();
            // 
            // buttonGetAllCountries
            // 
            buttonGetAllCountries.Location = new Point(524, 58);
            buttonGetAllCountries.Name = "buttonGetAllCountries";
            buttonGetAllCountries.Size = new Size(162, 29);
            buttonGetAllCountries.TabIndex = 0;
            buttonGetAllCountries.Text = "Lấy tất cả quốc gia";
            buttonGetAllCountries.UseVisualStyleBackColor = true;
            buttonGetAllCountries.Click += buttonGetAllCountries_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(53, 137);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(358, 184);
            listBoxResults.TabIndex = 1;
            // 
            // textBoxCountryCode
            // 
            textBoxCountryCode.Location = new Point(53, 59);
            textBoxCountryCode.Name = "textBoxCountryCode";
            textBoxCountryCode.Size = new Size(125, 27);
            textBoxCountryCode.TabIndex = 2;
            // 
            // textBoxCityName
            // 
            textBoxCityName.Location = new Point(259, 59);
            textBoxCityName.Name = "textBoxCityName";
            textBoxCityName.Size = new Size(125, 27);
            textBoxCityName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 27);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 4;
            label1.Text = "Nhập mã quốc gia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 27);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 5;
            label2.Text = "Nhập tên thành phố";
            // 
            // buttonGetCountryByCode
            // 
            buttonGetCountryByCode.Location = new Point(524, 137);
            buttonGetCountryByCode.Name = "buttonGetCountryByCode";
            buttonGetCountryByCode.Size = new Size(176, 29);
            buttonGetCountryByCode.TabIndex = 6;
            buttonGetCountryByCode.Text = "Lấy quốc gia theo mã";
            buttonGetCountryByCode.UseVisualStyleBackColor = true;
            buttonGetCountryByCode.Click += buttonGetCountryByCode_Click;
            // 
            // buttonGetCityByName
            // 
            buttonGetCityByName.Location = new Point(524, 212);
            buttonGetCityByName.Name = "buttonGetCityByName";
            buttonGetCityByName.Size = new Size(173, 29);
            buttonGetCityByName.TabIndex = 7;
            buttonGetCityByName.Text = "Lấy thành phố theo tên";
            buttonGetCityByName.UseVisualStyleBackColor = true;
            buttonGetCityByName.Click += buttonGetCityByName_Click;
            // 
            // buttonGetCitiesByCountry
            // 
            buttonGetCitiesByCountry.Location = new Point(524, 292);
            buttonGetCitiesByCountry.Name = "buttonGetCitiesByCountry";
            buttonGetCitiesByCountry.Size = new Size(243, 29);
            buttonGetCitiesByCountry.TabIndex = 8;
            buttonGetCitiesByCountry.Text = "Lấy thành phố theo mã quốc gia";
            buttonGetCitiesByCountry.UseVisualStyleBackColor = true;
            buttonGetCitiesByCountry.Click += buttonGetCitiesByCountry_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGetCitiesByCountry);
            Controls.Add(buttonGetCityByName);
            Controls.Add(buttonGetCountryByCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCityName);
            Controls.Add(textBoxCountryCode);
            Controls.Add(listBoxResults);
            Controls.Add(buttonGetAllCountries);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGetAllCountries;
        private ListBox listBoxResults;
        private TextBox textBoxCountryCode;
        private TextBox textBoxCityName;
        private Label label1;
        private Label label2;
        private Button buttonGetCountryByCode;
        private Button buttonGetCityByName;
        private Button buttonGetCitiesByCountry;
    }
}
