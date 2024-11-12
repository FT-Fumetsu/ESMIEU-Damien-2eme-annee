using UnityEngine;
using UnityEngine.EventSystems;

namespace Menu
{
    public class PauseMenu : MonoBehaviour
    {
        [SerializeField] private KeyCode _openPauseMenuBackInMenu;
        [SerializeField] private GameObject _pauseMenuGameObject;
        [SerializeField] private GameObject _optionsMenuGameObject;
        [SerializeField] private GameObject _inventoryMenuGameObject;

        [SerializeField] private GameObject _pauseFirstButtonGameObject, _optionsFirstButtonGameObject, _optionsClosedButtonGameObject, _inventoryFirstButtonGameObject, _inventoryClosedButtonGameObject;

        private void Start()
        {
            _pauseMenuGameObject.SetActive(false);
            _optionsMenuGameObject.SetActive(false);
            _inventoryMenuGameObject.SetActive(false);
        }

        private void Update()
        {
            if (Input.GetKeyDown(_openPauseMenuBackInMenu))
            {
                if (_pauseMenuGameObject.activeInHierarchy)
                {
                    Debug.Log("Echap Menu true to false");
                    _pauseMenuGameObject.SetActive(false);
                }

                else if (_optionsMenuGameObject.activeInHierarchy)
                {
                    _optionsMenuGameObject.SetActive(false);
                    _pauseMenuGameObject.SetActive(true);

                    //set a new selected object
                    EventSystem.current.SetSelectedGameObject(_optionsClosedButtonGameObject);
                }

                else if (_inventoryMenuGameObject.activeInHierarchy)
                {
                    _inventoryMenuGameObject.SetActive(false);
                    _pauseMenuGameObject.SetActive(true);

                    //set a new selected object
                    EventSystem.current.SetSelectedGameObject(_inventoryClosedButtonGameObject);
                }

                else 
                {
                    Debug.Log("Echap Menu false to true");
                    _pauseMenuGameObject.SetActive(true);

                    //set a new selected object
                    EventSystem.current.SetSelectedGameObject(_pauseFirstButtonGameObject);
                }                
            }
        }

        public void OpenInventory()
        {
            _inventoryMenuGameObject.SetActive(true);
            _pauseMenuGameObject.SetActive(false);

            //set a new selected object
            EventSystem.current.SetSelectedGameObject(_inventoryFirstButtonGameObject);
        }

        public void OpenOptions()
        {
            _optionsMenuGameObject.SetActive(true);
            _pauseMenuGameObject.SetActive(false);

            //set a new selected object
            EventSystem.current.SetSelectedGameObject(_optionsFirstButtonGameObject);
        }
    }
}