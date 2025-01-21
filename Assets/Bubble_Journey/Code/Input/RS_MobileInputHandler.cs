using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace MrSanmiAndNAwakening.BubbleJourney
{
    public class RS_MobileInputHandler : MobileInputHandler
    {
        #region References

        [SerializeField] protected Camera _camera;

        [Header("Sliders")]
        [SerializeField] protected Slider _rotateXSlider;
        [SerializeField] protected Slider _rotateYSlider;

        #endregion

        #region RuntimeVariables

        protected float _currentSliderXValue;
        protected float _currentSliderYValue;
        protected float _previousSliderXValue;
        protected float _previousSliderYValue;
        protected float _deltaSliderXValue;
        protected float _deltaSliderYValue;

        #endregion

        #region PublicMehtods

        public void HandleRotateXSlider()
        {
            //switch (_gameReferee.GameState)
            //{
            //    case RS_GameStates.FLICK_TOKEN_BY_PLAYER: //manage the flags
            //        HandleRotationInFlickTokenByPlayerX(_rotateXSlider.value);
            //        break;
            //}
        }

        public void HandleRotateYSlider()
        {
            //switch (_gameReferee.GameState)
            //{
            //    case RS_GameStates.FLICK_TOKEN_BY_PLAYER: //manage the flags
            //        HandleRotationInFlickTokenByPlayerY(_rotateYSlider.value);
            //        break;
            //}
        }
        #endregion

        #region UnityMethods

        void Start()
        {
            InitializeMobileInputHandler();
        }

        private void FixedUpdate()
        {

        }

        #endregion

        #region LocalMethods

        #endregion

        #region HandleRotationActions

        //protected void HandleRotationInFlickTokenByPlayer(InputAction.CallbackContext value)
        //{
        //    if (value.performed)
        //    {
        //        _gameReferee.GetCurrentFlag.transform.Rotate(
        //        new Vector3((value.ReadValue<Vector3>() != null ? 
        //        value.ReadValue<Vector3>().x : value.ReadValue<Vector2>().x) * 
        //        -4f, 0f, 0f), Space.Self);
        //    }
        //    else if (value.canceled)
        //    {

        //    }
        //}

        protected void HandleRotationInFlickTokenByPlayerX(float value)
        {
            //_currentSliderXValue = value;
            //_deltaSliderXValue = _currentSliderXValue - _previousSliderXValue;
            //_gameReferee.GetCurrentFlag.transform.Rotate(
            //new Vector3(
            //        0f,                             //Y
            //        _deltaSliderXValue * -4f,                    //X
            //        0f                              //Z
            //    ),
            //    Space.Self //localRotation
            //);
            //_previousSliderXValue = _currentSliderXValue;
        }

        protected void HandleRotationInFlickTokenByPlayerY(float value)
        {
            //_gameReferee.GetCurrentFlag.transform.Rotate(
            //new Vector3(
            //        value * -4f,                             //Y
            //        0f,                    //X
            //        0f                              //Z
            //    ),
            //    Space.Self //localRotation
            //);
            //_currentSliderYValue = value;
            //_deltaSliderYValue = _currentSliderYValue - _previousSliderYValue;
            //_gameReferee.GetCurrentFlag.transform.Rotate(
            //new Vector3(
            //        _deltaSliderYValue * -4f,                    //X
            //        0f,                             //Y
            //        0f                              //Z
            //    ),
            //    Space.Self //localRotation
            //);
            //_previousSliderYValue = _currentSliderYValue;
        }

        #endregion HandleRotationActions
    }
}