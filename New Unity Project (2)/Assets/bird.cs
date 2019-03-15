using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < height)
        {
            GameObject.FindGameObjectWithTag("lives").GetComponent<manager>().lives -= 1;
            Destroy(this.gameObject);
            
        }
    }
}
