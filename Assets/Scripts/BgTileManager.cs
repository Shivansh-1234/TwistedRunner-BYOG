using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgTileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;

    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float tileLength = 150f;
    private float safeZone = 120f;
    private int amnTilesOnScreen = 12;
    private int lastPrefabIndex = 0;

    private int rotation = 45;

    private List<GameObject> activeTiles;


    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        activeTiles = new List<GameObject>();

        for (int i = 0; i < amnTilesOnScreen; i++)
        {
            SpawnTile();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z - safeZone > (spawnZ - amnTilesOnScreen * tileLength))
        {
            SpawnTile();
            DeleteTile();
        }
    }

    private void SpawnTile(int prefabIndex = -1)
    {
        int randomPrefabIndex = RandomPrefabIndex();

        GameObject go;
        go = Instantiate(tilePrefabs[randomPrefabIndex]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        go.transform.GetChild(0).transform.localRotation = Quaternion.Euler(go.transform.GetChild(0).transform.localRotation.x + rotation, 90f, 90f);

        spawnZ += tileLength;
        rotation += 45;

        activeTiles.Add(go);
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if (tilePrefabs.Length <= 1)
        {
            return 0;
        }

        int randomIndex = lastPrefabIndex;

        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, tilePrefabs.Length);
        }

        lastPrefabIndex = randomIndex;

        return randomIndex;
    }
}
