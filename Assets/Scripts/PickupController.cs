using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    // Position in the camera that will hold the object
    [Header("Pickup settings")]
    [SerializeField] Transform holdArea;
    private GameObject holdingObject;
    private Rigidbody holdingObjectRB;

    // Parameters for the pickup range and pickup force
    [Header("Physics parameters")]
    [SerializeField] float pickupRange = 5f;
    [SerializeField] float pickupForce = 150f;

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            // Do something if nothing is being held
            if (holdingObject == null)
            {
                RaycastHit hit;
                if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickupRange))
                {
                    PickupObject(hit.transform.gameObject);
                }
            }
            else
            {
                DropObject();
            }
        }
        // Move the object around if there is an object equipped
        if (holdingObject != null)
        {
            MoveObject();
        }
    }

    void MoveObject()
    {
        if (Vector3.Distance(holdingObject.transform.position, holdArea.position) > 0.1f)
        {
            Vector3 moveDirection = (holdArea.position - holdingObject.transform.position);
            holdingObjectRB.AddForce(moveDirection * pickupForce);
        }
    }

    void PickupObject (GameObject pickObj)
    {
        if (pickObj.GetComponent<Rigidbody>())
        {
            holdingObjectRB = pickObj.GetComponent<Rigidbody>();
            holdingObjectRB.useGravity = false;
            holdingObjectRB.drag = 10;
            holdingObjectRB.constraints = RigidbodyConstraints.FreezeRotation;

            holdingObjectRB.transform.parent = holdArea;
            holdingObject = pickObj;
        }
    }

    void DropObject()
    {
            holdingObjectRB.useGravity = true;
            holdingObjectRB.drag = 1;
            holdingObjectRB.constraints = RigidbodyConstraints.None;

            holdingObject.transform.parent = null;
            holdingObject = null;
    }
}
