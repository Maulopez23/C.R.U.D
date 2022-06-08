namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "LastName";
            dataGridView1.Columns[2].Name = "Age";
            dataGridView1.Columns[3].Name = "Marca";
            dataGridView1.Columns[4].Name = "Modelo";
            dataGridView1.Columns[5].Name = "Color";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            cbMarca.Items.Add("Nissan");
            cbMarca.Items.Add("Toyota");
            cbMarca.Items.Add("Subaru");
            cbMarca.Items.Add("Kia");
            cbMarca.Items.Add("Hyundai");
            cbMarca.Items.Add("Otro");



            cbColor.Items.Add("Rojo");
            cbColor.Items.Add("Verde");
            cbColor.Items.Add("Blanco");
            cbColor.Items.Add("Gris");
            cbColor.Items.Add("Azul");
            cbColor.Items.Add("Naranja");
            cbColor.Items.Add("Otro");



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            addRow(textBox1.Text, textBox2.Text, textBox3.Text, cbMarca.Text, cbColor.Text, txtmodelo.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void addRow(string name, string lastname, string age, string marca, string modelo, string color)
        {
            String[] row = { name, lastname, age, marca, modelo, color };
            dataGridView1.Rows.Add(row);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }
    }
}