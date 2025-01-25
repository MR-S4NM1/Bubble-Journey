using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MrSanmiAndNAwakening.BubbleJourney
{
    [CreateAssetMenu(menuName = "BubbleJourney/Input")]
    public class InputSO : ScriptableObject
    {
        [SerializeField] public bool usingGyroscope;

        public void ChangeInpt()
        {
            usingGyroscope = !usingGyroscope;
        }
    }
}
