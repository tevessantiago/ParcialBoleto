namespace UI_WinForms
{
    partial class Form1
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
            this.txtDias = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvAgregados = new System.Windows.Forms.DataGridView();
            this.dgvVendidos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(123, 89);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(231, 23);
            this.txtDias.TabIndex = 0;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(123, 128);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(231, 23);
            this.cmbTipo.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(437, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(140, 32);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "BOLETERÍA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Días";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de Salida";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 250);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(231, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "AGREGAR BOLETO";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(20, 308);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(231, 23);
            this.btnVender.TabIndex = 8;
            this.btnVender.Text = "VENDER BOLETOS";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 550);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "ELIMINAR BOLETO";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 579);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "ACTUALIZAR BOLETO";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 521);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(231, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "BUSCAR BOLETO";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(20, 492);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(231, 23);
            this.btnListar.TabIndex = 12;
            this.btnListar.Text = "LISTAR TODOS";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvAgregados
            // 
            this.dgvAgregados.AllowUserToAddRows = false;
            this.dgvAgregados.AllowUserToDeleteRows = false;
            this.dgvAgregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgregados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregados.Location = new System.Drawing.Point(360, 89);
            this.dgvAgregados.Name = "dgvAgregados";
            this.dgvAgregados.ReadOnly = true;
            this.dgvAgregados.RowTemplate.Height = 25;
            this.dgvAgregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgregados.Size = new System.Drawing.Size(798, 242);
            this.dgvAgregados.TabIndex = 13;
            // 
            // dgvVendidos
            // 
            this.dgvVendidos.AllowUserToAddRows = false;
            this.dgvVendidos.AllowUserToDeleteRows = false;
            this.dgvVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendidos.Location = new System.Drawing.Point(360, 360);
            this.dgvVendidos.Name = "dgvVendidos";
            this.dgvVendidos.ReadOnly = true;
            this.dgvVendidos.RowTemplate.Height = 25;
            this.dgvVendidos.Size = new System.Drawing.Size(798, 242);
            this.dgvVendidos.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Boletos Agregados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Boletos Vendidos";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(20, 279);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(231, 23);
            this.btnQuitar.TabIndex = 17;
            this.btnQuitar.Text = "QUITAR BOLETO";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 614);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvVendidos);
            this.Controls.Add(this.dgvAgregados);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtDias);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDias;
        private ComboBox cmbTipo;
        private DateTimePicker dateTimePicker1;
        private Label lblTitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAgregar;
        private Button btnVender;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button btnListar;
        private DataGridView dgvAgregados;
        private DataGridView dgvVendidos;
        private Label label4;
        private Label label5;
        private Button btnQuitar;
    }
}