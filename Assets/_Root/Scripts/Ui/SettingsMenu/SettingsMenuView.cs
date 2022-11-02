using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


namespace Ui
{
    internal class SettingsMenuView : MonoBehaviour
    {
        [SerializeField] private Button _buttonBackToMenu;


        public void Init(UnityAction backToMenu)
        {
            _buttonBackToMenu.onClick.AddListener(backToMenu);
        }

        public void OnDestroy()
        {
            _buttonBackToMenu.onClick.RemoveAllListeners();
        }
    }
}