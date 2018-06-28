using EfficientCareLookUp.Data;
using EfficientCareLookUp.Database;
using EfficientCareLookUp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfficientCareLookUp.Forms
{
    public partial class MainForm : Form
    {
        private Postgres postgres;
        private OracleDB oracle;
        private LookUp lookup;

        public MainForm(Postgres postgres, OracleDB oracle)
        {
            this.postgres = postgres;
            this.oracle = oracle;
            lookup = new LookUp(postgres, oracle);

            InitializeComponent();

            if(Properties.Settings.Default.LOAD_KITS_ON_START)
                LoadEFCKitNumbers();

            LoosePieceSearch lps = new LoosePieceSearch(postgres, oracle, lookup);
            BundleSearch bs = new BundleSearch(postgres, oracle, lookup);

            lps.Dock = DockStyle.Fill;
            bs.Dock = DockStyle.Fill;

            mainForTabControl.TabPages[0].Controls.Add(bs);
            mainForTabControl.TabPages[1].Controls.Add(lps);

        }

        private void LoadEFCKitNumbers()
        {
            DataTable dt = postgres.execute(Properties.Settings.Default.EFFICIENT_CARE_KIT_NUMBERS_QUERY);

            List<string> knumbers = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                knumbers.Add(row[0].ToString());
            }

            Form temp = new Form();
            LoadingPrompt lp = new LoadingPrompt(knumbers);

            temp.Text = "Loading...";
            temp.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            temp.Size = new Size(371, 80);
            temp.StartPosition = FormStartPosition.CenterScreen;
            temp.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            lp.Dock = DockStyle.Fill;
            temp.Controls.Add(lp);

            temp.Show();
            lp.Run();
            temp.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadEFCKitNumbers();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            postgres.CloseConnection();
            oracle.CloseConnection();
            this.Close();
        }
    }
}
