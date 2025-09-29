namespace lab_work_3_task2_OOP
{
    partial class frmMass
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtn = new TextBox();
            txtm = new TextBox();
            txtRez = new TextBox();
            dgvMass = new DataGridView();
            cmdStart = new Button();
            cmdExit = new Button();
            cmdClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMass).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 0;
            label1.Text = "Кількість строк n=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 145);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(213, 28);
            label2.TabIndex = 1;
            label2.Text = "Кількість стовпців m=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 265);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 2;
            label3.Text = "Результат:";
            // 
            // txtn
            // 
            txtn.Location = new Point(24, 63);
            txtn.Margin = new Padding(4);
            txtn.Name = "txtn";
            txtn.Size = new Size(263, 34);
            txtn.TabIndex = 3;
            // 
            // txtm
            // 
            txtm.Location = new Point(24, 177);
            txtm.Margin = new Padding(4);
            txtm.Name = "txtm";
            txtm.Size = new Size(263, 34);
            txtm.TabIndex = 4;
            // 
            // txtRez
            // 
            txtRez.Location = new Point(24, 306);
            txtRez.Margin = new Padding(4);
            txtRez.Multiline = true;
            txtRez.Name = "txtRez";
            txtRez.Size = new Size(375, 311);
            txtRez.TabIndex = 5;
            // 
            // dgvMass
            // 
            dgvMass.AllowUserToOrderColumns = true;
            dgvMass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMass.Location = new Point(460, 44);
            dgvMass.Margin = new Padding(4);
            dgvMass.Name = "dgvMass";
            dgvMass.RowHeadersWidth = 51;
            dgvMass.Size = new Size(600, 365);
            dgvMass.TabIndex = 6;
            // 
            // cmdStart
            // 
            cmdStart.Location = new Point(431, 482);
            cmdStart.Margin = new Padding(4);
            cmdStart.Name = "cmdStart";
            cmdStart.Size = new Size(195, 50);
            cmdStart.TabIndex = 7;
            cmdStart.Text = "Вычислить";
            cmdStart.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            cmdExit.Location = new Point(892, 482);
            cmdExit.Margin = new Padding(4);
            cmdExit.Name = "cmdExit";
            cmdExit.Size = new Size(195, 50);
            cmdExit.TabIndex = 8;
            cmdExit.Text = "Завершити роботу";
            cmdExit.UseVisualStyleBackColor = true;
            cmdExit.Click += cmdExit_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(661, 482);
            cmdClear.Margin = new Padding(4);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(195, 50);
            cmdClear.TabIndex = 9;
            cmdClear.Text = "Очистка полів";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += cmdClear_Click;
            // 
            // frmMass
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(cmdClear);
            Controls.Add(cmdExit);
            Controls.Add(cmdStart);
            Controls.Add(dgvMass);
            Controls.Add(txtRez);
            Controls.Add(txtm);
            Controls.Add(txtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "frmMass";
            Text = "Двумерные массивы";
            ((System.ComponentModel.ISupportInitialize)dgvMass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtn;
        private TextBox txtm;
        private TextBox txtRez;
        private DataGridView dgvMass;
        private Button cmdStart;
        private Button cmdExit;
        private Button cmdClear;
    }
}
