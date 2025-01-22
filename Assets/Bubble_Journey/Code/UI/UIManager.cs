using MrSanmiAndNAwakening.BubbleJourney;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MrSanmiAndNAwakening.BubbleJourney
{
    public class UIManager : MonoBehaviour
    {
        #region References

        public static UIManager instance;

        [SerializeField] protected GameObject _gamePanel;
        [SerializeField] protected GameObject _defeatPanel;
        [SerializeField] protected GameObject _pausePanel;
        [SerializeField] protected TextMeshProUGUI _hpNarrator;
        [SerializeField] protected BJ_MobileInputHandler _mobileInputHandler;

        #endregion

        #region RuntimeVariables

        #endregion

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(this);
            }
        }

        private void Start()
        {
            _gamePanel.SetActive(true);
            _defeatPanel.gameObject.SetActive(false);
            //_hpNarrator.text = _gameReferee.GetHealthPoints.ToString();
        }

        public void ActivateDefeatPanel()
        {
            _gamePanel.gameObject.SetActive(false);
            _defeatPanel.gameObject.SetActive(true);
        }

        public void ActivateAndDeactivatePausePanel(bool pausePanelBool)
        {
            switch (pausePanelBool)
            {
                case true:
                    _gamePanel.gameObject.SetActive(false);
                    _pausePanel.gameObject.SetActive(true);
                    break;
                case false:
                    _gamePanel.gameObject.SetActive(true);
                    _pausePanel.gameObject.SetActive(false);
                    break;
            }
        }

        public void UpdatePlayerLife (int playerHP)
        {
            _hpNarrator.text = playerHP.ToString();
        }
    }
}

