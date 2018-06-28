using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EfficientCareLookUp.Database;
using EfficientCareLookUp.Data;

namespace EfficientCareLookUp.UserControls
{
    public partial class BundleSearch : UserControl
    {
        private Postgres postgres;
        private OracleDB oracle;
        private LookUp lookup;

        public BundleSearch(Postgres postgres, OracleDB oracle, LookUp lookup)
        {
            this.postgres = postgres;
            this.oracle = oracle;
            this.lookup = lookup;

            InitializeComponent();
        }

        private void search()
        {
            this.dgv.ClearSelection();
            this.dgv.DataSource = null;

            if (string.IsNullOrEmpty(toolStripTextBoxBundleSearch.Text) || string.IsNullOrWhiteSpace(toolStripTextBoxBundleSearch.Text))
            {
                MessageBox.Show("You didn't enter anything!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (!lookup.CheckBundleNumber(toolStripTextBoxBundleSearch.Text))
                    MessageBox.Show("Could not find bundle " + toolStripTextBoxBundleSearch.Text, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        this.dgv.DataSource = lookup.SearchKits(toolStripTextBoxBundleSearch.Text);
                        this.dgv.Refresh();

                        foreach (DataGridViewRow dgvr in this.dgv.Rows)
                        {
                            if (Convert.ToInt32(dgvr.Cells[1].Value) == 0 && Convert.ToInt32(dgvr.Cells[2].Value) == 0)
                            {
                                dgvr.DefaultCellStyle.BackColor = Color.LightCoral;
                            }
                            else if (Convert.ToInt32(dgvr.Cells[1].Value) == 0 && Convert.ToInt32(dgvr.Cells[2].Value) > 0)
                            {
                                dgvr.DefaultCellStyle.BackColor = Color.Khaki;
                            }
                            else if (Convert.ToInt32(dgvr.Cells[1].Value) >= 1)
                            {
                                dgvr.DefaultCellStyle.BackColor = Color.PaleGreen;
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Could not find kits from bundle " + toolStripTextBoxBundleSearch.Text + ".", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void toolStripTextBoxBundleSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                search();
            }
        }
    }
}
