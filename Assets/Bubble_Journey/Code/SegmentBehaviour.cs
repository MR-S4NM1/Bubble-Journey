using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MrSanmiAndNAwakening.BubbleJourney
{
    public class SegmentBehaviour : MonoBehaviour
    {
        #region References

        [SerializeField] protected Rigidbody2D _rb2D;
        [SerializeField] protected GameObject[] _obstacles;
        [SerializeField] protected GameObject _upgrade;

        #endregion

        #region Knobs

        public bool initialSegment;

        #endregion

        #region RunTimeVariables

        protected int _index;

        #endregion

        #region UnityMethods

        private void Awake()
        {
            if (!initialSegment)
            {
                _index = Random.Range(0, 10);
                if (_index == 7)
                {
                    _upgrade.SetActive(true);
                }
                if (GameManager.instance.GetScore <= 250)
                {
                    if (_index <= 8)
                    {
                        _obstacles[0].SetActive(true);
                    }
                    else if (_index == 9)
                    {
                        _obstacles[1].SetActive(true);
                    }
                    else
                    {
                        _obstacles[2].SetActive(true);
                    }
                }
                else if (GameManager.instance.GetScore > 250 && GameManager.instance.GetScore <= 750)
                {
                    if (_index <= 6)
                    {
                        _obstacles[1].SetActive(true);
                    }
                    else if (_index > 6 && _index <= 8)
                    {
                        _obstacles[0].SetActive(true);
                    }
                    else
                    {
                        _obstacles[2].SetActive(true);
                    }
                }
                else
                {
                    if (_index <= 8)
                    {
                        _obstacles[2].SetActive(true);
                    }
                    else if (_index == 9)
                    {
                        _obstacles[1].SetActive(true);
                    }
                    else
                    {
                        _obstacles[0].SetActive(true);
                    }
                }
            }
        }

        void FixedUpdate()
        {
            if (GameManager.instance.StartGame)
            {
                _rb2D.velocity = Vector3.down * GameManager.instance.GetVelocity;
            }
            else
            {
                _rb2D.velocity = Vector2.zero;
            }

            if (transform.position.y < -35)
            {
                if (!initialSegment)
                {
                    for (int i = 0; i < _obstacles.Length; i++)
                    {
                        _obstacles[i].SetActive(false);
                    }
                    _upgrade.SetActive(false);
                }
                gameObject.SetActive(false);
            }
        }

        #endregion
    }
}