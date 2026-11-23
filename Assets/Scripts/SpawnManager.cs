using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public InputAction SpawnAction;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (SpawnAction.triggered)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
