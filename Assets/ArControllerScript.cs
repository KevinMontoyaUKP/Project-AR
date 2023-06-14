using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArControllerScript : MonoBehaviour
{
    public GameObject MyObject;
    public ARRaycastManager RayManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            list<ARRaycastHit> touches = new list<ARRaycastHit>();
            RayManager.Raycast (Input.GetTouch(0).position, touches, UnityEngine.XR.ARSubsystem.TrackableType.Planes);

            if (touches.Count > 0)
            {
                GameObject.Instantiate(MyObject, touches[0].pose.position, touches[0].pose.rotation);
            }
        }
    }
}
