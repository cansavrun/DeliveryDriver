using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackage = false;
    [SerializeField] float destroyTime = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    Color32 originalColor;

    SpriteRenderer spriteRenderer;
    

     void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = GetComponent<SpriteRenderer>().color;
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bir þeye çarptým");
    }

     void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            spriteRenderer.color = collision.GetComponent<SpriteRenderer>().color;
            Destroy(collision.gameObject, destroyTime);
            hasPackage = true;
        }
        else if (collision.tag == "Customer"  && hasPackage)
        {
            hasPackage = false;
            spriteRenderer.color = originalColor;
            Debug.Log("Delivered Package");
        }
    }
}
