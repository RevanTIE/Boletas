namespace Boletas
{
    partial class RespaldarBD
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
            this.lblCrearCopiaDeSeguridad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRespaldar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCrearCopiaDeSeguridad
            // 
            this.lblCrearCopiaDeSeguridad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCrearCopiaDeSeguridad.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCopiaDeSeguridad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCrearCopiaDeSeguridad.Location = new System.Drawing.Point(31, 21);
            this.lblCrearCopiaDeSeguridad.Name = "lblCrearCopiaDeSeguridad";
            this.lblCrearCopiaDeSeguridad.Size = new System.Drawing.Size(583, 30);
            this.lblCrearCopiaDeSeguridad.TabIndex = 9;
            this.lblCrearCopiaDeSeguridad.Text = "REALIZAR COPIA DE SEGURIDAD";
            this.lblCrearCopiaDeSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnRespaldar);
            this.groupBox1.Controls.Add(this.btnRegresar);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 238);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Respaldo de Seguridad";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(482, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 22);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = ". . .";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRespaldar
            // 
            this.btnRespaldar.BackColor = System.Drawing.Color.Green;
            this.btnRespaldar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRespaldar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRespaldar.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespaldar.ForeColor = System.Drawing.Color.White;
            this.btnRespaldar.Location = new System.Drawing.Point(180, 181);
            this.btnRespaldar.Name = "btnRespaldar";
            this.btnRespaldar.Size = new System.Drawing.Size(87, 36);
            this.btnRespaldar.TabIndex = 7;
            this.btnRespaldar.Text = "Respaldar";
            this.btnRespaldar.UseVisualStyleBackColor = false;
            this.btnRespaldar.Click += new System.EventHandler(this.btnRespaldar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(333, 181);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(82, 36);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(78, 80);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(38, 17);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Ruta:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(135, 77);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(338, 22);
            this.txtDireccion.TabIndex = 0;
            // 
            // RespaldarBD
            // 
            this.AcceptButton = this.btnRespaldar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CancelButton = this.btnRegresar;
            this.ClientSize = new System.Drawing.Size(645, 338);
            this.Controls.Add(this.lblCrearCopiaDeSeguridad);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RespaldarBD";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RespaldarBD";
            this.Load += new System.EventHandler(this.RespaldarBD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCrearCopiaDeSeguridad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRespaldar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnBuscar;
    }
}