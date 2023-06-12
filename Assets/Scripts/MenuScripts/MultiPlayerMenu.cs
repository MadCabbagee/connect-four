using UnityEngine;

namespace MenuScripts
{
    public class MultiPlayerMenu : MonoBehaviour
    {
        public void BackButton_OnClick()
        {
            MainMenu.GameMode = GameMode.None;
            MainMenu.SwitchScene("MainMenuScene");
        }

        public void LocalButton_OnClick()
        {
            MainMenu.GameMode = GameMode.LocalMultiplayer;
            MainMenu.SwitchScene("PlayerSetupScene");
        }

        public void OnlineButton_OnClick()
        {
            MainMenu.GameMode = GameMode.OnlineMultiplayer;
            MainMenu.SwitchScene("PlayerSetupScene");
        }
    }
}