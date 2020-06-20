namespace PhoneBook
{
    partial class Поиск_абонента
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
			this.PatronymicTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.LastNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SearchButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.ResultsTextBox = new System.Windows.Forms.TextBox();
			this.Close = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// PatronymicTextBox
			// 
			this.PatronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PatronymicTextBox.Location = new System.Drawing.Point(109, 112);
			this.PatronymicTextBox.MaxLength = 25;
			this.PatronymicTextBox.Name = "PatronymicTextBox";
			this.PatronymicTextBox.Size = new System.Drawing.Size(228, 26);
			this.PatronymicTextBox.TabIndex = 2;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameTextBox.Location = new System.Drawing.Point(109, 66);
			this.NameTextBox.MaxLength = 25;
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(228, 26);
			this.NameTextBox.TabIndex = 1;
			// 
			// LastNameTextBox
			// 
			this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LastNameTextBox.Location = new System.Drawing.Point(109, 21);
			this.LastNameTextBox.MaxLength = 25;
			this.LastNameTextBox.Name = "LastNameTextBox";
			this.LastNameTextBox.Size = new System.Drawing.Size(228, 26);
			this.LastNameTextBox.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 20);
			this.label3.TabIndex = 22;
			this.label3.Text = "Отчество";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 20);
			this.label2.TabIndex = 21;
			this.label2.Text = "Имя";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 20);
			this.label1.TabIndex = 20;
			this.label1.Text = "Фамилия";
			// 
			// SearchButton
			// 
			this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SearchButton.Location = new System.Drawing.Point(12, 156);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(163, 33);
			this.SearchButton.TabIndex = 3;
			this.SearchButton.Text = "Найти";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(97, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(156, 20);
			this.label4.TabIndex = 24;
			this.label4.Text = "Результаты поиска";
			// 
			// ResultsTextBox
			// 
			this.ResultsTextBox.Location = new System.Drawing.Point(12, 215);
			this.ResultsTextBox.Multiline = true;
			this.ResultsTextBox.Name = "ResultsTextBox";
			this.ResultsTextBox.ReadOnly = true;
			this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.ResultsTextBox.Size = new System.Drawing.Size(325, 181);
			this.ResultsTextBox.TabIndex = 4;
			// 
			// Close
			// 
			this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.Close.Location = new System.Drawing.Point(181, 156);
			this.Close.Name = "Close";
			this.Close.Size = new System.Drawing.Size(156, 33);
			this.Close.TabIndex = 5;
			this.Close.Text = "Закрыть";
			this.Close.UseVisualStyleBackColor = true;
			this.Close.Click += new System.EventHandler(this.Close_Click);
			// 
			// Поиск_абонента
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 408);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.ResultsTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.PatronymicTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.LastNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Поиск_абонента";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Поиск по ФИО";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button Close;
    }
}