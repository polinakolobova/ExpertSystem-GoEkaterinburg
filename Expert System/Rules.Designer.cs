namespace Expert_System
{
    partial class Rules
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._Option = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._Option,
            this._Question,
            this._Answer,
            this._Adress,
            this._Pr});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 690);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // _Option
            // 
            this._Option.HeaderText = "Область";
            this._Option.MinimumWidth = 6;
            this._Option.Name = "_Option";
            this._Option.Width = 125;
            // 
            // _Question
            // 
            this._Question.HeaderText = "Вопрос";
            this._Question.MinimumWidth = 6;
            this._Question.Name = "_Question";
            this._Question.Width = 200;
            // 
            // _Answer
            // 
            this._Answer.HeaderText = "Предложение";
            this._Answer.MinimumWidth = 6;
            this._Answer.Name = "_Answer";
            this._Answer.Width = 200;
            // 
            // _Adress
            // 
            this._Adress.HeaderText = "Адрес";
            this._Adress.MinimumWidth = 6;
            this._Adress.Name = "_Adress";
            this._Adress.Width = 200;
            // 
            // _Pr
            // 
            this._Pr.HeaderText = "Цена";
            this._Pr.MinimumWidth = 6;
            this._Pr.Name = "_Pr";
            this._Pr.Width = 50;
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Rules";
            this.Text = "Правила";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rules_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Option;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Pr;
    }
}