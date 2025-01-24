using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MrSanmiAndNAwakening.BubbleJourney
{
    public class BJ_MobileInputHandler : MobileInputHandler
    {
        #region References

        [SerializeField] protected PlayerInput _playerInput;
        [SerializeField] protected PlayersAvatar _avatar;

        #endregion

        #region RuntimeVariables

        #endregion

        #region UnityMethods

        void Start()
        {
            InitializeMobileInputHandler();
            _playerInput = GetComponent<PlayerInput>();
            transform.parent = _avatar.transform;
            transform.localPosition = Vector2.zero;
        }

        private void FixedUpdate()
        {

        }

        #endregion

        #region LocalMethods

        #endregion

        #region HandleRotationActions

        #endregion HandleRotationActions

        #region InputCallbackthMethods
        public void OnMove(InputAction.CallbackContext value)
        {
            Debug.Log(gameObject.name + "Controller Input Handler - OnMove()");
            _avatar.OnMOVE(value);
        }

        public void OnRotate(InputAction.CallbackContext value)
        {
            _avatar.OnROTATE(value);
        }

        public void OnPause(InputAction.CallbackContext value)
        {
            _avatar.OnPAUSE(value);
        }

        #endregion

        #region Corroutines

        #endregion
    }
}