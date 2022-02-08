using System.Collections.Generic;
using UnityEngine;

public class CubePool : MonoBehaviour
{
    [SerializeField] private GameObject CubePrefab;
    [SerializeField] private Transform SpawnPoint;
    private List<GameObject> poolCube = new List<GameObject>();
    private int amountToPool = 10;

    private void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject Cube = Instantiate(CubePrefab, SpawnPoint.position, SpawnPoint.rotation);
            Cube.SetActive(false);
            poolCube.Add(Cube);
        }

    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < poolCube.Count; i++)
        {
            if (!poolCube[i].activeInHierarchy)
            {
                return poolCube[i];
            }
        }

        return null;
    }
}

