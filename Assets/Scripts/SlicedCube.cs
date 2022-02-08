using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlicedCube : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CubeDestroyer")
        {
            Destroy(this);
        }
        if (collision.gameObject.tag == "platform");
        {
            this.transform.parent = collision.transform;
        }
    }
}
