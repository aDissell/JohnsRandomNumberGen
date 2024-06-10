using System;
using System.Windows.Forms;

namespace RandomNumberGen
{
    public partial class CharacterStatGenerator : Form
    {
        public CharacterStatGenerator()
        {
            InitializeComponent();
        }
        private int RollStats() 
        {
            var dice = new Random();
            int stat;
            stat = dice.Next(1, 7);
            return stat;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ReturnedStat;
            ReturnedStat =(int) RollStats();
            Stat1.Text = ReturnedStat.ToString();
        }
    }
}
