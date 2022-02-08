using System.Collections;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private CubePool cubePool;
    [SerializeField] private Transform spawnPosition;

    private void Update()
    {
        StartCoroutine(SpawnCube());
    }

    private IEnumerator SpawnCube()
    {
        GameObject cube = cubePool.GetPooledObject();
        if (cube != null)
        {
            cube.transform.position = spawnPosition.transform.position;
            cube.SetActive(true);  
        }
        yield return new WaitForSeconds(4);
    }
}
