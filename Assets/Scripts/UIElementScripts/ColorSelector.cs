using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UIElementScripts
{
    public class ColorSelector : MonoBehaviour
    {
        [SerializeField] private Slider redSlider;
        [SerializeField] private Slider greenSlider;
        [SerializeField] private Slider blueSlider;
        [SerializeField] private Image colorImage;
    
        // Start is called before the first frame update
        void Start()
        {
            redSlider.onValueChanged.AddListener(UpdateColorPlayer);
            greenSlider.onValueChanged.AddListener(UpdateColorPlayer);
            blueSlider.onValueChanged.AddListener(UpdateColorPlayer);
        }

        private void UpdateColorPlayer(float value)
        {
            Color selectedColor = new Color(redSlider.value, greenSlider.value, blueSlider.value);
            colorImage.color = selectedColor;
        }
    }
}
