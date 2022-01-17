using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    [SerializeField] private Vector3 _initialVelocity;
    
    private Animator _animator;
    private int _isMovingBoolId;

    private bool _isMoving;
    private Vector3 _velocity;


    void Start()
    {
        _animator = GetComponent<Animator>();
        _isMovingBoolId = Animator.StringToHash("IsMoving");
        _velocity = _initialVelocity;
    }

    private void FixedUpdate()
    {
        if (_isMoving) {
            this.transform.position += _velocity * Time.fixedDeltaTime;
        }
    }

    public void SetIsMoving(bool isMoving)
    {
        _animator.SetBool(_isMovingBoolId, isMoving);
        _isMoving = isMoving;
    }
}
