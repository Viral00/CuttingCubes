using UnityEngine;

public class KnifeController : MonoBehaviour
{
    [SerializeField] private float dirY1;
    [SerializeField] private float dirY2;
    [Range(0, 10)] public float moveSpeed;
    private bool moveDown;

    private void Start()
    {
        moveDown = true;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            VerticalMovement();
        }
    }

    private void VerticalMovement()
    {
        if (transform.position.y > dirY1)
            moveDown = false;
        else if (transform.position.y < dirY2)
            moveDown = true;

        if (moveDown)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime, transform.position.z);
        }
    }
}
