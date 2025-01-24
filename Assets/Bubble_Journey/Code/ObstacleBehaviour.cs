using MrSanmiAndNAwakening.BubbleJourney;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MrSanmiAndNAwakening
{
    public class ObstacleBehaviour : MonoBehaviour
    {
        #region References

        [SerializeField] protected Transform[] _waypoints;
        //[SerializeField] protected Rigidbody2D _rb2D;

        #endregion

        #region Knobs

        [SerializeField] protected float _vel;

        #endregion

        #region RuntimeVariables

        protected int _index;

        #endregion

        #region UnityMethods
        
        void FixedUpdate()
        {
            if (GameManager.instance.StartGame)
            {
                //_rb2D.velocity = (_waypoints[_index].transform.position - transform.position).normalized * _vel;
                transform.Translate((_waypoints[_index].transform.position - transform.position).normalized * _vel * Time.fixedDeltaTime);
                if(_waypoints.Length != 1)
                {
                    CheckCurrentposition();
                }
            }
        }

        #endregion

        #region LocalMethods

        protected void CheckCurrentposition()
        {
            if (transform.position.x - _waypoints[_index].transform.position.x >= -0.25 && transform.position.x - _waypoints[_index].transform.position.x <= 0.25 && transform.position.y - _waypoints[_index].transform.position.y >= -0.25 && transform.position.y - _waypoints[_index].transform.position.y <= 0.25)
            {
                if (_index == _waypoints.Length - 1)
                {
                    _index = 0;
                }
                else
                {
                    _index++;
                }
            }
        }

        #endregion
    }
}