using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    
    [SerializeField] private float moveSpeed;
    private Vector2 moveAxis;
    private PlayerInput actions;
    private void Awake() 
    {

        moveAxis = new Vector2(0, 0);

    }

    private void OnEnable() 
    {
               actions = new PlayerInput();

        actions.Player.Enable();
        actions.Player.Movement.performed += ctx => {
            OnMove(ctx);
        };
         actions.Player.Movement.canceled += ctx => {
            moveAxis = new Vector2(0, 0);
            OnMove(ctx);
        };
    }

    private void OnDisable() 
    {
        actions.Player.Disable();    
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        moveAxis = context.ReadValue<Vector2>();
    }

    
    void Update()
    {

        transform.position += new Vector3(moveAxis.x * Time.deltaTime * moveSpeed, moveAxis.y * Time.deltaTime * moveSpeed, 0);
    }
}
