namespace Budzet
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Title = new System.Windows.Forms.Label();
            this.income = new System.Windows.Forms.Label();
            this.outcome = new System.Windows.Forms.Label();
            this.incomeInputLabel = new System.Windows.Forms.Label();
            this.incomeCommentLabel = new System.Windows.Forms.Label();
            this.incomeCommentInput = new System.Windows.Forms.TextBox();
            this.IncomeDateLabel = new System.Windows.Forms.Label();
            this.IncomeInput = new System.Windows.Forms.NumericUpDown();
            this.IncomeDateInput = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.OutcomeInput = new System.Windows.Forms.NumericUpDown();
            this.OutcomeDateInput = new System.Windows.Forms.Label();
            this.OutcomeCommentLabel = new System.Windows.Forms.Label();
            this.OutcomeCommentInput = new System.Windows.Forms.TextBox();
            this.OutcomeLabel = new System.Windows.Forms.Label();
            this.OutcomeCategoryLabel = new System.Windows.Forms.Label();
            this.SendIncome = new System.Windows.Forms.Button();
            this.sendOutcome = new System.Windows.Forms.Button();
            this.CategoryInput = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutcomeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.MaximumSize = new System.Drawing.Size(1280, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(961, 671);
            this.Title.TabIndex = 0;
            this.Title.Text = "ZARZĄDZAJ BUDŻETEM";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // income
            // 
            this.income.AutoSize = true;
            this.income.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.income.Location = new System.Drawing.Point(115, 88);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(81, 20);
            this.income.TabIndex = 1;
            this.income.Text = "Przychody";
            this.income.Click += new System.EventHandler(this.income_Click);
            // 
            // outcome
            // 
            this.outcome.AutoSize = true;
            this.outcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outcome.Location = new System.Drawing.Point(728, 88);
            this.outcome.Name = "outcome";
            this.outcome.Size = new System.Drawing.Size(65, 20);
            this.outcome.TabIndex = 2;
            this.outcome.Text = "Wydatki";
            this.outcome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // incomeInputLabel
            // 
            this.incomeInputLabel.AutoSize = true;
            this.incomeInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.incomeInputLabel.Location = new System.Drawing.Point(50, 137);
            this.incomeInputLabel.Name = "incomeInputLabel";
            this.incomeInputLabel.Size = new System.Drawing.Size(46, 20);
            this.incomeInputLabel.TabIndex = 5;
            this.incomeInputLabel.Text = "Ilość:";
            // 
            // incomeCommentLabel
            // 
            this.incomeCommentLabel.AutoSize = true;
            this.incomeCommentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.incomeCommentLabel.Location = new System.Drawing.Point(45, 184);
            this.incomeCommentLabel.Name = "incomeCommentLabel";
            this.incomeCommentLabel.Size = new System.Drawing.Size(177, 20);
            this.incomeCommentLabel.TabIndex = 7;
            this.incomeCommentLabel.Text = "Komentarz(opcjonalne):";
            this.incomeCommentLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // incomeCommentInput
            // 
            this.incomeCommentInput.Location = new System.Drawing.Point(228, 184);
            this.incomeCommentInput.Name = "incomeCommentInput";
            this.incomeCommentInput.Size = new System.Drawing.Size(100, 20);
            this.incomeCommentInput.TabIndex = 6;
            this.incomeCommentInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IncomeDateLabel
            // 
            this.IncomeDateLabel.AutoSize = true;
            this.IncomeDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncomeDateLabel.Location = new System.Drawing.Point(45, 234);
            this.IncomeDateLabel.Name = "IncomeDateLabel";
            this.IncomeDateLabel.Size = new System.Drawing.Size(135, 20);
            this.IncomeDateLabel.TabIndex = 9;
            this.IncomeDateLabel.Text = "Data(opcjonalne):";
            this.IncomeDateLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // IncomeInput
            // 
            this.IncomeInput.Location = new System.Drawing.Point(102, 137);
            this.IncomeInput.Name = "IncomeInput";
            this.IncomeInput.Size = new System.Drawing.Size(120, 20);
            this.IncomeInput.TabIndex = 10;
            // 
            // IncomeDateInput
            // 
            this.IncomeDateInput.Location = new System.Drawing.Point(186, 234);
            this.IncomeDateInput.Name = "IncomeDateInput";
            this.IncomeDateInput.Size = new System.Drawing.Size(200, 20);
            this.IncomeDateInput.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(682, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // OutcomeInput
            // 
            this.OutcomeInput.Location = new System.Drawing.Point(762, 137);
            this.OutcomeInput.Name = "OutcomeInput";
            this.OutcomeInput.Size = new System.Drawing.Size(120, 20);
            this.OutcomeInput.TabIndex = 16;
            // 
            // OutcomeDateInput
            // 
            this.OutcomeDateInput.AutoSize = true;
            this.OutcomeDateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OutcomeDateInput.Location = new System.Drawing.Point(541, 298);
            this.OutcomeDateInput.Name = "OutcomeDateInput";
            this.OutcomeDateInput.Size = new System.Drawing.Size(135, 20);
            this.OutcomeDateInput.TabIndex = 15;
            this.OutcomeDateInput.Text = "Data(opcjonalne):";
            // 
            // OutcomeCommentLabel
            // 
            this.OutcomeCommentLabel.AutoSize = true;
            this.OutcomeCommentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OutcomeCommentLabel.Location = new System.Drawing.Point(599, 250);
            this.OutcomeCommentLabel.Name = "OutcomeCommentLabel";
            this.OutcomeCommentLabel.Size = new System.Drawing.Size(177, 20);
            this.OutcomeCommentLabel.TabIndex = 14;
            this.OutcomeCommentLabel.Text = "Komentarz(opcjonalne):";
            // 
            // OutcomeCommentInput
            // 
            this.OutcomeCommentInput.Location = new System.Drawing.Point(782, 249);
            this.OutcomeCommentInput.Name = "OutcomeCommentInput";
            this.OutcomeCommentInput.Size = new System.Drawing.Size(100, 20);
            this.OutcomeCommentInput.TabIndex = 13;
            // 
            // OutcomeLabel
            // 
            this.OutcomeLabel.AutoSize = true;
            this.OutcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OutcomeLabel.Location = new System.Drawing.Point(710, 137);
            this.OutcomeLabel.Name = "OutcomeLabel";
            this.OutcomeLabel.Size = new System.Drawing.Size(46, 20);
            this.OutcomeLabel.TabIndex = 12;
            this.OutcomeLabel.Text = "Ilość:";
            // 
            // OutcomeCategoryLabel
            // 
            this.OutcomeCategoryLabel.AutoSize = true;
            this.OutcomeCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OutcomeCategoryLabel.Location = new System.Drawing.Point(548, 196);
            this.OutcomeCategoryLabel.Name = "OutcomeCategoryLabel";
            this.OutcomeCategoryLabel.Size = new System.Drawing.Size(228, 20);
            this.OutcomeCategoryLabel.TabIndex = 19;
            this.OutcomeCategoryLabel.Text = "Kategoria(rachunki, nauka, itd.)";
            // 
            // SendIncome
            // 
            this.SendIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SendIncome.Location = new System.Drawing.Point(146, 288);
            this.SendIncome.Name = "SendIncome";
            this.SendIncome.Size = new System.Drawing.Size(94, 28);
            this.SendIncome.TabIndex = 20;
            this.SendIncome.Text = "Dodaj";
            this.SendIncome.UseVisualStyleBackColor = true;
            this.SendIncome.Click += new System.EventHandler(this.SendIncome_Click);
            // 
            // sendOutcome
            // 
            this.sendOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sendOutcome.Location = new System.Drawing.Point(682, 355);
            this.sendOutcome.Name = "sendOutcome";
            this.sendOutcome.Size = new System.Drawing.Size(94, 28);
            this.sendOutcome.TabIndex = 21;
            this.sendOutcome.Text = "Dodaj";
            this.sendOutcome.UseVisualStyleBackColor = true;
            // 
            // CategoryInput
            // 
            this.CategoryInput.FormattingEnabled = true;
            this.CategoryInput.Items.AddRange(new object[] {
            "rachunki",
            "jedzenie",
            "nauka",
            "sport",
            "subskrypcje",
            "technika"});
            this.CategoryInput.Location = new System.Drawing.Point(782, 184);
            this.CategoryInput.Name = "CategoryInput";
            this.CategoryInput.Size = new System.Drawing.Size(81, 43);
            this.CategoryInput.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 671);
            this.Controls.Add(this.CategoryInput);
            this.Controls.Add(this.sendOutcome);
            this.Controls.Add(this.SendIncome);
            this.Controls.Add(this.OutcomeCategoryLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.OutcomeInput);
            this.Controls.Add(this.OutcomeDateInput);
            this.Controls.Add(this.OutcomeCommentLabel);
            this.Controls.Add(this.OutcomeCommentInput);
            this.Controls.Add(this.OutcomeLabel);
            this.Controls.Add(this.IncomeDateInput);
            this.Controls.Add(this.IncomeInput);
            this.Controls.Add(this.IncomeDateLabel);
            this.Controls.Add(this.incomeCommentLabel);
            this.Controls.Add(this.incomeCommentInput);
            this.Controls.Add(this.incomeInputLabel);
            this.Controls.Add(this.outcome);
            this.Controls.Add(this.income);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "sA";
            ((System.ComponentModel.ISupportInitialize)(this.IncomeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutcomeInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label income;
        private System.Windows.Forms.Label outcome;
        private System.Windows.Forms.Label incomeInputLabel;
        private System.Windows.Forms.Label incomeCommentLabel;
        private System.Windows.Forms.TextBox incomeCommentInput;
        private System.Windows.Forms.Label IncomeDateLabel;
        private System.Windows.Forms.NumericUpDown IncomeInput;
        private System.Windows.Forms.DateTimePicker IncomeDateInput;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown OutcomeInput;
        private System.Windows.Forms.Label OutcomeDateInput;
        private System.Windows.Forms.Label OutcomeCommentLabel;
        private System.Windows.Forms.TextBox OutcomeCommentInput;
        private System.Windows.Forms.Label OutcomeLabel;
        private System.Windows.Forms.Label OutcomeCategoryLabel;
        private System.Windows.Forms.Button SendIncome;
        private System.Windows.Forms.Button sendOutcome;
        private System.Windows.Forms.ListBox CategoryInput;
    }
}

