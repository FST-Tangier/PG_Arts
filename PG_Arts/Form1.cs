using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using n = Npgsql;

namespace PG_Arts
{
    public partial class Form1 : Form
    {
        static String cnxStr = "server=localhost;port=5432;user id=postgres; password=zili; database=postgres";
        n.NpgsqlConnection cnx = new n.NpgsqlConnection(cnxStr);
        n.NpgsqlCommand cmd;
        n.NpgsqlDataAdapter ada;
        DataTable dt;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            ada.Fill(dt);
            grd.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmd = new n.NpgsqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM public.article";

            ada = new n.NpgsqlDataAdapter(cmd);
           
        }
    }
}
