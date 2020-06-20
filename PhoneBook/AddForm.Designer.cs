namespace PhoneBook
{
    partial class AddForm
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
			this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.FlatNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.HouseNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.StreetTextBox = new System.Windows.Forms.TextBox();
			this.PatronymicTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.LastNameTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.AddButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.FlatNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HouseNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// PhoneMaskedTextBox
			// 
			this.PhoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PhoneMaskedTextBox.Location = new System.Drawing.Point(111, 312);
			this.PhoneMaskedTextBox.Mask = "(999) 000-0000";
			this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
			this.PhoneMaskedTextBox.Size = new System.Drawing.Size(188, 26);
			this.PhoneMaskedTextBox.TabIndex = 6;
			// 
			// FlatNumericUpDown
			// 
			this.FlatNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FlatNumericUpDown.Location = new System.Drawing.Point(109, 265);
			this.FlatNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.FlatNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.FlatNumericUpDown.Name = "FlatNumericUpDown";
			this.FlatNumericUpDown.Size = new System.Drawing.Size(190, 26);
			this.FlatNumericUpDown.TabIndex = 5;
			this.FlatNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// HouseNumericUpDown
			// 
			this.HouseNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.HouseNumericUpDown.Location = new System.Drawing.Point(109, 218);
			this.HouseNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.HouseNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.HouseNumericUpDown.Name = "HouseNumericUpDown";
			this.HouseNumericUpDown.Size = new System.Drawing.Size(190, 26);
			this.HouseNumericUpDown.TabIndex = 4;
			this.HouseNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// StreetTextBox
			// 
			this.StreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StreetTextBox.Location = new System.Drawing.Point(109, 174);
			this.StreetTextBox.MaxLength = 40;
			this.StreetTextBox.Name = "StreetTextBox";
			this.StreetTextBox.Size = new System.Drawing.Size(190, 26);
			this.StreetTextBox.TabIndex = 3;
			// 
			// PatronymicTextBox
			// 
			this.PatronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PatronymicTextBox.Location = new System.Drawing.Point(109, 127);
			this.PatronymicTextBox.MaxLength = 25;
			this.PatronymicTextBox.Name = "PatronymicTextBox";
			this.PatronymicTextBox.Size = new System.Drawing.Size(190, 26);
			this.PatronymicTextBox.TabIndex = 2;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameTextBox.Location = new System.Drawing.Point(109, 81);
			this.NameTextBox.MaxLength = 25;
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(190, 26);
			this.NameTextBox.TabIndex = 1;
			// 
			// LastNameTextBox
			// 
			this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LastNameTextBox.Location = new System.Drawing.Point(109, 36);
			this.LastNameTextBox.MaxLength = 25;
			this.LastNameTextBox.Name = "LastNameTextBox";
			this.LastNameTextBox.Size = new System.Drawing.Size(190, 26);
			this.LastNameTextBox.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(12, 312);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(79, 20);
			this.label7.TabIndex = 20;
			this.label7.Text = "Телефон";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(13, 265);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 20);
			this.label6.TabIndex = 19;
			this.label6.Text = "Квартира";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 220);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 20);
			this.label5.TabIndex = 18;
			this.label5.Text = "Дом";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 20);
			this.label4.TabIndex = 17;
			this.label4.Text = "Улица";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 20);
			this.label3.TabIndex = 16;
			this.label3.Text = "Отчество";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 20);
			this.label2.TabIndex = 15;
			this.label2.Text = "Имя";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 20);
			this.label1.TabIndex = 14;
			this.label1.Text = "Фамилия";
			// 
			// AddButton
			// 
			this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddButton.Location = new System.Drawing.Point(93, 363);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(122, 33);
			this.AddButton.TabIndex = 7;
			this.AddButton.Text = "Добавить";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// AddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 408);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.PhoneMaskedTextBox);
			this.Controls.Add(this.FlatNumericUpDown);
			this.Controls.Add(this.HouseNumericUpDown);
			this.Controls.Add(this.StreetTextBox);
			this.Controls.Add(this.PatronymicTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.LastNameTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "AddForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Добавление абонента";
			((System.ComponentModel.ISupportInitialize)(this.FlatNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HouseNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.NumericUpDown FlatNumericUpDown;
        private System.Windows.Forms.NumericUpDown HouseNumericUpDown;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
    }
}