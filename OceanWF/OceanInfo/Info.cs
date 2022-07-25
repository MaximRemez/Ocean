using System;
using System.Windows.Forms;

namespace OceanWF.OceanInfo
{
    public partial class Info : Form
    {
        bool isEnglish = true;

        public Info()
        {
            InitializeComponent();
        }

        private void languageButton_Click(object sender, EventArgs e)
        {
            SetLanguage();
        }

        private void SetLanguage()
        {
            if (isEnglish == true)
            {
                preyInfoLabel.Text = "Здобич запливає в порожні клітини і розмножується кожні 6 ітерацій";
                predatorInfoLabel.Text = "Хижак з'їдає здобич і гине, якщо не з'їсть протягом 6 ітерацій. Також розмножується кожну 6-ту ітерацію";
                obstacleInfoLabel.Text = "Перешкодою є восьминіг. Він не рухається і кожні 15 ітерацій вдаряє щупальцями";
                rimuruInfoLabel.Text = "Риба-Рімуру може з'їсти будь-кого. Вона не розмножується і може загинути тільки від щупалець";

                languageButton.Text = "Eng";
                isEnglish = false;
            }

            else if (isEnglish == false)
            {
                preyInfoLabel.Text = "Prey swims into empty cells and breeds every 6 iterations";
                predatorInfoLabel.Text = "The predator eats the prey and dies if it doesn't eat in 6 iterations. Also divided every 6th iteration";
                obstacleInfoLabel.Text = "The obstacle is the octopus. He does not move and every 15 iterations he strikes with tentacles";
                rimuruInfoLabel.Text = "Rimuru fish can eat anyone. It does not reproduce and can die only from tentacles";

                languageButton.Text = "Ua";
                isEnglish = true;
            }

        }
    }
}
