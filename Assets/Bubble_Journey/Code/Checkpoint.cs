using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MrSanmiAndNAwakening.BubbleJourney
{
    public class Checkpoint : MonoBehaviour
    {
        #region UnityMethods

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                GameManager.instance.UpdateSpeed();
                GameManager.instance.ChooseNextSegment();
            }
        }

        #endregion
    }
}
