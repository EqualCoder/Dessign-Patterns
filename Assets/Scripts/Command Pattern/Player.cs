using UnityEngine;

namespace Assets.Scripts.Command_Pattern
{
    public class Player : MonoBehaviour
    {
        [SerializeField] public GameObject _activeIndicator;
        [SerializeField] private float _moveSpeed;
        private Animator animator;
        private Vector3 _moveDirection;

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            transform.position += _moveDirection * _moveSpeed;
        }

        private void OnMouseDown()
        {
            Debug.Log($"selection test ");
            PlayerSelectionManager.Instance.SelectPlayer(this);
        }

        public void MoveForward()
        {
            _moveDirection=Vector3.forward;
            transform.eulerAngles=Vector3.up*0;
            animator.SetTrigger("Walk");
        }

        public void MoveBack()
        {
            _moveDirection=-Vector3.forward;
            transform.eulerAngles=Vector3.up*180;
            animator.SetTrigger("Walk");
        }
        
        public void MoveRight()
        {
            _moveDirection=Vector3.right;
            transform.eulerAngles=Vector3.up*90;
            animator.SetTrigger("Walk");
        }
        public void MoveLeft()
        {
            _moveDirection=-Vector3.right;
            transform.eulerAngles=Vector3.up*-90;
            animator.SetTrigger("Walk");
        }

        public void Stop()
        {
            _moveDirection=Vector3.zero;
            animator.SetTrigger("Normal");
        }
        

    }
}
