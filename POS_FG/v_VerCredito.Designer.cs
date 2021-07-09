namespace POS_FG
{
    partial class v_VerCredito
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
            this.pan_Sup = new System.Windows.Forms.Panel();
            this.lbl_NombreV = new System.Windows.Forms.Label();
            this.pb_Minimizar = new System.Windows.Forms.PictureBox();
            this.pb_Cerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv_Creditos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_BsCliente = new System.Windows.Forms.Button();
            this.txt_CedCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NomCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CantPaga = new System.Windows.Forms.TextBox();
            this.btn_Finalizar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.pan_Sup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Creditos)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_Sup
            // 
            this.pan_Sup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.pan_Sup.Controls.Add(this.lbl_NombreV);
            this.pan_Sup.Controls.Add(this.pb_Minimizar);
            this.pan_Sup.Controls.Add(this.pb_Cerrar);
            this.pan_Sup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_Sup.Location = new System.Drawing.Point(0, 0);
            this.pan_Sup.Name = "pan_Sup";
            this.pan_Sup.Size = new System.Drawing.Size(864, 45);
            this.pan_Sup.TabIndex = 0;
            this.pan_Sup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_Sup_MouseDown);
            // 
            // lbl_NombreV
            // 
            this.lbl_NombreV.AutoSize = true;
            this.lbl_NombreV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreV.ForeColor = System.Drawing.Color.White;
            this.lbl_NombreV.Location = new System.Drawing.Point(12, 7);
            this.lbl_NombreV.Name = "lbl_NombreV";
            this.lbl_NombreV.Size = new System.Drawing.Size(107, 29);
            this.lbl_NombreV.TabIndex = 2;
            this.lbl_NombreV.Text = "Creditos";
            this.lbl_NombreV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_NombreV_MouseDown);
            // 
            // pb_Minimizar
            // 
            this.pb_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Minimizar.Image = global::POS_FG.Properties.Resources.minimizar;
            this.pb_Minimizar.Location = new System.Drawing.Point(772, 3);
            this.pb_Minimizar.Name = "pb_Minimizar";
            this.pb_Minimizar.Size = new System.Drawing.Size(31, 35);
            this.pb_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Minimizar.TabIndex = 1;
            this.pb_Minimizar.TabStop = false;
            this.pb_Minimizar.Click += new System.EventHandler(this.pb_Minimizar_Click);
            // 
            // pb_Cerrar
            // 
            this.pb_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Cerrar.Image = global::POS_FG.Properties.Resources.letra_x;
            this.pb_Cerrar.Location = new System.Drawing.Point(821, 3);
            this.pb_Cerrar.Name = "pb_Cerrar";
            this.pb_Cerrar.Size = new System.Drawing.Size(31, 35);
            this.pb_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Cerrar.TabIndex = 0;
            this.pb_Cerrar.TabStop = false;
            this.pb_Cerrar.Click += new System.EventHandler(this.pb_Cerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 559);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(854, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 559);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 599);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 5);
            this.panel3.TabIndex = 2;
            // 
            // dtgv_Creditos
            // 
            this.dtgv_Creditos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Creditos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Creditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Creditos.Location = new System.Drawing.Point(19, 114);
            this.dtgv_Creditos.Name = "dtgv_Creditos";
            this.dtgv_Creditos.RowHeadersVisible = false;
            this.dtgv_Creditos.RowHeadersWidth = 51;
            this.dtgv_Creditos.RowTemplate.Height = 24;
            this.dtgv_Creditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Creditos.Size = new System.Drawing.Size(818, 324);
            this.dtgv_Creditos.TabIndex = 7;
            this.dtgv_Creditos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Creditos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(190, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(258, 69);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(292, 26);
            this.txt_Nombre.TabIndex = 14;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Limpiar.Enabled = false;
            this.btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Limpiar.Image = global::POS_FG.Properties.Resources.cerrar_el_simbolo_de_la_cruz_en_un_circulo;
            this.btn_Limpiar.Location = new System.Drawing.Point(601, 67);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Limpiar.Size = new System.Drawing.Size(43, 30);
            this.btn_Limpiar.TabIndex = 13;
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_BsCliente
            // 
            this.btn_BsCliente.BackColor = System.Drawing.Color.DimGray;
            this.btn_BsCliente.FlatAppearance.BorderSize = 0;
            this.btn_BsCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BsCliente.ForeColor = System.Drawing.Color.DimGray;
            this.btn_BsCliente.Image = global::POS_FG.Properties.Resources.lupa;
            this.btn_BsCliente.Location = new System.Drawing.Point(557, 68);
            this.btn_BsCliente.Name = "btn_BsCliente";
            this.btn_BsCliente.Size = new System.Drawing.Size(38, 30);
            this.btn_BsCliente.TabIndex = 10;
            this.btn_BsCliente.UseVisualStyleBackColor = false;
            this.btn_BsCliente.Click += new System.EventHandler(this.btn_BsCliente_Click);
            // 
            // txt_CedCliente
            // 
            this.txt_CedCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CedCliente.Location = new System.Drawing.Point(162, 469);
            this.txt_CedCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CedCliente.Name = "txt_CedCliente";
            this.txt_CedCliente.ReadOnly = true;
            this.txt_CedCliente.Size = new System.Drawing.Size(213, 26);
            this.txt_CedCliente.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 472);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 515);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nombre";
            // 
            // txt_NomCliente
            // 
            this.txt_NomCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomCliente.Location = new System.Drawing.Point(162, 512);
            this.txt_NomCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NomCliente.Name = "txt_NomCliente";
            this.txt_NomCliente.ReadOnly = true;
            this.txt_NomCliente.Size = new System.Drawing.Size(246, 26);
            this.txt_NomCliente.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 560);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Monto";
            // 
            // txt_Monto
            // 
            this.txt_Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Monto.Location = new System.Drawing.Point(162, 557);
            this.txt_Monto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.ReadOnly = true;
            this.txt_Monto.Size = new System.Drawing.Size(125, 26);
            this.txt_Monto.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(672, 469);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Cantidad a pagar";
            // 
            // txt_CantPaga
            // 
            this.txt_CantPaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CantPaga.Location = new System.Drawing.Point(651, 493);
            this.txt_CantPaga.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CantPaga.Name = "txt_CantPaga";
            this.txt_CantPaga.Size = new System.Drawing.Size(178, 26);
            this.txt_CantPaga.TabIndex = 35;
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Finalizar.FlatAppearance.BorderSize = 0;
            this.btn_Finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finalizar.ForeColor = System.Drawing.Color.White;
            this.btn_Finalizar.Image = global::POS_FG.Properties.Resources.carro;
            this.btn_Finalizar.Location = new System.Drawing.Point(666, 526);
            this.btn_Finalizar.Name = "btn_Finalizar";
            this.btn_Finalizar.Size = new System.Drawing.Size(142, 38);
            this.btn_Finalizar.TabIndex = 37;
            this.btn_Finalizar.Text = "Pagar";
            this.btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Finalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Finalizar.UseVisualStyleBackColor = false;
            this.btn_Finalizar.Click += new System.EventHandler(this.btn_Finalizar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Image = global::POS_FG.Properties.Resources.eliminar__1_;
            this.btn_Eliminar.Location = new System.Drawing.Point(785, 77);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(52, 30);
            this.btn_Eliminar.TabIndex = 38;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // v_VerCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(864, 604);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Finalizar);
            this.Controls.Add(this.txt_CantPaga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Monto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NomCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CedCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_BsCliente);
            this.Controls.Add(this.dtgv_Creditos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pan_Sup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "v_VerCredito";
            this.Text = "v_Ventas";
            this.Load += new System.EventHandler(this.v_VerCredito_Load);
            this.pan_Sup.ResumeLayout(false);
            this.pan_Sup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Creditos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan_Sup;
        private System.Windows.Forms.PictureBox pb_Cerrar;
        private System.Windows.Forms.PictureBox pb_Minimizar;
        private System.Windows.Forms.Label lbl_NombreV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgv_Creditos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_BsCliente;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_CedCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NomCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CantPaga;
        private System.Windows.Forms.Button btn_Finalizar;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}