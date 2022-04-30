namespace Splitter
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
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtNumLineas = new System.Windows.Forms.TextBox();
            this.lblNumLineas = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtLineas = new System.Windows.Forms.TextBox();
            this.lblLineas = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(37, 67);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(729, 27);
            this.txtArchivo.TabIndex = 0;
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(37, 44);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(62, 20);
            this.lblArchivo.TabIndex = 1;
            this.lblArchivo.Text = "Archivo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(672, 100);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // txtNumLineas
            // 
            this.txtNumLineas.Location = new System.Drawing.Point(49, 142);
            this.txtNumLineas.Name = "txtNumLineas";
            this.txtNumLineas.ReadOnly = true;
            this.txtNumLineas.Size = new System.Drawing.Size(222, 27);
            this.txtNumLineas.TabIndex = 3;
            // 
            // lblNumLineas
            // 
            this.lblNumLineas.AutoSize = true;
            this.lblNumLineas.Location = new System.Drawing.Point(49, 119);
            this.lblNumLineas.Name = "lblNumLineas";
            this.lblNumLineas.Size = new System.Drawing.Size(196, 20);
            this.lblNumLineas.TabIndex = 4;
            this.lblNumLineas.Text = "Total de líneas en el archivo:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(672, 205);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(94, 29);
            this.btnProcesar.TabIndex = 5;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtLineas
            // 
            this.txtLineas.Location = new System.Drawing.Point(363, 142);
            this.txtLineas.Name = "txtLineas";
            this.txtLineas.Size = new System.Drawing.Size(250, 27);
            this.txtLineas.TabIndex = 6;
            this.txtLineas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLineas_KeyPress);
            // 
            // lblLineas
            // 
            this.lblLineas.AutoSize = true;
            this.lblLineas.Location = new System.Drawing.Point(363, 119);
            this.lblLineas.Name = "lblLineas";
            this.lblLineas.Size = new System.Drawing.Size(208, 20);
            this.lblLineas.TabIndex = 7;
            this.lblLineas.Text = "Número de líneas por archivo:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(49, 214);
            this.progressBar.Minimum = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(564, 20);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 8;
            this.progressBar.Value = 1;
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Location = new System.Drawing.Point(49, 191);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(71, 20);
            this.lblProgreso.TabIndex = 9;
            this.lblProgreso.Text = "Progreso:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 266);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblLineas);
            this.Controls.Add(this.txtLineas);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.lblNumLineas);
            this.Controls.Add(this.txtNumLineas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.txtArchivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Lines Splitter by Gabriel Burrola Ⓒ ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtArchivo;
        private Label lblArchivo;
        private Button btnBuscar;
        private OpenFileDialog openFileDialog;
        private TextBox txtNumLineas;
        private Label lblNumLineas;
        private Button btnProcesar;
        private TextBox txtLineas;
        private Label lblLineas;
        private ProgressBar progressBar;
        private Label lblProgreso;
    }
}