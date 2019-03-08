namespace Imenik
{
    partial class ImenikForm
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
            this.SelectPhoneBookComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddPhoneBookTextBox = new System.Windows.Forms.TextBox();
            this.ImenikDataGrid = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priimek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HisnaStevilka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonskaStevilka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPhoneBookBtn = new System.Windows.Forms.Button();
            this.PostTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HomeAddressTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ImenikiGroupBox = new System.Windows.Forms.GroupBox();
            this.UrejanjeOsebGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImenikDataGrid)).BeginInit();
            this.ImenikiGroupBox.SuspendLayout();
            this.UrejanjeOsebGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectPhoneBookComboBox
            // 
            this.SelectPhoneBookComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectPhoneBookComboBox.FormattingEnabled = true;
            this.SelectPhoneBookComboBox.Location = new System.Drawing.Point(130, 8);
            this.SelectPhoneBookComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectPhoneBookComboBox.Name = "SelectPhoneBookComboBox";
            this.SelectPhoneBookComboBox.Size = new System.Drawing.Size(246, 30);
            this.SelectPhoneBookComboBox.TabIndex = 0;
            this.SelectPhoneBookComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectPhoneBookComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izberi imenik :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(398, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nov imenik :";
            // 
            // AddPhoneBookTextBox
            // 
            this.AddPhoneBookTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddPhoneBookTextBox.Location = new System.Drawing.Point(511, 10);
            this.AddPhoneBookTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPhoneBookTextBox.Name = "AddPhoneBookTextBox";
            this.AddPhoneBookTextBox.Size = new System.Drawing.Size(219, 28);
            this.AddPhoneBookTextBox.TabIndex = 3;
            // 
            // ImenikDataGrid
            // 
            this.ImenikDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImenikDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Priimek,
            this.HisnaStevilka,
            this.Posta,
            this.Kraj,
            this.TelefonskaStevilka,
            this.eMail});
            this.ImenikDataGrid.Location = new System.Drawing.Point(10, 56);
            this.ImenikDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImenikDataGrid.Name = "ImenikDataGrid";
            this.ImenikDataGrid.RowTemplate.Height = 24;
            this.ImenikDataGrid.Size = new System.Drawing.Size(808, 365);
            this.ImenikDataGrid.TabIndex = 4;
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Priimek
            // 
            this.Priimek.HeaderText = "Priimek";
            this.Priimek.Name = "Priimek";
            this.Priimek.ReadOnly = true;
            // 
            // HisnaStevilka
            // 
            this.HisnaStevilka.HeaderText = "Hišna Številka";
            this.HisnaStevilka.Name = "HisnaStevilka";
            this.HisnaStevilka.ReadOnly = true;
            // 
            // Posta
            // 
            this.Posta.HeaderText = "Pošta";
            this.Posta.Name = "Posta";
            this.Posta.ReadOnly = true;
            // 
            // Kraj
            // 
            this.Kraj.HeaderText = "Kraj";
            this.Kraj.Name = "Kraj";
            this.Kraj.ReadOnly = true;
            // 
            // TelefonskaStevilka
            // 
            this.TelefonskaStevilka.HeaderText = "Telefonska številka";
            this.TelefonskaStevilka.Name = "TelefonskaStevilka";
            this.TelefonskaStevilka.ReadOnly = true;
            // 
            // eMail
            // 
            this.eMail.HeaderText = "eMail";
            this.eMail.Name = "eMail";
            this.eMail.ReadOnly = true;
            // 
            // AddPhoneBookBtn
            // 
            this.AddPhoneBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddPhoneBookBtn.Location = new System.Drawing.Point(734, 10);
            this.AddPhoneBookBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPhoneBookBtn.Name = "AddPhoneBookBtn";
            this.AddPhoneBookBtn.Size = new System.Drawing.Size(75, 31);
            this.AddPhoneBookBtn.TabIndex = 6;
            this.AddPhoneBookBtn.Text = "Dodaj imenik";
            this.AddPhoneBookBtn.UseVisualStyleBackColor = true;
            this.AddPhoneBookBtn.Click += new System.EventHandler(this.AddPhoneBookBtn_Click);
            // 
            // PostTextBox
            // 
            this.PostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PostTextBox.Location = new System.Drawing.Point(427, 39);
            this.PostTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PostTextBox.Name = "PostTextBox";
            this.PostTextBox.Size = new System.Drawing.Size(268, 28);
            this.PostTextBox.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(357, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 24);
            this.label8.TabIndex = 36;
            this.label8.Text = "Pošta :";
            // 
            // HomeAddressTextBox
            // 
            this.HomeAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeAddressTextBox.Location = new System.Drawing.Point(490, 6);
            this.HomeAddressTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomeAddressTextBox.Name = "HomeAddressTextBox";
            this.HomeAddressTextBox.Size = new System.Drawing.Size(204, 28);
            this.HomeAddressTextBox.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(357, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Hišna številka :";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteBtn.Location = new System.Drawing.Point(698, 101);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(109, 43);
            this.DeleteBtn.TabIndex = 33;
            this.DeleteBtn.Text = "Izbriši";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateBtn.Location = new System.Drawing.Point(698, 53);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(109, 43);
            this.UpdateBtn.TabIndex = 32;
            this.UpdateBtn.Text = "Posodobi";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddBtn.Location = new System.Drawing.Point(698, 5);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 43);
            this.AddBtn.TabIndex = 31;
            this.AddBtn.Text = "Dodaj";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eMailTextBox.Location = new System.Drawing.Point(74, 119);
            this.eMailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(268, 28);
            this.eMailTextBox.TabIndex = 30;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(124, 86);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(218, 28);
            this.PhoneNumberTextBox.TabIndex = 29;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CityTextBox.Location = new System.Drawing.Point(412, 72);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(282, 28);
            this.CityTextBox.TabIndex = 28;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameTextBox.Location = new System.Drawing.Point(89, 43);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(253, 28);
            this.SurnameTextBox.TabIndex = 27;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBox.Location = new System.Drawing.Point(60, 11);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(282, 28);
            this.NameTextBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(5, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(5, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tel. številka :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(357, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kraj :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(4, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Priimek :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(4, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ime :";
            // 
            // ImenikiGroupBox
            // 
            this.ImenikiGroupBox.Controls.Add(this.label1);
            this.ImenikiGroupBox.Controls.Add(this.SelectPhoneBookComboBox);
            this.ImenikiGroupBox.Controls.Add(this.label2);
            this.ImenikiGroupBox.Controls.Add(this.AddPhoneBookTextBox);
            this.ImenikiGroupBox.Controls.Add(this.AddPhoneBookBtn);
            this.ImenikiGroupBox.Location = new System.Drawing.Point(10, 11);
            this.ImenikiGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImenikiGroupBox.Name = "ImenikiGroupBox";
            this.ImenikiGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImenikiGroupBox.Size = new System.Drawing.Size(993, 41);
            this.ImenikiGroupBox.TabIndex = 38;
            this.ImenikiGroupBox.TabStop = false;
            this.ImenikiGroupBox.Text = "Imeniki";
            // 
            // UrejanjeOsebGroupBox
            // 
            this.UrejanjeOsebGroupBox.Controls.Add(this.NameTextBox);
            this.UrejanjeOsebGroupBox.Controls.Add(this.label10);
            this.UrejanjeOsebGroupBox.Controls.Add(this.PostTextBox);
            this.UrejanjeOsebGroupBox.Controls.Add(this.label9);
            this.UrejanjeOsebGroupBox.Controls.Add(this.label8);
            this.UrejanjeOsebGroupBox.Controls.Add(this.label3);
            this.UrejanjeOsebGroupBox.Controls.Add(this.HomeAddressTextBox);
            this.UrejanjeOsebGroupBox.Controls.Add(this.label4);
            this.UrejanjeOsebGroupBox.Controls.Add(this.label7);
            this.UrejanjeOsebGroupBox.Controls.Add(this.label5);
            this.UrejanjeOsebGroupBox.Controls.Add(this.DeleteBtn);
            this.UrejanjeOsebGroupBox.Controls.Add(this.SurnameTextBox);
            this.UrejanjeOsebGroupBox.Controls.Add(this.UpdateBtn);
            this.UrejanjeOsebGroupBox.Controls.Add(this.CityTextBox);
            this.UrejanjeOsebGroupBox.Controls.Add(this.AddBtn);
            this.UrejanjeOsebGroupBox.Controls.Add(this.PhoneNumberTextBox);
            this.UrejanjeOsebGroupBox.Controls.Add(this.eMailTextBox);
            this.UrejanjeOsebGroupBox.Location = new System.Drawing.Point(9, 426);
            this.UrejanjeOsebGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UrejanjeOsebGroupBox.Name = "UrejanjeOsebGroupBox";
            this.UrejanjeOsebGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UrejanjeOsebGroupBox.Size = new System.Drawing.Size(809, 151);
            this.UrejanjeOsebGroupBox.TabIndex = 39;
            this.UrejanjeOsebGroupBox.TabStop = false;
            this.UrejanjeOsebGroupBox.Text = "Urejanje Oseb";
            // 
            // ImenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 583);
            this.Controls.Add(this.UrejanjeOsebGroupBox);
            this.Controls.Add(this.ImenikiGroupBox);
            this.Controls.Add(this.ImenikDataGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ImenikForm";
            this.Text = "Imenik";
            ((System.ComponentModel.ISupportInitialize)(this.ImenikDataGrid)).EndInit();
            this.ImenikiGroupBox.ResumeLayout(false);
            this.ImenikiGroupBox.PerformLayout();
            this.UrejanjeOsebGroupBox.ResumeLayout(false);
            this.UrejanjeOsebGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectPhoneBookComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddPhoneBookTextBox;
        private System.Windows.Forms.DataGridView ImenikDataGrid;
        private System.Windows.Forms.Button AddPhoneBookBtn;
        private System.Windows.Forms.TextBox PostTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox HomeAddressTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox ImenikiGroupBox;
        private System.Windows.Forms.GroupBox UrejanjeOsebGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priimek;
        private System.Windows.Forms.DataGridViewTextBoxColumn HisnaStevilka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonskaStevilka;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMail;
    }
}

