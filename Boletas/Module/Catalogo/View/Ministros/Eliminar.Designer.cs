namespace Boletas.Module.Catalogo.View.Ministros
{
    partial class Eliminar
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
            this.lblEliminarMinistro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.checkEstatus = new System.Windows.Forms.CheckBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblAM = new System.Windows.Forms.Label();
            this.txtAM = new System.Windows.Forms.TextBox();
            this.lblAP = new System.Windows.Forms.Label();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEliminarMinistro
            // 
            this.lblEliminarMinistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEliminarMinistro.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarMinistro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEliminarMinistro.Location = new System.Drawing.Point(31, 23);
            this.lblEliminarMinistro.Name = "lblEliminarMinistro";
            this.lblEliminarMinistro.Size = new System.Drawing.Size(583, 30);
            this.lblEliminarMinistro.TabIndex = 15;
            this.lblEliminarMinistro.Text = "ELIMINAR MINISTRO";
            this.lblEliminarMinistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.btnRegresar);
            this.groupBox1.Controls.Add(this.checkEstatus);
            this.groupBox1.Controls.Add(this.lblEstatus);
            this.groupBox1.Controls.Add(this.lblAM);
            this.groupBox1.Controls.Add(this.txtAM);
            this.groupBox1.Controls.Add(this.lblAP);
            this.groupBox1.Controls.Add(this.txtAP);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 282);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Ministro";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Green;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(194, 218);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 36);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(194, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 0;
            this.txtId.Visible = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(333, 218);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(82, 36);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // checkEstatus
            // 
            this.checkEstatus.AutoSize = true;
            this.checkEstatus.Enabled = false;
            this.checkEstatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEstatus.Location = new System.Drawing.Point(194, 137);
            this.checkEstatus.Name = "checkEstatus";
            this.checkEstatus.Size = new System.Drawing.Size(123, 21);
            this.checkEstatus.TabIndex = 4;
            this.checkEstatus.Text = "Activo/Inactivo";
            this.checkEstatus.UseVisualStyleBackColor = true;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.Location = new System.Drawing.Point(135, 135);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(52, 17);
            this.lblEstatus.TabIndex = 15;
            this.lblEstatus.Text = "Estatus:";
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAM.Location = new System.Drawing.Point(71, 110);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(115, 17);
            this.lblAM.TabIndex = 6;
            this.lblAM.Text = "Apellido Materno:";
            // 
            // txtAM
            // 
            this.txtAM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAM.Location = new System.Drawing.Point(194, 109);
            this.txtAM.Name = "txtAM";
            this.txtAM.ReadOnly = true;
            this.txtAM.Size = new System.Drawing.Size(221, 22);
            this.txtAM.TabIndex = 3;
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAP.Location = new System.Drawing.Point(75, 84);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(111, 17);
            this.lblAP.TabIndex = 4;
            this.lblAP.Text = "Apellido Paterno:";
            // 
            // txtAP
            // 
            this.txtAP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAP.Location = new System.Drawing.Point(194, 83);
            this.txtAP.Name = "txtAP";
            this.txtAP.ReadOnly = true;
            this.txtAP.Size = new System.Drawing.Size(221, 22);
            this.txtAP.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(78, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(108, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Ministro:";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(194, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(221, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // Eliminar
            // 
            this.AcceptButton = this.btnEliminar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CancelButton = this.btnRegresar;
            this.ClientSize = new System.Drawing.Size(645, 384);
            this.Controls.Add(this.lblEliminarMinistro);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eliminar";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.Eliminar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEliminarMinistro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.CheckBox checkEstatus;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label lblAM;
        private System.Windows.Forms.TextBox txtAM;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEliminar;
    }
}