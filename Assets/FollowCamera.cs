using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour

    //this things position (camera) should be the same as object(car)'s position
{
    [SerializeField] GameObject thingtoFollow;
  

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingtoFollow.transform.position + new Vector3(0,0,-10);
    }
}
