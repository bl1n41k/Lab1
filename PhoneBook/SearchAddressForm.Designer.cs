namespace PhoneBook
{
    partial class SearchAddressForm
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
			this.ResultsTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SearchButton = new System.Windows.Forms.Button();
			this.FlatNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.HouseNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.StreetTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Close = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.FlatNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HouseNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// ResultsTextBox
			// 
			this.ResultsTextBox.Location = new System.Drawing.Point(13, 192);
			this.ResultsTextBox.Multiline = true;
			this.ResultsTextBox.Name = "ResultsTextBox";
			this.ResultsTextBox.ReadOnly = true;
			this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.ResultsTextBox.Size = new System.Drawing.Size(325, 213);
			this.ResultsTextBox.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(105, 169);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(156, 20);
			this.label4.TabIndex = 27;
			this.label4.Text = "Результаты поиска";
			// 
			// SearchButton
			// 
			this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SearchButton.Location = new System.Drawing.Point(13, 133);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(163, 33);
			this.SearchButton.TabIndex = 3;
			this.SearchButton.Text = "Найти";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// FlatNumericUpDown
			// 
			this.FlatNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FlatNumericUpDown.Location = new System.Drawing.Point(108, 101);
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
			this.FlatNumericUpDown.Size = new System.Drawing.Size(228, 26);
			this.FlatNumericUpDown.TabIndex = 2;
			this.FlatNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// HouseNumericUpDown
			// 
			this.HouseNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.HouseNumericUpDown.Location = new System.Drawing.Point(109, 64);
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
			this.HouseNumericUpDown.Size = new System.Drawing.Size(228, 26);
			this.HouseNumericUpDown.TabIndex = 1;
			this.HouseNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// StreetTextBox
			// 
			this.StreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StreetTextBox.Location = new System.Drawing.Point(109, 27);
			this.StreetTextBox.MaxLength = 40;
			this.StreetTextBox.Name = "StreetTextBox";
			this.StreetTextBox.Size = new System.Drawing.Size(228, 26);
			this.StreetTextBox.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(12, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 20);
			this.label6.TabIndex = 33;
			this.label6.Text = "Квартира";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 20);
			this.label5.TabIndex = 32;
			this.label5.Text = "Дом";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 20);
			this.label1.TabIndex = 31;
			this.label1.Text = "Улица";
			// 
			// Close
			// 
			this.Close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.Close.Location = new System.Drawing.Point(182, 133);
			this.Close.Name = "Close";
			this.Close.Size = new System.Drawing.Size(156, 33);
			this.Close.TabIndex = 5;
			this.Close.Text = "Закрыть";
			this.Close.UseVisualStyleBackColor = true;
			this.Close.Click += new System.EventHandler(this.Close_Click);
			// 
			// SearchAddressForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 408);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.FlatNumericUpDown);
			this.Controls.Add(this.HouseNumericUpDown);
			this.Controls.Add(this.StreetTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ResultsTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.SearchButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "SearchAddressForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Поиск по адресу";
			((System.ComponentModel.ISupportInitialize)(this.FlatNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HouseNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.NumericUpDown FlatNumericUpDown;
        private System.Windows.Forms.NumericUpDown HouseNumericUpDown;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close;
    }
}