using UnityEngine;

public class BlobSpawner : MonoBehaviour
{
    public GameObject[] blobs;
    public RectTransform spawnArea;
    public float spawnInterval = 3f;

    void Start()
    {
        InvokeRepeating("SpawnBlob", 1f, spawnInterval);
    }

    void SpawnBlob()
    {
        int index = Random.Range(0, blobs.Length);
        GameObject newBlob = Instantiate(blobs[index], spawnArea);
        RectTransform rt = newBlob.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector2(Random.Range(-300f, 300f), 300f);
    }
}
