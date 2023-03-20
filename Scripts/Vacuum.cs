using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacuum : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Collider[] colliders = FindObjectsOfType<Collider>();

        foreach (Collider findCollider in colliders)
        {
            if (findCollider == other)
            {
                findCollider.GetComponent<Rigidbody>().useGravity = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Collider[] colliders = FindObjectsOfType<Collider>();

        foreach (Collider findCollider in colliders)
        {
            if (findCollider == other)
            {
                findCollider.GetComponent<Rigidbody>().useGravity = true;
            }
        }
    }
}
