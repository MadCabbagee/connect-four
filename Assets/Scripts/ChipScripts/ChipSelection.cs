using System;
using MenuScripts;
using UnityEngine;
using UnityEngine.Serialization;

namespace ChipScripts
{
    public class ChipSelection : MonoBehaviour
    {
        private bool _isSelected = false;
        private Transform _transform;
        public string color;
        private void Awake()
        {
            _transform = transform;
        }

        private void OnMouseDown()
        {
            ToggleSelection();
        }

        public void ToggleSelection()
        {
            Debug.Log("Mouse Down");

            var parent = _transform.parent;
            var siblingChips = parent.GetComponentsInChildren<ChipSelection>();

            // Deselect all sibling chips
            foreach (var chip in siblingChips)
            {
                if (chip != this && chip._isSelected)
                {
                    chip._isSelected = false;
                    chip.transform.localScale /= 1.25f;
                }
            }

            _isSelected = !_isSelected;

            if (_isSelected)
            {
                _transform.localScale *= 1.25f; // Increase scale when selected
            }
            else
            {
                _transform.localScale /= 1.25f; // Reset scale when deselected
            }
        }
    }
}
