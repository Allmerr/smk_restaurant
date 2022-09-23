
namespace lat_1
{
    partial class FOrder
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblCarbo = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvBawah = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNamaPembeli = new System.Windows.Forms.Label();
            this.txtNamaMenu = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.PictureBox();
            this.dgvAtas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBawah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(665, 486);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(102, 24);
            this.btnOrder.TabIndex = 58;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblCarbo
            // 
            this.lblCarbo.AutoSize = true;
            this.lblCarbo.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbo.Location = new System.Drawing.Point(50, 452);
            this.lblCarbo.Name = "lblCarbo";
            this.lblCarbo.Size = new System.Drawing.Size(79, 20);
            this.lblCarbo.TabIndex = 57;
            this.lblCarbo.Text = "Carbo :";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtein.Location = new System.Drawing.Point(50, 471);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(99, 20);
            this.lblProtein.TabIndex = 56;
            this.lblProtein.Text = "Protein :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(50, 490);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 20);
            this.lblTotal.TabIndex = 55;
            this.lblTotal.Text = "Total :";
            // 
            // dgvBawah
            // 
            this.dgvBawah.AllowUserToAddRows = false;
            this.dgvBawah.AllowUserToDeleteRows = false;
            this.dgvBawah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBawah.Location = new System.Drawing.Point(34, 294);
            this.dgvBawah.Name = "dgvBawah";
            this.dgvBawah.ReadOnly = true;
            this.dgvBawah.Size = new System.Drawing.Size(733, 150);
            this.dgvBawah.TabIndex = 54;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(363, 262);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 24);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(484, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 24);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNamaPembeli
            // 
            this.lblNamaPembeli.AutoSize = true;
            this.lblNamaPembeli.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaPembeli.Location = new System.Drawing.Point(359, 208);
            this.lblNamaPembeli.Name = "lblNamaPembeli";
            this.lblNamaPembeli.Size = new System.Drawing.Size(119, 20);
            this.lblNamaPembeli.TabIndex = 51;
            this.lblNamaPembeli.Text = "Nama Menu :";
            // 
            // txtNamaMenu
            // 
            this.txtNamaMenu.Location = new System.Drawing.Point(484, 208);
            this.txtNamaMenu.Name = "txtNamaMenu";
            this.txtNamaMenu.Size = new System.Drawing.Size(100, 20);
            this.txtNamaMenu.TabIndex = 50;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(221, 206);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(122, 78);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 49;
            this.pb.TabStop = false;
            // 
            // dgvAtas
            // 
            this.dgvAtas.AllowUserToAddRows = false;
            this.dgvAtas.AllowUserToDeleteRows = false;
            this.dgvAtas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtas.Location = new System.Drawing.Point(34, 53);
            this.dgvAtas.Name = "dgvAtas";
            this.dgvAtas.ReadOnly = true;
            this.dgvAtas.Size = new System.Drawing.Size(733, 139);
            this.dgvAtas.TabIndex = 48;
            this.dgvAtas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAtas_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Pilih Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Qty :";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(484, 231);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 59;
            // 
            // FOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblCarbo);
            this.Controls.Add(this.lblProtein);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvBawah);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNamaPembeli);
            this.Controls.Add(this.txtNamaMenu);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.dgvAtas);
            this.Controls.Add(this.label1);
            this.Name = "FOrder";
            this.Text = "FOrder";
            this.Load += new System.EventHandler(this.FOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBawah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblCarbo;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvBawah;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNamaPembeli;
        private System.Windows.Forms.TextBox txtNamaMenu;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.DataGridView dgvAtas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQty;
    }
}