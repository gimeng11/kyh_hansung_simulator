using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float stopSpeed = 20f;  // 빠르게 멈추는 속도
    public float lookSpeed = 2f;
    public float gravity = -9.8f;

    private CharacterController controller;
    private Vector3 velocity;
    private float rotationX = 0f;
    private Transform playerCamera;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        playerCamera = Camera.main.transform;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * moveSpeed;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed;
        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        if (controller.isGrounded)
        {
            velocity.y = -2f;
        }
        else
        {
            velocity.y += gravity * Time.deltaTime;
        }

        // 이동을 멈출 때 빠르게 멈추게 하는 로직
        if (moveX == 0 && moveZ == 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, stopSpeed * Time.deltaTime);
            velocity.z = Mathf.MoveTowards(velocity.z, 0, stopSpeed * Time.deltaTime);
        }

        controller.Move(move * Time.deltaTime);
        controller.Move(velocity * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X") * lookSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * lookSpeed;

        transform.Rotate(Vector3.up * mouseX);
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        playerCamera.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
    }
}
