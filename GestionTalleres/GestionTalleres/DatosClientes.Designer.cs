namespace GestionTalleres
{
    partial class DatosClientes
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
            datosClientesDb = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)datosClientesDb).BeginInit();
            SuspendLayout();
            // 
            // datosClientesDb
            // 
            datosClientesDb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datosClientesDb.Location = new Point(108, 105);
            datosClientesDb.Name = "datosClientesDb";
            datosClientesDb.Size = new Size(288, 365);
            datosClientesDb.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 61);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 22);
            label1.TabIndex = 1;
            label1.Text = "Clientes de todos los talleres";
            // 
            // DatosClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 525);
            Controls.Add(label1);
            Controls.Add(datosClientesDb);
            Name = "DatosClientes";
            Text = "DatosClientes";
            ((System.ComponentModel.ISupportInitialize)datosClientesDb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView datosClientesDb;
        private Label label1;
    }
}