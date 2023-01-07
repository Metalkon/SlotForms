namespace SlotForms
{
    public partial class Form1 : Form
    {
        public int playerCash = 0;
        public int playerBid = 0;
        public int playerFreeSpins = 0;
        public Form1()
        {
            InitializeComponent();
            // -------------------
            labelCash.Text = $"Cash: {playerCash}";
            labelBid.Text = $"Bid: {playerBid}";
            labelFreeSpins.Text = $"Free Spins: {playerFreeSpins}";

        }
        

        private void playerSpin_Click(object sender, EventArgs e)
        {
            ++playerCash;
            labelCash.Text = $"Cash: {playerCash}";
        }
    }
}