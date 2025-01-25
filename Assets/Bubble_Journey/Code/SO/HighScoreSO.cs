using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MrSanmiAndNAwakening.BubbleJourney
{
    [CreateAssetMenu(menuName = "BubbleJourney/HighScore")]
    public class HighScoreSO : ScriptableObject
    {
        [SerializeField] public int highScore;
    }
}