using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SpinnyCandyTrap : MonoBehaviour
{
    [SerializeField]
    private Vector3 torque = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddTorque(torque);
    }

    void Update()
    {

    }
}
