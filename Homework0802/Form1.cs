using Npgsql;
using System.Text;

namespace Homework0802
{
    public partial class Form1 : Form
    {
        const string CONNECTION_STRING = "Host=localhost:5432; username=postgres; password=25481; database = ProductDatabase";
        public Form1()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            NpgsqlConnection con = new NpgsqlConnection(CONNECTION_STRING);
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM product_without_image", con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
                dataGridView1.Rows.Add((int)reader.GetValue(0), (string)reader.GetValue(1), (int)reader.GetValue(2));
        }

        private void buttonTxt_Click(object sender, EventArgs e)
        {
            string? filePath = GetPath("Text files(*.txt) | *.txt | All files(*.*) | *.*");
            if (filePath != null)
            {
                TextWriter tw = new StreamWriter(filePath);
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        tw.Write($"{dataGridView1.Rows[i].Cells[j].Value}");

                        if (j != dataGridView1.Columns.Count - 1)
                        {
                            tw.Write(", ");
                        }
                    }
                    tw.WriteLine();
                }
                tw.Close();
                MessageBox.Show("Файл успешно сохранен!", "Успешное сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCsv_Click(object sender, EventArgs e)
        {
            string file = "";
            string? filePath = GetPath("CSV files (*.csv)|*.csv|All files(*.*)|*.*");
            if (filePath != null)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    file += (dataGridView1.Columns[i].HeaderText + ";");

                }
                file += "\t\n";
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {

                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {

                        file += (dataGridView1[j, i].Value).ToString() + ";";
                    }

                    file += "\t\n";
                }
                StreamWriter wr = new StreamWriter(filePath, false, Encoding.GetEncoding(1251));
                wr.Write(file);
                wr.Close();
                MessageBox.Show("Файл успешно сохранен!", "Успешное сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string? GetPath(string filter)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = filter;
            if (dialog.ShowDialog() == DialogResult.Cancel)
                return null;
            return dialog.FileName;
        }
    }
}