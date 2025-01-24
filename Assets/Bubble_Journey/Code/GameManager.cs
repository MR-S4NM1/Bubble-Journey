using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MrSanmiAndNAwakening.BubbleJourney
{
    public class GameManager : MonoBehaviour
    {
        #region References

        public static GameManager instance;

        [SerializeField] protected GameObject[] segments;
        [SerializeField] protected Transform spawnpos;

        #endregion

        #region Knobs

        [SerializeField] protected float _velocity;

        #endregion

        #region RunTimeVariables

        protected int _score = 0;
        protected bool _startGame = true;

        protected int _index;

        #endregion

        #region UnityMethods

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(this);
            }
        }

        void Start()
        {
            StartCoroutine(ScoreManager());
        }

        #endregion

        #region PublicMethods

        public void UpdateSpeed()
        {
            if (_velocity <= 10)
            {
                _velocity += 0.5f;
            }
        }

        public void ChooseNextSegment()
        {
            _index = Random.Range(0, segments.Length);
            for(int i = 0; i < segments[_index].transform.childCount ;i++)
            {
                if (!segments[_index].transform.GetChild(i).gameObject.activeSelf)
                {
                    segments[_index].transform.GetChild(i).gameObject.SetActive(true);
                    segments[_index].transform.GetChild(i).position = spawnpos.position;
                    break;
                }
            }
        }

        #endregion

        #region Corrutine

        IEnumerator ScoreManager()
        {
            yield return new WaitForSeconds(1);
            if (_startGame)
            {
                _score += 10;
                UIManager.instance.UpdateScore(_score);
                StartCoroutine(ScoreManager());
            }
        }

        #endregion

        #region GettersAndSetters

        public int GetScore
        {
            get { return _score; }
        }

        public float GetVelocity
        {
            get { return _velocity; }
        }

        public bool StartGame
        {
            get { return _startGame; }
            set { _startGame = value; }
        }

        #endregion
    }
}