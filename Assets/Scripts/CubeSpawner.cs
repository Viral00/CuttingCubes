using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private CubePool cubePool;
    [SerializeField] private Transform spawnPosition;

    private void Update()
    {
        InvokeRepeating("SpawnCube", 1.0f, 5.0f);
    }

    private void SpawnCube()
    {
        GameObject cube = cubePool.GetPooledObject();

        if (cube != null)
        {
            cube.transform.position = spawnPosition.transform.position* Time.deltaTime;
            cube.SetActive(true);
        }

    }
}
