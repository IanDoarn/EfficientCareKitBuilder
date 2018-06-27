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

            toolStripComboBoxWarehouse.SelectedIndex = 0;

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


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection();
            this.dataGridView1.DataSource = null;
            
            if (string.IsNullOrEmpty(toolStripTextBoxKitNumber.Text) || string.IsNullOrWhiteSpace(toolStripTextBoxKitNumber.Text))
            {
                MessageBox.Show("You didn't enter anything!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (!lookup.CheckKitNumber(toolStripTextBoxKitNumber.Text))
                    MessageBox.Show("Could not find kit number " + toolStripTextBoxKitNumber.Text, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        this.dataGridView1.DataSource = lookup.Search(toolStripTextBoxKitNumber.Text, toolStripComboBoxWarehouse.SelectedIndex);
                        this.dataGridView1.Refresh();
                    }
                    catch
                    {
                        if (toolStripComboBoxWarehouse.SelectedIndex == 0)
                            MessageBox.Show("Could not any available product in (Warsaw)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (toolStripComboBoxWarehouse.SelectedIndex == 1)
                            MessageBox.Show("Could not any available product in (Southaven)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (toolStripComboBoxWarehouse.SelectedIndex == 3)
                            MessageBox.Show("Could not any available product", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            return;
                    }
                }
            }
        }    
    }
}
