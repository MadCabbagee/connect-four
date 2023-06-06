using UnityEngine;
using UnityEngine.UI;

namespace UIBehaviors
{
    public class LocalMultiplayerMenu : MonoBehaviour
    {
        public void BackButton_OnClick()
        {
            MainMenu.SwitchScene("MultiPlayerMenuScene");
        }

        public void PlayButton_OnClick()
        {
            
        }
    }
}

