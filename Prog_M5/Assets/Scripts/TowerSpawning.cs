using UnityEngine;

public class TowerSpawning : MonoBehaviour
{
    [SerializeField] private GameObject towerPrefab;
     
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Random.Range(-5f,5f);
        float z = Random.Range(-5f,5f);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject clone;
            clone = Instantiate(towerPrefab, new Vector3(x, 0, z), Quaternion.identity);
        }
    }
}
