using UnityEngine;

public class SlicedCube : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            gameObject.transform.gameObject.GetComponentInChildren<Transform>().parent = collision.transform;
        }
    }
    private void Update()
    {
        Destroy(gameObject, 3f);
    }
}
