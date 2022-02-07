using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camnepad : MonoBehaviour
{
    public GameObject kamen;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 0.2)
        {
            GameObject kam = Instantiate(kamen, new Vector2(transform.position.x + Random.Range(-0.5f, 0.1f), transform.position.y), Quaternion.identity);
            timer = 0;
            Destroy(kam, 2);
        }
    }
}
