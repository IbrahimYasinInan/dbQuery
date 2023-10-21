using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace fudhgjvkc
{
    public partial class Form1 : Form
    {

        

        OpenFileDialog QueryFile;
        string filename = "";
        
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }


        private void queryFile_Click(object sender, EventArgs e)
        {
            QueryFile = new OpenFileDialog(); // OpenFileDialog nesnesini başlat
            QueryFile.Multiselect = false;

            DialogResult result = QueryFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                filename = QueryFile.FileName; // Dosya adını 'filename' değişkenine atar
                label3.Text = filename;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string servername= dbServer.Text.Trim();
            string databasename = dbName.Text.Trim();
            string user = dbUser.Text.Trim();
            string password = dbPassword.Text.Trim();

            connect = new SqlConnection($"Data Source={servername};Initial Catalog={databasename};User ID={user};Password={password}");
            command = new SqlCommand();
            connect.Open();

           

            string queryFile = filename;
            string[] queries = File.ReadAllLines(queryFile);

            foreach (string query in queries)
            {
                if (!string.IsNullOrWhiteSpace(query))
                {
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        try
                        {
                            int executedQuery= command.ExecuteNonQuery();
                            
                            listBox1.Items.Add("Başarılı: " + query);

                            listBox2.Items.Add($"Sorgu Sonucu ({executedQuery} Satır Etkilendi): {query}");
                        }
                        catch (Exception ex)
                        {
                            // Sorgu çalıştırılırken hata oluştu
                            listBox1.Items.Add("Hata: " + query + " - " + ex.Message);

                            listBox2.Items.Add($"Hata: {query} - {ex.Message}");
                        }
                    }
                }
            }
        }
    }
}
