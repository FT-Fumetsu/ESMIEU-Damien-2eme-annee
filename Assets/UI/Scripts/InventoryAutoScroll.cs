using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Menu
{
    public class ScrollViewBehaviour : MonoBehaviour
    {
        [SerializeField] private ScrollRect _scrollRect;
        [SerializeField] private RectTransform _content;

        private void Update()
        {
            for (int i = 0; i < _content.childCount; i++)
            {
                GameObject item = _content.GetChild(i).gameObject;
                if (EventSystem.current.currentSelectedGameObject == item)
                {
                    float normalizedPosition = 1 - (float)i / (_content.childCount - 1);
                    _scrollRect.verticalNormalizedPosition = normalizedPosition;
                }
            }
        }
    }
}