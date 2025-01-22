using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MrSanmiAndNAwakening.BubbleJourney
{
    public class MobileInputHandler : MonoBehaviour
    {
        #region UnityMethods

        void Start()
        {
            InitializeMobileInputHandler();
        }

        void Update()
        {

        }

        #endregion

        #region LocalMethods

        protected void InitializeMobileInputHandler()
        {
            //UNITY_STANDALONE_WIN
            #if UNITY_ANDROID && !UNITY_EDITOR
                InputSystem.EnableDevice(UnityEngine.InputSystem.Gyroscope.current);
                InputSystem.EnableDevice(UnityEngine.InputSystem.LinearAccelerationSensor.current);
            #endif
        }

        #endregion
    }
}