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
    public partial class LoosePieceSearch : UserControl
    {
        private Postgres postgres;
        private OracleDB oracle;
        private LookUp lookup;

        public LoosePieceSearch(Postgres postgres, OracleDB oracle, LookUp lookup)
        {
            this.postgres = postgres;
            this.oracle = oracle;
            this.lookup = lookup;

            InitializeComponent();

            toolStripComboBoxWarehouse.SelectedIndex = Properties.Settings.Default.DEFAULT_WAREHOUSE_INDEX;

        }

        private void search()
        {
            this.dgv.ClearSelection();
            this.dgv.DataSource = null;

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
                        this.dgv.DataSource = lookup.SearchComponents(toolStripTextBoxKitNumber.Text, toolStripComboBoxWarehouse.SelectedIndex);
                        this.dgv.Refresh();
                    }
                    catch
                    {
                        if ((Warehouse)toolStripComboBoxWarehouse.SelectedIndex == Warehouse.WARSAW)
                            MessageBox.Show("Could not any available product in (Warsaw)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if ((Warehouse)toolStripComboBoxWarehouse.SelectedIndex == Warehouse.SOUTHAVEN)
                            MessageBox.Show("Could not any available product in (Southaven)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if ((Warehouse)toolStripComboBoxWarehouse.SelectedIndex == Warehouse.ALL)
                            MessageBox.Show("Could not any available product", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            return;
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void toolStripTextBoxKitNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                search();
            }
        }
    }
}
