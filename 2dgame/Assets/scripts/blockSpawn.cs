using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockSpawn : MonoBehaviour
{
    private float timer = 0;
    private float timer2 = 0;
    private float timer3 = 0;
    public GameObject block;
    public GameObject block2;
    public GameObject kristal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        timer3 += Time.deltaTime;
        if(timer >= 1.2f)
        {
            GameObject myblock = Instantiate(block, new Vector2(gameObject.transform.position.x, Random.Range(-4, 5)), Quaternion.identity);
            timer = 0;
            Destroy(myblock, 7);
        }
        if (timer2 >= 1.6f)
        {
            GameObject myblock2 = Instantiate(block2, new Vector2(gameObject.transform.position.x, Random.Range(-4, 5)), Quaternion.identity);
            timer2 = 0;
            Destroy(myblock2, 7);
        }
        if (timer3 >= 5)
        {
            GameObject mykristal = Instantiate(kristal, new Vector2(gameObject.transform.position.x, Random.Range(-4, 5)), Quaternion.identity);
            timer3 = 0;
            Destroy(mykristal, 7);
        }
    }
}
