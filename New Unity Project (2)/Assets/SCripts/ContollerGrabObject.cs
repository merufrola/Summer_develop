using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContollerGrabObject : MonoBehaviour {

    private SteamVR_TrackedObject trackedObj;

    private GameObject collidingObject;

    private GameObject objectInHand;

    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    private void SetCollidingObject(Collider col)
    {
        if (collidingObject || !col.GetComponent<Rigidbody>())
        {
            return;
        }
        collidingObject = col.gameObject;
    }

    public void OnTriggerEnter(Collider other)
    {
        SetCollidingObject(other);
    }

    public void OnTriggerStay(Collider other)
    {
        SetCollidingObject(other);
    }

    public void OnTriggerExit(Collider other)
    {
        if (!collidingObject)
        {
            return;
        }

        collidingObject = null;
    }

    private void GrabObject()
    {
        objectInHand = collidingObject;
        collidingObject = null;
        var joint = AddFixedJoint();
        joint.connectedBody = objectInHand.GetComponent<Rigidbody>();
    }

    private FixedJoint AddFixedJoint()
    {
        FixedJoint fx = gameObject.AddComponent<FixedJoint>();
        fx.breakForce = 20000;
        fx.breakTorque = 20000;
        return fx;
    }

    private void ReleaseObject()
    {
        if (GetComponent<FixedJoint>())
        {
            GetComponent<FixedJoint>().connectedBody = null;
            Destroy(GetComponent<FixedJoint>());

            objectInHand.GetComponent<Rigidbody>().velocity = Controller.velocity;
            objectInHand.GetComponent<Rigidbody>().angularVelocity = Controller.angularVelocity;
        }

        objectInHand = null;
    }

    void Update()
    {
        if (Controller.GetHairTriggerDown())
        {
            if (collidingObject)
            {

                GrabObject();
            }
        }

        if (Controller.GetHairTriggerUp())
        {
            if (objectInHand)
            {
                ReleaseObject();
            }
        }
    }
    //
    // void Grab(){
    //
    //     if (Controller.GetHairTriggerDown())
    //     {
    //         if (collidingObject)
    //         {
    //             GrabObject();
    //             // switch(collidingObject.transform.tag){
    //             //     case "food":
    //             //         GrabObject();
    //             //         break;
    //             // case "hare" :
    //             //     if(statemanager.state>0){
    //             //         GrabObject();
    //             //     }
    //             // break;
    //             // case "fox" :
    //             // if(statemanager.state>1){
    //             //     GrabObject();
    //             // }
    //             // break;
    //             // case "wolf" :
    //             // if(statemanager.state>2){
    //             //     GrabObject();
    //             // }
    //             // break;
    //             // case "bear" :
    //             // if(statemanager.state>3){
    //             //     GrabObject();
    //             // }
    //             // break;
    //             // if(statemanager.state>4){
    //             //     GrabObject();
    //             // }
    //             // break;
    //             // case "human" :
    //             // if(statemanager.state>5){
    //             //     GrabObject();
    //             // }
    //             // break;
    //     //    }
    //
    //
    //         }
    //     }
    // }
}
