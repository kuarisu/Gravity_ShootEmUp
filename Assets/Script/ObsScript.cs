using UnityEngine;
using System.Collections;

public class ObsScript : MonoBehaviour {

    float rotationsPerMinute;
    float random;

    void Start ()
    {
        random = Random.Range(0f, 8f);
        rotationsPerMinute = Random.Range(3f, 4f);
    }

    void Update ()
    {
        transform.Rotate( random * rotationsPerMinute * Time.deltaTime, random * rotationsPerMinute * Time.deltaTime, random * rotationsPerMinute * Time.deltaTime);
    }

    public IEnumerator MovementStop()
    {
        Debug.Log("hello");
        yield return new WaitForSeconds(3.0f);

        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        GetComponent<Rigidbody>().isKinematic = true;


    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Ennemy")
        {
            Destroy(col.gameObject, 0);

        }
    }

}
