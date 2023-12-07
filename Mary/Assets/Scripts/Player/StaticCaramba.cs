using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCaramba : MonoBehaviour
{
    public CapsuleCollider referenceCapsule;
    public bool lockMaterial = true;
    public PhysicMaterial referencePhyMaterial;

    private void Start()
    {
        referenceCapsule = GetComponent<CapsuleCollider>();
        GetComponent<Collider>().material = referencePhyMaterial;
    }
    private void Update()
    {

    }
}
