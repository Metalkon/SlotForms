using System.Security.Cryptography;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SlotForms
{
    public partial class Form1 : Form
    {
        public int playerCash;
        public int playerBid;
        public int playerFreeSpins;

        private List<int> col1 = new List<int> { 1, 2, 3 };
        private List<int> col2 = new List<int> { 1, 2, 3 };
        private List<int> col3 = new List<int> { 1, 2, 3 };
        private List<int> col4 = new List<int> { 1, 2, 3 };
        private List<int> col5 = new List<int> { 1, 2, 3 };
        Random randomNumber = new Random();
        Dictionary<int, Image> imageMap;


        public Form1()
        {
            InitializeComponent();
            // -------------------
            InitializeImageMap();
            UpdateLabels();
            UpdateSlotImg();
        }


        private async void playerSpin_Click(object sender, EventArgs e)
        {
            await Spin();
            UpdateLabels();
        }


        public void UpdateLabels()
        {
            labelCash.Text = $"Cash: {playerCash}";
            labelBid.Text = $"Cash: {playerBid}";
            labelFreeSpins.Text = $"Cash: {playerFreeSpins}";
        }

        public void UpdateSlotImg()
        {
            imgSlot_a1.Image = imageMap[col1[0]];
            imgSlot_b1.Image = imageMap[col1[1]];
            imgSlot_c1.Image = imageMap[col1[2]];

            imgSlot_a2.Image = imageMap[col2[0]];
            imgSlot_b2.Image = imageMap[col2[1]];
            imgSlot_c2.Image = imageMap[col2[2]];

            imgSlot_a3.Image = imageMap[col3[0]];
            imgSlot_b3.Image = imageMap[col3[1]];
            imgSlot_c3.Image = imageMap[col3[2]];

            imgSlot_a4.Image = imageMap[col4[0]];
            imgSlot_b4.Image = imageMap[col4[1]];
            imgSlot_c4.Image = imageMap[col4[2]];

            imgSlot_a5.Image = imageMap[col5[0]];
            imgSlot_b5.Image = imageMap[col5[1]];
            imgSlot_c5.Image = imageMap[col5[2]];
        }
        private void InitializeImageMap()
        {
            imageMap = new Dictionary<int, Image>
            {
                { 1, Image.FromFile(@"../../../Img/Symbol_Apple.png") },
                { 2, Image.FromFile(@"../../../Img/Symbol_Orange.png") },
                { 3, Image.FromFile(@"../../../Img/Symbol_Banana.png") },
                { 4, Image.FromFile(@"../../../Img/Symbol_Cherry.png") },
                { 5, Image.FromFile(@"../../../Img/Symbol_Lemon.png") },
                { 6, Image.FromFile(@"../../../Img/Symbol_Diamond.png") },
                { 7, Image.FromFile(@"../../../Img/Symbol_Buddy.png") },
                { 8, Image.FromFile(@"../../../Img/Symbol_Pebbles.png") },
                { 9, Image.FromFile(@"../../../Img/Symbol_Smokey.png") },
                { 10, Image.FromFile(@"../../../Img/Symbol_Wedding.png") }
            };
        }

        private int GenerateRandomNumber(List<int> list)
        {
            int newNumber;
            do
            {
                newNumber = randomNumber.Next(1, 11);
            } while (list.Contains(newNumber));
            return newNumber;
        }

        // spin should randomly generate icons (not last 3 used) at the top and move them to the rows below before stopping for spin effect
        public async Task Spin()
        {
            for (int i = 0; i < 10; i++)
            {
                await Spin1();
            }
            for (int i = 0; i < 8; i++)
            {
                await Spin2();
            }
            for (int i = 0; i < 6; i++)
            {
                await Spin3();
            }
            for (int i = 0; i < 4; i++)
            {
                await Spin4();
            }
            for (int i = 0; i < 2; i++)
            {
                await Spin5();
            }
        }
        public async Task Spin1()
        {
            col1.Insert(0, GenerateRandomNumber(col1));
            col2.Insert(0, GenerateRandomNumber(col2));
            col3.Insert(0, GenerateRandomNumber(col3));
            col4.Insert(0, GenerateRandomNumber(col4));
            col5.Insert(0, GenerateRandomNumber(col5));
            col1.Remove(col1.Last());
            col2.Remove(col2.Last());
            col3.Remove(col3.Last());
            col4.Remove(col4.Last());
            col5.Remove(col5.Last());
            UpdateSlotImg();
            await Task.Delay(100);
        }
        public async Task Spin2()
        {
            col2.Insert(0, GenerateRandomNumber(col2));
            col3.Insert(0, GenerateRandomNumber(col3));
            col4.Insert(0, GenerateRandomNumber(col4));
            col5.Insert(0, GenerateRandomNumber(col5));
            col2.Remove(col2.Last());
            col3.Remove(col3.Last());
            col4.Remove(col4.Last());
            col5.Remove(col5.Last());
            UpdateSlotImg();
            await Task.Delay(100);
        }
        public async Task Spin3()
        {
            col3.Insert(0, GenerateRandomNumber(col3));
            col4.Insert(0, GenerateRandomNumber(col4));
            col5.Insert(0, GenerateRandomNumber(col5));
            col3.Remove(col3.Last());
            col4.Remove(col4.Last());
            col5.Remove(col5.Last());
            UpdateSlotImg();
            await Task.Delay(100);
        }
        public async Task Spin4()
        {
            col4.Insert(0, GenerateRandomNumber(col4));
            col5.Insert(0, GenerateRandomNumber(col5));
            col4.Remove(col4.Last());
            col5.Remove(col5.Last());
            UpdateSlotImg();
            await Task.Delay(100);
        }
        public async Task Spin5()
        {
            col5.Insert(0, GenerateRandomNumber(col5));
            col5.Remove(col5.Last());
            UpdateSlotImg();
            await Task.Delay(100);
        }
    }
}