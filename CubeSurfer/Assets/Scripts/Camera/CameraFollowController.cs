using UnityEngine;

public class CameraFollowController : MonoBehaviour
{

    [SerializeField] private Transform surferTransform;

    private Vector3 offset;

    private Vector3 newPosition;

    [SerializeField] private float lerpValue;

    void Start()
    {
        offset = transform.position - surferTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SetCameraSmoothFollow();
    }

    private void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, surferTransform.position.y, surferTransform.position.z)+offset , lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
