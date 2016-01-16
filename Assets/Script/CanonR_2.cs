using UnityEngine;
using System.Collections;

public class CanonR_2 : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Obs_small")
        {
            col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            col.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 200);
            StartCoroutine(col.gameObject.GetComponent<ObsScript>().MovementStop());

        }
        if (col.gameObject.tag == "Obs_medium")
        {
            col.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            col.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 100);
            StartCoroutine(col.gameObject.GetComponent<ObsScript>().MovementStop());
        }
    }
}
