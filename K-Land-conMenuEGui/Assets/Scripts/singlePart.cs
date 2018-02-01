using UnityEngine;
using System.Collections;

public class singlePart : MonoBehaviour
{
    public Transform explosionPosition;

    private bool explode = false;
    private Rigidbody rigidbody;

    void OnEnable()
    {
        explode = true;
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (explode)
        {
            rigidbody.AddExplosionForce(20, explosionPosition.position, 3f);
        }
    }

}