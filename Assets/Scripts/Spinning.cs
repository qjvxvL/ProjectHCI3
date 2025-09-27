using UnityEngine;
using UnityEngine.UI;

public class Spinning : MonoBehaviour
{
    public float mouseRotationSpeed = 100f;
    public float touchRotationSpeed = 0.3f;
    public Button resetButton;  // Reference to the UI Button
    public Button imageButton;  // Reference to the UI Image Button
    private Quaternion initialRotation;
    private const float rotationThreshold = 0.001f;  // Threshold for rotation comparison

    void Start()
    {
        initialRotation = transform.rotation;  // Store the initial rotation of the object
        resetButton.gameObject.SetActive(false);  // Initially hide the button
        imageButton.onClick.AddListener(ResetRotation); // Add listener to the image button
        Debug.Log("Initial Rotation: " + initialRotation.eulerAngles);
    }

    void Update()
    {
        HandleMouseInput();
        HandleTouchInput();
        CheckRotation();
    }

    void HandleMouseInput()
{
    if (Input.GetMouseButton(0))
    {
        float horizontal = Input.GetAxis("Mouse X") * mouseRotationSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Mouse Y") * mouseRotationSpeed * Time.deltaTime;

        transform.Rotate(Vector3.up, -horizontal, Space.World);  // Horizontal rotation around global Y-axis
        transform.Rotate(Vector3.right, vertical, Space.Self);   // Vertical rotation around local X-axis
    }
}

public void HandleTouchInput()
{
    if (Input.touchCount == 1)
    {
        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Moved)
        {
            float horizontal = touch.deltaPosition.x * touchRotationSpeed;
            float vertical = touch.deltaPosition.y * touchRotationSpeed;

            transform.Rotate(Vector3.up, -horizontal, Space.World);  // Horizontal rotation around global Y-axis
            transform.Rotate(Vector3.right, vertical, Space.Self);   // Vertical rotation around local X-axis
        }
    }
}

    void CheckRotation()
    {
        if (Quaternion.Angle(transform.rotation, initialRotation) > rotationThreshold)
        {
            resetButton.gameObject.SetActive(true);
        }
        else
        {
            resetButton.gameObject.SetActive(false);
        }
    }

    public void ResetRotation()
    {
        transform.rotation = initialRotation;  // Reset to the initial rotation
        Debug.Log("Reset to Initial Rotation: " + initialRotation.eulerAngles);
        Debug.Log("Current Rotation: " + transform.rotation.eulerAngles);
    }
}
