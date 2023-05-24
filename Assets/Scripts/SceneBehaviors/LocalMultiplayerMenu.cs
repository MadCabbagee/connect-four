using UnityEngine;
using UnityEngine.UI;

namespace SceneBehaviors
{
    public class LocalMultiplayerMenu : MonoBehaviour
    {
        [SerializeField] private Slider redSliderPlayer1;
        [SerializeField] private Slider greenSliderPlayer1;
        [SerializeField] private Slider blueSliderPlayer1;
        [SerializeField] private Image colorImagePlayer1;

        [SerializeField] private Slider redSliderPlayer2;
        [SerializeField] private Slider greenSliderPlayer2;
        [SerializeField] private Slider blueSliderPlayer2;
        [SerializeField] private Image colorImagePlayer2;

        private void Start()
        {
            redSliderPlayer1.onValueChanged.AddListener(UpdateColorPlayer1);
            greenSliderPlayer1.onValueChanged.AddListener(UpdateColorPlayer1);
            blueSliderPlayer1.onValueChanged.AddListener(UpdateColorPlayer1);

            redSliderPlayer2.onValueChanged.AddListener(UpdateColorPlayer2);
            greenSliderPlayer2.onValueChanged.AddListener(UpdateColorPlayer2);
            blueSliderPlayer2.onValueChanged.AddListener(UpdateColorPlayer2);
        }

        private void UpdateColorPlayer1(float value)
        {
            Color selectedColor = new Color(redSliderPlayer1.value, greenSliderPlayer1.value, blueSliderPlayer1.value);
            colorImagePlayer1.color = selectedColor;
        }

        private void UpdateColorPlayer2(float value)
        {
            Color selectedColor = new Color(redSliderPlayer2.value, greenSliderPlayer2.value, blueSliderPlayer2.value);
            colorImagePlayer2.color = selectedColor;
        }

        public void BackButton_OnClick()
        {
            MainMenu.SwitchScene("MultiPlayerMenuScene");
        }

        public void PlayButton_OnClick()
        {
            
        }
    }
}

