using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Pool;

namespace MrSanmiAndNAwakening.BubbleJourney
{
    public class PlayersAvatar : MonoBehaviour
    {
        #region References

        [SerializeField] protected Rigidbody2D _rb2D;

        #endregion

        #region Knobs

        [SerializeField] protected float _movementSpeed;

        #endregion

        #region RuntimeVariables

        [SerializeField] protected Vector2 _movementDirection;
        protected float xPos;

        #endregion

        #region UnityMethods

        #endregion

        #region UnityMethods

        void Start()
        {
            InitializeAvatar();
            _movementDirection = Vector2.zero;
        }

        private void OnEnable()
        {
            BubblePool.instance.AddBubbles();
        }

        private void FixedUpdate()
        {
            _rb2D.velocity = _movementDirection * _movementSpeed;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Obstacle"))
            {
                BubblePool.instance.AlertAboutDeath();
                this.gameObject.SetActive(false);
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Powerup"))
            {
                BubblePool.instance.AddBubbles();
            }
        }

        #endregion

        #region PublicMethods
        public virtual void InitializeAvatar()
        {
            if (_rb2D == null)
            {
                _rb2D = GetComponent<Rigidbody2D>();
            }
        }

        public void MoveToRight()
        {
            _movementDirection = Vector2.right;
            _movementSpeed = 3.0f;
            Debug.Log(_movementDirection);
        }

        public void MoveToLeft()
        {
            _movementDirection = Vector2.left;
            _movementSpeed = 3.0f;
            Debug.Log(_movementDirection);
        }

        public void StopMoving()
        {
            _movementDirection = Vector2.zero;
            _movementSpeed = 0.0f;
        }

        #endregion

        #region CallbackMethods
        public void OnMOVE(InputAction.CallbackContext value)
        {
            // if(theIsUsingGyro) TODO Bool in Game Referee
            //if (value.performed)
            //{
            //    _movementDirection = Vector2.right;

            //    xPos = Camera.main.ScreenToWorldPoint(value.ReadValue<Vector2>()).x;

            //    if (xPos >= 0.0f)
            //    {
            //        _movementDirection = Vector2.right;
            //        _movementSpeed = 3.0f;
            //        Debug.Log(_movementDirection);
            //        _rb2D.velocity = _movementDirection * _movementSpeed;
            //    }
            //    else if (xPos < 0.0f)
            //    {
            //        _movementDirection = Vector2.left;
            //        _movementSpeed = 3.0f;
            //        Debug.Log(_movementDirection);
            //        _rb2D.velocity = _movementDirection * _movementSpeed;
            //    }
            //}
            //else if (value.canceled)
            //{
            //    _movementDirection = Vector2.zero;
            //    _movementSpeed = 0.0f;
            //}
        }

        public void OnROTATE(InputAction.CallbackContext value)
        {
            // if(theIsUsingGyro) TODO Bool in Game Referee
            //if (value.performed)
            //{
            //    _movementDirection = new Vector2(value.ReadValue<Vector3>().y, 0f).normalized;
            //}
            //else if (value.canceled)
            //{

            //}
        }

        public void OnPAUSE(InputAction.CallbackContext value)
        {
            if (value.performed)
            {
                //_gameReferee.PauseGame();
            }
        }

        #endregion

        #region GettersAndSetters

        #endregion
    }

}