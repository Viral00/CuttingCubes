using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
