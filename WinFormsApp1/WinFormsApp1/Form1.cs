namespace WinFormsApp1
{
    public partial class Navegator : Form
    {
        public Navegator()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Wed.GoBack();
        }

        private void UrlNavegador_Click(object sender, EventArgs e)
        {
            Navegator.txtBuscar(txtBuscar.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Wed.GoHome();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            wed.Refresh();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            wed.GoForwad();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            wed.Navigate(txtBuscar.Text);
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
