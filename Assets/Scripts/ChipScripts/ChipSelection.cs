using UnityEngine;

namespace ChipScripts
{
    public class ChipSelection : MonoBehaviour
    {
            
        public Transform chipIcon;
        private bool _isSelected = false;

        /// <summary>
        ///     Enlarges image to indicate this chip is selected.
        /// </summary>
        public void ToggleSelection()
        {
            Debug.Log("Mouse Down");
            _isSelected = !_isSelected;
            if (_isSelected)
            {
                chipIcon.localScale *= 1.25f; // Increase scale when selected
            }
            else
            {
                chipIcon.localScale /= 1.25f; // Reset scale when deselected
            }
        }
    }
}
