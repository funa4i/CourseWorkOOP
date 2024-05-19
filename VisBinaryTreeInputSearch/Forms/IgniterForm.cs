using VisBinaryTreeInputSearch.StarterPack;
using VisBinaryTreeInputSearch.Enums;

namespace VisBinaryTreeInputSearch.Forms
{
    public partial class IgniterForm : Form
    {
        public IgniterForm()
        {
            InitializeComponent();
            numericUpDownValue.Minimum = int.MinValue;
            numericUpDownValue.Maximum = int.MaxValue;
            Random random = new Random();
            numericUpDownValue.Value = random.Next(int.MinValue, int.MaxValue);
        }

        private event Action<Igniter>? _igniterSender;

        public void AddDelegate(Action<Igniter> ign)
        {
            _igniterSender = ign;
        }

        private void buttonSendIgniter_Click(object sender, EventArgs e)
        {
            _igniterSender?.Invoke(new Igniter(radioButtonFind.Checked ? EnumAct.Find : EnumAct.Insert, (int)numericUpDownValue.Value));
            Close();
        }
    }
}
