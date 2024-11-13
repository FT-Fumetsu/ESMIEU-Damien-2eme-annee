using UnityEngine;
using UnityEngine.InputSystem;

namespace Input
{
    public class SwitchActionMap : MonoBehaviour
    {
        [SerializeField] private PlayerInput _playerInput;

        public void SwitchOnUIActionMap(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                _playerInput.actions.FindActionMap("MenuInput").Enable();
                _playerInput.actions.FindActionMap("Player").Disable();
            }
        }

        public void SwitchOnPlayerActionMap()
        {
            _playerInput.actions.FindActionMap("MenuInput").Disable();
            _playerInput.actions.FindActionMap("Player").Enable();
        }
    }
}