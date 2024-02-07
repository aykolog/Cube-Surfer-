using UnityEngine;

public class SurferMovementController : MonoBehaviour
{
    [SerializeField] private SurferInputController surferInputController;

    [SerializeField] private float forwardMovementSpeed;

    [SerializeField] private float horizontalMovementSpeed;

    [SerializeField] private float horizontalLimitValue;

    private float newPositionX;

    void  FixedUpdate()
    {

        SetSurferForwardMovement();
        SetSurferHorizontalMovement();
    }

    private void SetSurferForwardMovement()
    {
        transform.Translate(Vector3.down * forwardMovementSpeed * Time.fixedDeltaTime);
    }

    private void SetSurferHorizontalMovement()
    {
        newPositionX = transform.position.x + surferInputController.HorizontalValue * horizontalMovementSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -horizontalLimitValue, horizontalLimitValue);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}
