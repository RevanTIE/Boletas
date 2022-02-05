namespace Boletas.View
{
    partial class Inicio
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
            this.labInicio = new System.Windows.Forms.Label();
            this.picInicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // labInicio
            // 
            this.labInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labInicio.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold);
            this.labInicio.Location = new System.Drawing.Point(94, 58);
            this.labInicio.Name = "labInicio";
            this.labInicio.Size = new System.Drawing.Size(494, 32);
            this.labInicio.TabIndex = 0;
            this.labInicio.Text = "CONTROL DE BOLETAS";
            this.labInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picInicio
            // 
            this.picInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picInicio.Image = global::Boletas.Properties.Resources.parroquia;
            this.picInicio.Location = new System.Drawing.Point(94, 123);
            this.picInicio.Name = "picInicio";
            this.picInicio.Size = new System.Drawing.Size(494, 338);
            this.picInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInicio.TabIndex = 1;
            this.picInicio.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 537);
            this.Controls.Add(this.picInicio);
            this.Controls.Add(this.labInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.picInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labInicio;
        private System.Windows.Forms.PictureBox picInicio;
    }
}