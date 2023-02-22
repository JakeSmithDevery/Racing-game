using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public GameObject followObject;
    // Start is called before the first frame update
    Vector3 targetPosition; 

    // Update is called once per frame
    void Update()
    {
        if(followObject != null)
        {
            targetPosition.x = followObject.transform.position.x;
            targetPosition.y = followObject.transform.position.y;

            targetPosition.z = transform.position.z;

            transform.position = targetPosition;
        }
        
    }
}
