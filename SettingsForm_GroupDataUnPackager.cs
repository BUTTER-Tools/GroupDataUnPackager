using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GroupDataUnPackager
{
    internal partial class SettingsForm_GroupDataUnPackager : Form
    {


        #region Get and Set Options

        public bool aggregateText { get; set; }


       #endregion



        public SettingsForm_GroupDataUnPackager(bool aggText)
        {
            InitializeComponent();

            if (aggText)
            {
                AggregateTextRadioButton.Checked = true;
            }
            else
            {
                SeparateTurnsRadioButton.Checked = true;
            }



        }






        

        private void OKButton_Click(object sender, System.EventArgs e)
        {


            if (AggregateTextRadioButton.Checked)
            {
                aggregateText = true;
            }
            else
            {
                aggregateText = false;
            }


            this.DialogResult = DialogResult.OK;
        }
    }
}
