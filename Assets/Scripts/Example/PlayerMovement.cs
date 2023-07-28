using UnityEngine;

namespace Example
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] protected float _speed;
        
        protected Rigidbody _rigidbody;

        protected void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        protected void FixedUpdate()
        {
            _rigidbody.velocity = new Vector3(
                Input.GetAxis("Horizontal"), 
                Input.GetAxis("Vertical"), 
                0) * _speed;
        }
    }
}