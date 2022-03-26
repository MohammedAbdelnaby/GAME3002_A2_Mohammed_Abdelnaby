using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField]
    private float force = 0.0f;
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("HELLLLLLLLLLLLLo");
        collision.gameObject.GetComponent<Rigidbody>().AddExplosionForce(force, transform.position, 10.0f);
    }
}
