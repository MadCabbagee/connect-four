using UnityEngine;

namespace SceneBehaviors
{
    public class SettingsMenu : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void BackButton_OnClick()
        {
            MainMenu.SwitchScene("MainMenuScene");
        }
    }
}
