using UnityEngine;
using System.Collections;

public class PlayerWeapon : MonoBehaviour {

	private int WeaponType;
    public GameObject CanonRange_1;
    public GameObject CanonRange_2;
    public GameObject CanonRange_3;

    void Update () {
        Debug.Log("Type weapon:" + WeaponType);

		if (Input.GetButtonDown ("Jump"))
		{
            switch (WeaponType)
            {
                case 1:
                    StartCoroutine(Shoot_W1());
                break;

                case 2:
                    StartCoroutine(Shoot_W2());
                break;

                case 3:
                    StartCoroutine(Shoot_W3());
                break;
            }
            
		}
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Weap_1")
        {
            WeaponType = 1;
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Weap_2")
        {
            WeaponType = 2;
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Weap_3")
        {
            WeaponType = 3;
            Destroy(col.gameObject);
        }

    }

    IEnumerator Shoot_W1() //Tirs avec le canon 1
    {
        GameObject Clone_canonRange_1 = (GameObject)Instantiate(CanonRange_1, transform.position + (transform.forward * 6.5f), transform.rotation);
        yield return new WaitForSeconds(1.0f);
        Clone_canonRange_1.GetComponent<Collider>().enabled = false;
        Destroy(Clone_canonRange_1, 3.5f);

        yield return null;
    }

    IEnumerator Shoot_W2() //Tirs avec le canon 2
    {
        GameObject Clone_canonRange_2 = (GameObject)Instantiate(CanonRange_2, transform.position + (transform.forward * 11), transform.rotation);
        yield return new WaitForSeconds(1.0f);
        Clone_canonRange_2.GetComponent<Collider>().enabled = false;
        Destroy(Clone_canonRange_2, 3.5f);

        yield return null;
    }

    IEnumerator Shoot_W3() //Tirs avec le cnaon 3
    {
        GameObject Clone_canonRange_3 = (GameObject)Instantiate(CanonRange_3, transform.position + (transform.forward * 16), transform.rotation);
        yield return new WaitForSeconds(1.0f);
        Clone_canonRange_3.GetComponent<Collider>().enabled = false;
        Destroy(Clone_canonRange_3, 3.5f);

        yield return null;
    }
}