using TMPro.Examples;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] public GameObject Ball;
    private void Awake()
    {
        SpawnerFunction();
    }

    public void SpawnerFunction()
    {
        int[] SpawnPoints = {-4,4};
        int x = 0;

        x = Random.Range(0, 2);
        Instantiate(Ball, new Vector3(SpawnPoints[x], 0, 0), Quaternion.identity);
    }
}
