using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MrSanmiAndNAwakening.BubbleJourney
{
    public class Checkpoint : MonoBehaviour
    {
        #region RunTimeVariable

        protected bool _activated;

        #endregion

        #region UnityMethods

        private void Awake()
        {
            _activated = false;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player") && !_activated)
            {
                GameManager.instance.UpdateSpeed();
                GameManager.instance.ChooseNextSegment();
                _activated = true;
            }
        }

        #endregion
    }
}
