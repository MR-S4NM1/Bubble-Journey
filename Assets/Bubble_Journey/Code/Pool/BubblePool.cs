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
        [SerializeField] protected int _bubblesAlive;

        #endregion

        #region References

        public static BubblePool instance;
        [SerializeField] protected PlayersAvatar _bubbleGO;

        #endregion


        #region RuntimeVariables

        [SerializeField] protected List<PlayersAvatar> _bubbleList;

        #endregion

        #region UnityMethods
        void Start()
        {
            SetupPool();
        }

        void Update()
        {

        }
        #endregion

        #region LocalMethods

        protected void SetupPool()
        {
            _bubbleList = new List<PlayersAvatar>();
        }

        #endregion


        #region PublicMethods

        public void AlertAboutDeath()
        {
            if(_bubblesAlive <= 1)
            {
                _bubblesAlive -= 1;
                //SceneChanger.instance.ChangeSceneTo(0);
            }
            else if(_bubblesAlive >= 2)
            {
                _bubblesAlive -= 1;
            }
        }

        public void AddBubbles()
        {
            if(_bubblesAlive >= 20)
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
                        avatar.gameObject.transform.position = (Vector2)_bubbleGO.gameObject.transform.position 
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