
namespace lat_1
{
    partial class FPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.cmbOrderId = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJumlahUang = new System.Windows.Forms.Label();
            this.lblKembalian = new System.Windows.Forms.Label();
            this.txtJumlahUang = new System.Windows.Forms.TextBox();
            this.txtKembalian = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.cmbBankName = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnBayar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Payment Page";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(93, 53);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(109, 20);
            this.lblWelcome.TabIndex = 49;
            this.lblWelcome.Text = "Order Id :";
            // 
            // cmbOrderId
            // 
            this.cmbOrderId.FormattingEnabled = true;
            this.cmbOrderId.Location = new System.Drawing.Point(208, 54);
            this.cmbOrderId.Name = "cmbOrderId";
            this.cmbOrderId.Size = new System.Drawing.Size(121, 21);
            this.cmbOrderId.TabIndex = 50;
            this.cmbOrderId.SelectedValueChanged += new System.EventHandler(this.cmbOrderId_SelectedValueChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(47, 96);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(351, 150);
            this.dgv.TabIndex = 51;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cmbPaymentType.Location = new System.Drawing.Point(238, 280);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(100, 21);
            this.cmbPaymentType.TabIndex = 53;
            this.cmbPaymentType.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Payment Type :";
            // 
            // lblJumlahUang
            // 
            this.lblJumlahUang.AutoSize = true;
            this.lblJumlahUang.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlahUang.Location = new System.Drawing.Point(64, 314);
            this.lblJumlahUang.Name = "lblJumlahUang";
            this.lblJumlahUang.Size = new System.Drawing.Size(139, 20);
            this.lblJumlahUang.TabIndex = 54;
            this.lblJumlahUang.Text = "Jumlah Uang :";
            // 
            // lblKembalian
            // 
            this.lblKembalian.AutoSize = true;
            this.lblKembalian.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKembalian.Location = new System.Drawing.Point(64, 351);
            this.lblKembalian.Name = "lblKembalian";
            this.lblKembalian.Size = new System.Drawing.Size(119, 20);
            this.lblKembalian.TabIndex = 55;
            this.lblKembalian.Text = "Kembalian :";
            // 
            // txtJumlahUang
            // 
            this.txtJumlahUang.Location = new System.Drawing.Point(238, 314);
            this.txtJumlahUang.Name = "txtJumlahUang";
            this.txtJumlahUang.Size = new System.Drawing.Size(100, 20);
            this.txtJumlahUang.TabIndex = 56;
            this.txtJumlahUang.TextChanged += new System.EventHandler(this.txtJumlahUang_TextChanged);
            // 
            // txtKembalian
            // 
            this.txtKembalian.Location = new System.Drawing.Point(238, 352);
            this.txtKembalian.Name = "txtKembalian";
            this.txtKembalian.Size = new System.Drawing.Size(100, 20);
            this.txtKembalian.TabIndex = 57;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(64, 314);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(139, 20);
            this.lblCardNumber.TabIndex = 58;
            this.lblCardNumber.Text = "Card Number :";
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankName.Location = new System.Drawing.Point(64, 352);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(119, 20);
            this.lblBankName.TabIndex = 59;
            this.lblBankName.Text = "Bank Name :";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(238, 315);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCardNumber.TabIndex = 60;
            // 
            // cmbBankName
            // 
            this.cmbBankName.FormattingEnabled = true;
            this.cmbBankName.Items.AddRange(new object[] {
            "BRI",
            "BCA",
            "BSI"});
            this.cmbBankName.Location = new System.Drawing.Point(238, 352);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.Size = new System.Drawing.Size(100, 21);
            this.cmbBankName.TabIndex = 61;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(64, 402);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 20);
            this.lblTotal.TabIndex = 62;
            this.lblTotal.Text = "Total :";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 450);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 24);
            this.btnBack.TabIndex = 63;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(188, 450);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(102, 24);
            this.btnBatal.TabIndex = 64;
            this.btnBatal.Text = "batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnBayar
            // 
            this.btnBayar.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.Location = new System.Drawing.Point(296, 450);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(102, 24);
            this.btnBayar.TabIndex = 65;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // FPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 486);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cmbBankName);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblBankName);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.txtKembalian);
            this.Controls.Add(this.txtJumlahUang);
            this.Controls.Add(this.lblKembalian);
            this.Controls.Add(this.lblJumlahUang);
            this.Controls.Add(this.cmbPaymentType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cmbOrderId);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label1);
            this.Name = "FPayment";
            this.Text = "FPayment";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ComboBox cmbOrderId;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblJumlahUang;
        private System.Windows.Forms.Label lblKembalian;
        private System.Windows.Forms.TextBox txtJumlahUang;
        private System.Windows.Forms.TextBox txtKembalian;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.ComboBox cmbBankName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnBayar;
    }
}