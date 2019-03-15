using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public GameObject score;
    bool start = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start == true)
        {


            if (Input.GetKey(KeyCode.A) && transform.position.x > -6f)
            {
                transform.position = new Vector3(transform.position.x - Time.deltaTime * speed, transform.position.y);
            }
            else if (Input.GetKey(KeyCode.D) && transform.position.x < 6f)
            {
                transform.position = new Vector3(transform.position.x + Time.deltaTime * speed, transform.position.y);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                start = true;
            }

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        score.GetComponent<manager>().score += 23; // birds are worth 23 points!
 
    }
}
