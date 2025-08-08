
using System;
using System.Windows.Forms;

namespace Ultimate_clicker_game
{
    public partial class Form1 : Form
    {
        int xp = 0;
        int xpToNextLevel = 100;
        int playerLevel = 1;

        double cash = 0;
        double baseCashPerClick = 1;
        int multiplier = 1, rebirths = 0, ultraRebirths = 0, prestige = 0, megaMulti = 0, ascension = 0, levelPoints = 0;

        double multiplierCost = 25;
        int rebirthCost = 10, ultraRebirthCost = 5, prestigeCost = 3, megaMultiCost = 2, ascensionCost = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void progressBarXP_Click(object sender, EventArgs e)
        {

        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            IndexPage helpPage = new IndexPage();
            helpPage.Show();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            double clickValue = baseCashPerClick * CalculateTotalMultiplier();
            cash += clickValue;
            xp += 10; // XP per click (you can scale this)
            if (xp >= xpToNextLevel)
            {
                xp -= xpToNextLevel;
                levelPoints++;
                playerLevel++;
                xpToNextLevel += 50; // Increase requirement for next level
            }
            UpdateUI();
        }

        double CalculateTotalMultiplier()
        {
            return multiplier *
                   (1 + levelPoints * 0.01) *
                   (1 + rebirths * 0.15) *
                   (1 + ultraRebirths * 0.2) *
                   (1 + prestige * 0.3) *
                   (1 + megaMulti * 0.4) *
                   (1 + ascension * 0.5);
        }

        void UpdateUI()
        {
            CashLabel.Text = $"💰 Cash: {cash:F2}";
            CashPerClickLabel.Text = $"🖱️ Cash per Click: {baseCashPerClick * CalculateTotalMultiplier():F2}";
            Multiplier.Text = $"🔼 Multiplier: {multiplier} (Cost: {multiplierCost:F0})";
            Rebirth.Text = $"♻️ Rebirths: {rebirths} (Cost: {rebirthCost} Multiplier)";
            UltraRebirth.Text = $"✨ Ultra Rebirths: {ultraRebirths} (Cost: {ultraRebirthCost} Rebirth)";
            Prestige.Text = $"🌟 Prestige: {prestige} (Cost: {prestigeCost} Ultra)";
            MegaMulti.Text = $"💎 Mega Multi: {megaMulti} (Cost: {megaMultiCost} Prestige)";
            Ascension.Text = $"🚀 Ascension: {ascension} (Cost: {ascensionCost} Mega)";
            LevelLabel.Text = $"🎮 Level: {playerLevel} (Points: {levelPoints})";

            // after you set CashLabel / Multiplier / etc.
            progressBarXP.Maximum = xpToNextLevel;
            progressBarXP.Value = Math.Min(xp, xpToNextLevel);

            // preview the next level’s bonus (adjust text to your taste)
            NextLevelLabel.Text = $"Next Level Boost: +{(levelPoints + 1) * 1}% CPC base";


        }

        private void btnMultiplier_Click(object sender, EventArgs e)
        {
            if (cash >= multiplierCost)
            {
                cash -= multiplierCost;
                multiplier++;
                multiplierCost *= 2;
                UpdateUI();
            }
        }

        private void btnRebirth_Click(object sender, EventArgs e)
        {
            if (multiplier >= rebirthCost)
            {
                multiplier -= rebirthCost;
                rebirths++;
                rebirthCost += 5;
                UpdateUI();
            }
        }

        private void btnUltraRebirth_Click(object sender, EventArgs e)
        {
            if (rebirths >= ultraRebirthCost)
            {
                rebirths -= ultraRebirthCost;
                ultraRebirths++;
                ultraRebirthCost += 2;
                UpdateUI();
            }
        }

        private void btnPrestige_Click(object sender, EventArgs e)
        {
            if (ultraRebirths >= prestigeCost)
            {
                ultraRebirths -= prestigeCost;
                prestige++;
                prestigeCost += 2;
                UpdateUI();
            }
        }

        private void btnMegaMulti_Click(object sender, EventArgs e)
        {
            if (prestige >= megaMultiCost)
            {
                prestige -= megaMultiCost;
                megaMulti++;
                megaMultiCost++;
                UpdateUI();
            }
        }

        private void btnAscension_Click(object sender, EventArgs e)
        {
            if (megaMulti >= ascensionCost)
            {
                megaMulti -= ascensionCost;
                ascension++;
                ascensionCost++;
                UpdateUI();
            }
        }

        private void btnLevelBoost_Click(object sender, EventArgs e)
        {
            if (levelPoints >= 100)
            {
                levelPoints -= 100;
                baseCashPerClick += 2;
                UpdateUI();
            }
        }
    }
}
