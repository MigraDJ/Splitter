namespace Splitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtLineas.Enabled = false; 
            btnProcesar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog(this);
        }

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtArchivo.Text = openFileDialog.FileName;
            txtNumLineas.Text = File.ReadAllLines(openFileDialog.FileName).Length.ToString();
            txtLineas.Enabled = true;
            btnProcesar.Enabled = true;
            string[] dir = openFileDialog.FileName.Split('\\');
            string directory = string.Empty;
            for (int i = 0; i <= dir.Length-2; i++)
            {
                directory = directory + dir[i] + "\\";
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {            
            try
            {
                if (int.Parse(txtLineas.Text) < int.Parse(txtNumLineas.Text))
                {
                    int numfile = 1;
                    int pos = 0;
                    List<string> lista = new List<string>();
                    string[] lines = File.ReadAllLines(txtArchivo.Text);
                    enablePBar(lines);
                    while (pos < lines.Length)
                    {
                        for (int i = 1; i <= int.Parse(txtLineas.Text); i++)
                        {
                            if (pos <= lines.Length - 1)
                            {
                                lista.Add(lines[pos]);
                            }
                            pos++;
                            progressBar.PerformStep();
                        }

                        string fileName = txtArchivo.Text + "_" + numfile.ToString() + ".sql";
                        if (!File.Exists(fileName))
                        {
                            using (StreamWriter sw = File.CreateText(fileName))
                            {
                                foreach (string l in lista)
                                {
                                    sw.WriteLine(l);
                                }
                                lista.Clear();
                                numfile++;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El archivo que se intenta crear ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    MessageBox.Show("Proceso terminado correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operación no válida, el número de líneas del archivo es menor al número de líneas establecido para dividir."
                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLineas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void enablePBar(string[] lines)
        {
            progressBar.Visible = true;
            progressBar.Minimum = 1;
            progressBar.Maximum = lines.Length;
            progressBar.Value = 1;
            progressBar.Step = 1;
        }
    }
}