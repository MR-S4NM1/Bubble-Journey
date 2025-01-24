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
        [SerializeField] protected int _bubblesAlive;

        #endregion

        #region UnityMethods

        private void Awake()
        {
            if(instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(instance);
            }
        }

        void Start()
        {
            _bubblesAlive = 1;
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

                for(int i = 0; i < _poolSize; ++i)
                {
                    if (!_bubbleList[i].gameObject.activeSelf)
                    {
                        _bubbleList[i].gameObject.transform.position = (Vector2)_bubblepos.position 
                            + new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(0.0f, 1.0f));
                        _bubbleList[i].gameObject.SetActive(true);
                        return;
                    }
                }
            }
        }

        #endregion
    }

}