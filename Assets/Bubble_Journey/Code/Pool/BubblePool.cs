using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace MrSanmiAndNAwakening.BubbleJourney
{
    public class BubblePool : MonoBehaviour
    {

        #region Knobs

        [SerializeField] protected int _poolSize;

        #endregion

        #region References

        public static BubblePool instance;
        [SerializeField] protected Transform _bubblepos;

        #endregion

        #region RuntimeVariables

        [SerializeField] protected PlayersAvatar[] _bubbleList;
        protected int _bubblesAlive = 1;

        #endregion

        #region UnityMethods
        void Start()
        {
        }

        void Update()
        {

        }
        #endregion

        #region PublicMethods

        public void AlertAboutDeath()
        {
            if(_bubblesAlive <= 1)
            {
                _bubblesAlive -= 1;
                UIManager.instance.ActivateDefeatPanel();
            }
            else if(_bubblesAlive >= 2)
            {
                _bubblesAlive -= 1;
            }
        }

        public void AddBubbles()
        {
            if(_bubblesAlive >= _poolSize)
            {
                return;
            }
            else
            {
                _bubblesAlive += 1;

                foreach(PlayersAvatar avatar in _bubbleList)
                {
                    if (!avatar.isActiveAndEnabled)
                    {
                        avatar.gameObject.transform.position = (Vector2)_bubblepos.position 
                            + new Vector2(Random.Range(0.1f, 1.0f), 0.0f);
                        avatar.gameObject.SetActive(true);
                        break;
                    }
                }
            }
        }

        #endregion
    }

}