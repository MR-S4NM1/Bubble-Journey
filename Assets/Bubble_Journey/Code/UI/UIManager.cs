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
        [SerializeField] protected TextMeshProUGUI _currentScore;
        [SerializeField] protected TextMeshProUGUI _finalScore;
        [SerializeField] protected TextMeshProUGUI _HighScore;
        [SerializeField] protected GameObject _newHighScore;
        [SerializeField] protected BJ_MobileInputHandler _mobileInputHandler;

        #endregion

        #region RuntimeVariables

        #endregion

        #region UnityMethods

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
            _currentScore.text = "0";
        }

        #endregion

        #region PublicMethods

        public void ActivateDefeatPanel()
        {
            _gamePanel.gameObject.SetActive(false);
            _defeatPanel.gameObject.SetActive(true);
            GameManager.instance.StartGame = false;
            _finalScore.text = _currentScore.text;
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

        public void UpdateScore (int score)
        {
            _currentScore.text = "Score:" + score.ToString();
        }

        #endregion
    }
}

