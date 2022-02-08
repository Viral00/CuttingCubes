using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private SlicedCube slicedCubePrefab;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            gameObject.transform.parent = collision.transform;
        }
        if (collision.gameObject.tag == "CubeDestroyer")
        {
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Knife")
        {
            Instantiate(slicedCubePrefab, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}
