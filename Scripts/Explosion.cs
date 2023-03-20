using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float _power;
    [SerializeField] private float _radius;

    private float _distance;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            MakeAnExplosion();
        }
    }

    private void MakeAnExplosion()
    {
        Rigidbody[] rigidbodies = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody findRigidbody in rigidbodies)
        {
            _distance = Vector3.Distance(transform.position, findRigidbody.transform.position);

            if (_distance < _radius)
            {
                Vector3 direction = findRigidbody.transform.position - transform.position;

                findRigidbody.AddForce(direction.normalized * _power * (_radius - _distance), ForceMode.Impulse);
            }
        }

    }

}
