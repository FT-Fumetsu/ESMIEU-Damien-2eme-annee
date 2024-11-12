using UnityEngine;
using UnityEngine.EventSystems;

namespace Menu
{
    public class PauseMenu : MonoBehaviour
    {
        [SerializeField] private KeyCode _openPauseMenu;
        [SerializeField] private KeyCode _backInMenu;
        [SerializeField] private GameObject _echapMenuGameObject;
        [SerializeField] private GameObject _optionsMenuGameObject;
        [SerializeField] private GameObject _inventoryMenuGameObject;

        [SerializeField] private GameObject _pauseFirstButtonGameObject, _optionsFirstButtonGameObject, _optionsClosedButtonGameObject, _inventoryFirstButtonGameObject, _inventoryClosedButtonGameObject;

        private void Start()
        {
            _echapMenuGameObject.SetActive(false);
            _optionsMenuGameObject.SetActive(false);
            _inventoryMenuGameObject.SetActive(false);
        }

        private void Update()
        {
            if (Input.GetKeyDown(_openPauseMenu))
            {
                if(!_echapMenuGameObject.activeInHierarchy)
                {
                    Debug.Log("Echap Menu false to true");
                    _echapMenuGameObject.SetActive(true);

                    //set a new selected object
                    EventSystem.current.SetSelectedGameObject(_pauseFirstButtonGameObject);
                }                
            }

            if (Input.GetKeyDown(_backInMenu))
            {
                if (_echapMenuGameObject.activeInHierarchy)
                {
                    Debug.Log("Echap Menu true to false");
                    _echapMenuGameObject.SetActive(false);
                }

                else if (_optionsMenuGameObject.activeInHierarchy)
                {
                    _optionsMenuGameObject.SetActive(false);
                    _echapMenuGameObject.SetActive(true);

                    //set a new selected object
                    EventSystem.current.SetSelectedGameObject(_optionsClosedButtonGameObject);
                }

                else if (_inventoryMenuGameObject.activeInHierarchy)
                {
                    _inventoryMenuGameObject.SetActive(false);
                    _echapMenuGameObject.SetActive(true);

                    //set a new selected object
                    EventSystem.current.SetSelectedGameObject(_inventoryClosedButtonGameObject);
                }
            }
        }

        public void OpenInventory()
        {
            _inventoryMenuGameObject.SetActive(true);
            _echapMenuGameObject.SetActive(false);

            //set a new selected object
            EventSystem.current.SetSelectedGameObject(_inventoryFirstButtonGameObject);
        }

        public void OpenOptions()
        {
            _optionsMenuGameObject.SetActive(true);
            _echapMenuGameObject.SetActive(false);

            //set a new selected object
            EventSystem.current.SetSelectedGameObject(_optionsFirstButtonGameObject);
        }
    }
}