using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EfficientCareLookUp.UserControls
{
    public partial class LoadingPrompt : UserControl
    {
        private List<string> prompts;

        public LoadingPrompt(List<string> prompts)
        {
            this.prompts = prompts;

            InitializeComponent();
        }

        public void Run()
        {
            progressBar.Maximum = prompts.Count;
            
            foreach(string s in prompts)
            {
                textBox.ResetText();

                progressBar.Value += 1;

                textBox.AppendText(string.Format("[{0} | {1}] {2}", progressBar.Value.ToString(), prompts.Count.ToString(), s));

                progressBar.Update();

                Thread.Sleep(100);
            }
        }

    }
}
