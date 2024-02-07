using UnityEngine;


public class CubeController : MonoBehaviour
{
    [SerializeField] private SurferStackController surferStackController;

    private Vector3 direction = Vector3.back;

    private bool isStack = false;

    private RaycastHit hit;

    void Start()
    {
        surferStackController = GameObject.FindObjectOfType<SurferStackController>();
    }

    void FixedUpdate()
    {
        SetCubeBoxCast();
    }

    private void SetCubeBoxCast()
    {
        float boxSize = 0.5f; // Adjust the size of the box as needed

        if (Physics.BoxCast(transform.position, new Vector3(boxSize, boxSize, boxSize), direction, out hit, Quaternion.identity, 1f))
        {
            if (!isStack)
            {
                isStack = true;
                surferStackController.IncreaseBlockStack(gameObject);
                SetDirection();
            }

            if (hit.transform.tag == "ObstacleCube")
            {
                surferStackController.DecreaseBlock(gameObject);
            }

            
        }
    }

    private void SetDirection()
    {
        direction = Vector3.forward;
    }
}

/*public class CubeController : MonoBehaviour
{
    [SerializeField] private SurferStackController surferStackController;

    private Vector3 direction = Vector3.back;

    private bool isStack = false;

    private RaycastHit hit;

    void Start()
    {
        surferStackController = GameObject.FindObjectOfType<SurferStackController>();
    }



    void FixedUpdate()
    {
        SetCubeRaycast();
    }


    // NOT : KÜPLERİN KÖŞESİNE GELDİĞİNDE TAKILIYORUZ. O YÜZDEN BURAYI BOXCAST YA DA SAPHİRECAST İLE YAPACAĞIZ.
    private void SetCubeRaycast()
    {
        if (Physics.Raycast(transform.position, direction, out hit, 1f))
        {
            if (!isStack)
            {
                isStack = true;
                surferStackController.IncreaseBlockStack(gameObject);
                SetDirection();
            }

            if(hit.transform.name == "ObstacleCube")
            {
                surferStackController.DecreaseBlock(gameObject);
            }
        }
    }

    private void SetDirection()
    {
        direction = Vector3.forward;
    }

}*/
