using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;
public class PlayerControler : MonoBehaviour
{
    private InputSystem_Actions _controller;
    private Rigidbody _rb; 
    
    
    
    #region input manager

private void Awake()
    {
        _controller = new InputSystem_Actions();


        _controller.Player.Jump.performed += _ => Jump();
    }

private void Jump()
    {
        _rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
    }
   
    



    private void OnEnable()
    {
        _controller.Enable();
    }

    private void OnDisable()
    {
        _controller.Disable();
    }
 #endregion

    private Vector2 _movementValue;

   


    private void OnMove(InputValue Value)
    {
        _movementValue = Value.Get<Vector2>();
    }

    private void Update() {
        transform.position += (new Vector3(_movementValue.x, _movementValue.y)) * 0.25f ;
    }




}
