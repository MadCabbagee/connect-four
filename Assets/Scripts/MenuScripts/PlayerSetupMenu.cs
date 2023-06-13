using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace MenuScripts
{
    public class PlayerSetupMenu : MonoBehaviour
    {
        [SerializeField] private GameObject playerOneSettings;
        [SerializeField] private GameObject playerTwoSettings;
        public static string PlayerOneSelection;
        public static string PlayerTwoSelection;
        
        private string _lastMenu;
        private void OnEnable()
        {
            
            switch (MainMenu.GameMode)
            {
                default:
                    ShowMainMenu();
                    break;
                
                case GameMode.None:
                    ShowMainMenu();
                    break;
                
                case GameMode.SinglePlayer:
                    _lastMenu = "MainMenuScene";
                    ShowSettings(true);
                    break;
                
                case GameMode.LocalMultiplayer:
                    _lastMenu = "MultiPlayerMenuScene";
                    ShowSettings(false);
                    break;
                
                case GameMode.OnlineMultiplayer:
                    _lastMenu = "MultiPlayerMenuScene";
                    ShowSettings(true);
                    break;
            }
        }

        private void ShowSettings(bool showOnlyOne)
        {
            if (showOnlyOne)
            {
                playerOneSettings.SetActive(true);
                playerTwoSettings.SetActive(false);
            }
            else
            {
                playerOneSettings.SetActive(true);
                playerTwoSettings.SetActive(true);
            }
        }

        private static void ShowMainMenu()
        {
            MainMenu.SwitchScene("MainMenuScene");
        }

        public void BackButton_OnClick()
        {
            MainMenu.SwitchScene(_lastMenu);
            MainMenu.GameMode = GameMode.None;
        }

        public void PlayButton_OnClick()
        {
            // todo: check that both players have chosen a chip and also have not chosen the same one.
            MainMenu.SwitchScene("GameScene");
        }
    }
}

