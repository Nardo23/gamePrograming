using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrel : MonoBehaviour
{
    public bool direction;
    public float speed;
    public float birdTime;
    public float maxBirdTime;
    public GameObject bird;
    bool start = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start == true) // 
        {
            birdTime -= Time.deltaTime;
            if (birdTime < 0)
            {
                birdTime = maxBirdTime;
                Instantiate(bird, this.transform.position, Quaternion.Euler(new Vector3()));
            }
            if (transform.position.x > 5f)
            {
                direction = false;
            }
            else if (transform.position.x < -5f)
            {
                direction = true;
            }
            else if (Random.Range(0, 1f) < .01f)
            {
                direction = !direction;

            }
            if (direction == false)
            {
                transform.position = new Vector3(transform.position.x - Time.deltaTime * speed, transform.position.y);

            }
            else
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
}
