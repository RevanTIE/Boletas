namespace Boletas.Module.Administrar.View.Matrimonios
{
    partial class Matrimonios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matrimonios));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBoletaPdf = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dataGridMatrimonios = new System.Windows.Forms.DataGridView();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.labMatrimonios = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dateTimeMonth = new System.Windows.Forms.DateTimePicker();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrimonios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnBoletaPdf);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.btnConsultar);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.txtBusqueda);
            this.groupBox3.Controls.Add(this.dataGridMatrimonios);
            this.groupBox3.Controls.Add(this.lblBusqueda);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(26, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(688, 386);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registros";
            // 
            // btnBoletaPdf
            // 
            this.btnBoletaPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoletaPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoletaPdf.Location = new System.Drawing.Point(188, 21);
            this.btnBoletaPdf.Name = "btnBoletaPdf";
            this.btnBoletaPdf.Size = new System.Drawing.Size(108, 35);
            this.btnBoletaPdf.TabIndex = 6;
            this.btnBoletaPdf.Text = "Generar Boleta";
            this.btnBoletaPdf.UseVisualStyleBackColor = true;
            this.btnBoletaPdf.Click += new System.EventHandler(this.btnBoletaPdf_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(317, 14);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 7;
            this.txtId.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Teal;
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Location = new System.Drawing.Point(64, 21);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(35, 35);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(146, 21);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(35, 35);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Teal;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Location = new System.Drawing.Point(638, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 22);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Navy;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Location = new System.Drawing.Point(105, 21);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(35, 35);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Location = new System.Drawing.Point(517, 22);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(122, 22);
            this.txtBusqueda.TabIndex = 8;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // dataGridMatrimonios
            // 
            this.dataGridMatrimonios.AllowUserToAddRows = false;
            this.dataGridMatrimonios.AllowUserToDeleteRows = false;
            this.dataGridMatrimonios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMatrimonios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridMatrimonios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatrimonios.Location = new System.Drawing.Point(24, 63);
            this.dataGridMatrimonios.MultiSelect = false;
            this.dataGridMatrimonios.Name = "dataGridMatrimonios";
            this.dataGridMatrimonios.ReadOnly = true;
            this.dataGridMatrimonios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMatrimonios.Size = new System.Drawing.Size(646, 295);
            this.dataGridMatrimonios.TabIndex = 10;
            this.dataGridMatrimonios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMatrimonios_CellContentClick);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(419, 24);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(92, 17);
            this.lblBusqueda.TabIndex = 1;
            this.lblBusqueda.Text = "Dato a buscar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(24, 21);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(35, 35);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // labMatrimonios
            // 
            this.labMatrimonios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labMatrimonios.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMatrimonios.Location = new System.Drawing.Point(26, 35);
            this.labMatrimonios.Name = "labMatrimonios";
            this.labMatrimonios.Size = new System.Drawing.Size(688, 32);
            this.labMatrimonios.TabIndex = 10;
            this.labMatrimonios.Text = "MATRIMONIOS";
            this.labMatrimonios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Green;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(243, 82);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(87, 30);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dateTimeMonth
            // 
            this.dateTimeMonth.CustomFormat = "MMMM-  yyyy";
            this.dateTimeMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeMonth.Location = new System.Drawing.Point(26, 85);
            this.dateTimeMonth.Name = "dateTimeMonth";
            this.dateTimeMonth.ShowUpDown = true;
            this.dateTimeMonth.Size = new System.Drawing.Size(200, 20);
            this.dateTimeMonth.TabIndex = 0;
            this.dateTimeMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimeMonth_KeyPress);
            // 
            // Matrimonios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 530);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dateTimeMonth);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labMatrimonios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Matrimonios";
            this.Text = "Matrimonios";
            this.Load += new System.EventHandler(this.Matrimonios_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrimonios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dataGridMatrimonios;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label labMatrimonios;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DateTimePicker dateTimeMonth;
        private System.Windows.Forms.Button btnBoletaPdf;
    }
}