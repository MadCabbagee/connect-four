using UnityEngine;

namespace UIBehaviors
{
    public class MultiPlayerMenu : MonoBehaviour
    {
        public void BackButton_OnClick()
        {
            MainMenu.SwitchScene("MainMenuScene");
        }

        public void LocalButton_OnClick()
        {
            MainMenu.SwitchScene("LocalMultiplayerMenuScene");
            MainMenu.GameMode = GameMode.LocalMultiplayer;
        }

        public void OnlineButton_OnClick()
        {
            MainMenu.SwitchScene("OnlineMultiplayerMenuScene");
            MainMenu.GameMode = GameMode.OnlineMultiplayer;
        }
    }
}