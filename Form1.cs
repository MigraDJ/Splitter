namespace Splitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtLineas.Enabled = false;
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
                    progressBar.Visible = true;
                    progressBar.Minimum = 1;
                    progressBar.Maximum = lines.Length;
                    progressBar.Value = 1;
                    progressBar.Step = 1;
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

                        string fileName = txtArchivo.Text + "_" + numfile.ToString() + ".txt";
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
    }
}