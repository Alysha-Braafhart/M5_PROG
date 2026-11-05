using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 12f;
    [SerializeField] private float rotationSpeed = 20f;
    [SerializeField] private float jumpForce = 80f;
    [SerializeField] private float jumpScale = 1;
    [SerializeField] private float fallScale = 3f;

    private float gravityScale = 1f;
    private CharacterController controller;
    private Vector3 velocity = Vector3.zero;
    private Vector2 input = Vector2.zero;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float holdY = velocity.y;
        velocity = transform.forward * input.y * moveSpeed;
        velocity.y = holdY;

        if(velocity.y < 0)
        {
            gravityScale = fallScale;
        }
        else
        {
            gravityScale = jumpScale;
        }

        if(velocity.y > Physics.gravity.y * gravityScale)
        {
            velocity.y -= gravityScale;
        }

        controller.Move(velocity * Time.deltaTime);

        transform.Rotate(Vector3.up, rotationSpeed * input.x * Time.deltaTime);
    }

    public void MoveInput(InputAction.CallbackContext context)
    {
        input.x = context.ReadValue<Vector2>().x;
        input.y = context.ReadValue<Vector2>().y;
    }

    public void JumpInput(InputAction.CallbackContext context)
    {
        if(context.action.phase == InputActionPhase.Performed)
        {
            velocity.y = jumpForce;
        }
    }
}
