using UnityEngine;

public class Tower : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    float x = Random.Range(0f,1f);
    float y = Random.Range(0f,1f);
    float z = Random.Range(0f,1f);

    transform.localScale = new Vector3(x,y,z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
