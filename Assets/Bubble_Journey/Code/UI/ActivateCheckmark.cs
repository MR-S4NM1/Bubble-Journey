using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MrSanmiAndNAwakening.BubbleJourney
{
    public class ActivateCheckmark : MonoBehaviour
    {
        #region References

        [SerializeField] InputSO _inputSO;
        [SerializeField] GameObject _checkmark;

        #endregion

        #region UnityMethods

        private void Start()
        {
            if (_inputSO.usingGyroscope)
            {
                _checkmark.SetActive(true);
            }
            else
            {
                _checkmark.SetActive(false);
            }
        }

        #endregion

        #region PublicMethods

        public void Checkmark()
        {
            if (_inputSO.usingGyroscope)
            {
                _checkmark.SetActive(true);
            }
            else
            {
                _checkmark.SetActive(false);
            }
        }

        #endregion
    }
}