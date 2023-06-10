using UnityEngine;

namespace ChipScripts
{
    public class ChipSelection : MonoBehaviour
    {
            
        public Transform chipIcon;
        private bool _isSelected = false;

        public void OnMouseUp()
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
