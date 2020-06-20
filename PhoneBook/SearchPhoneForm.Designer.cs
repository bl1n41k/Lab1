namespace PhoneBook
{
    partial class SearchPhoneForm
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
			this.label7 = new System.Windows.Forms.Label();
			this.ResultsTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SearchButton = new System.Windows.Forms.Button();
			this.Close = new System.Windows.Forms.Button();
			this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(23, 37);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(79, 20);
			this.label7.TabIndex = 14;
			this.label7.Text = "Телефон";
			// 
			// ResultsTextBox
			// 
			this.ResultsTextBox.Location = new System.Drawing.Point(12, 128);
			this.ResultsTextBox.Multiline = true;
			this.ResultsTextBox.Name = "ResultsTextBox";
			this.ResultsTextBox.ReadOnly = true;
			this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.ResultsTextBox.Size = new System.Drawing.Size(325, 273);
			this.ResultsTextBox.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(97, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(156, 20);
			this.label4.TabIndex = 27;
			this.label4.Text = "Результаты поиска";
			// 
			// SearchButton
			// 
			this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SearchButton.Location = new System.Drawing.Point(12, 69);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(160, 33);
			this.SearchButton.TabIndex = 1;
			this.SearchButton.Text = "Найти";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// Close
			// 
			this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.Close.Location = new System.Drawing.Point(178, 69);
			this.Close.Name = "Close";
			this.Close.Size = new System.Drawing.Size(159, 33);
			this.Close.TabIndex = 3;
			this.Close.Text = "Закрыть";
			this.Close.UseVisualStyleBackColor = true;
			this.Close.Click += new System.EventHandler(this.Close_Click);
			// 
			// PhoneMaskedTextBox
			// 
			this.PhoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PhoneMaskedTextBox.Location = new System.Drawing.Point(121, 37);
			this.PhoneMaskedTextBox.Mask = "(999) 000-0000";
			this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
			this.PhoneMaskedTextBox.Size = new System.Drawing.Size(196, 26);
			this.PhoneMaskedTextBox.TabIndex = 0;
			// 
			// SearchPhoneForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 408);
			this.Controls.Add(this.PhoneMaskedTextBox);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.ResultsTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.label7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "SearchPhoneForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Поиск по телефону";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
    }
}