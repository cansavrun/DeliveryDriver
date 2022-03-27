using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour

{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float  boostSpeed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bump")


        {
            Debug.Log("Yavaþlýyoru");
            moveSpeed = slowSpeed;

        }
        
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Boost")
        {
            Debug.Log("Hýzlanýyoruuuz");
            moveSpeed = boostSpeed;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
