namespace Ultimate_clicker_game
{
    partial class IndexPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.richTextBoxIndex = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxIndex
            // 
            this.richTextBoxIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxIndex.ReadOnly = true;
            this.richTextBoxIndex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.richTextBoxIndex.Text =
@"📖 INDEX – What Your Stats Do

💰 Cash – Used to purchase upgrades
🖱️ CPC – How much cash per click
🔼 Multiplier – Increases CPC
♻️ Rebirth – Boosts multiplier effectiveness
✨ Ultra Rebirth – Boosts rebirth effectiveness
🌟 Prestige – Boosts ultra effectiveness
💎 Mega Multi – Boosts prestige effectiveness
🚀 Ascension – Boosts all tiers below
🎮 Level – XP-based bonus system";
            // 
            // IndexPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 520);
            this.Controls.Add(this.richTextBoxIndex);
            this.Name = "IndexPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Index / Help";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox richTextBoxIndex;
    }
}
