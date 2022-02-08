using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private SlicedCube slicedCubePrefab;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Knife")
        {
            Instantiate(slicedCubePrefab, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "platform")
        {
            this.transform.parent = collision.transform;
        }
    }
}
