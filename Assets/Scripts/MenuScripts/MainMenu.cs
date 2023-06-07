using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UIBehaviors
{
    public class MainMenu : MonoBehaviour
    {
        public static GameMode GameMode;

        // Start is called before the first frame update
        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
        }

        public void SinglePlayerButton_OnClick()
        {
            GameMode = GameMode.SinglePlayer;
            SwitchScene("GameScene");
        }

        public void MultiPlayerButton_OnClick()
        {
            SwitchScene("MultiPlayerMenuScene");
        }

        public void SettingsButton_OnClick()
        {
            SwitchScene("SettingsMenuScene");
        }

        public void ExitButton_OnClick()
        {
            CloseApplication();
        }

        public static void SwitchScene(string nextScene)
        {
            SceneManager.LoadScene(nextScene);
        }

        private static void CloseApplication()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}