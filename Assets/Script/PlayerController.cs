using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;
    public float speedBack;
	public float turningSpeed;

    void Start ()
	{

	}

    void Update()
	{
        //Déplacement droite & gauche
        float movehorizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        transform.Rotate(0, movehorizontal, 0);

        //Déplacement avant & arrière.
        float movevertical = Input.GetAxis("Vertical"); //Check la valeur de l'input
        if (movevertical > 0)
        {
            movevertical = movevertical * speed * Time.deltaTime; //si movevertical > 0 alors le vaisseau avance à la vitesse "speed"
        }
        else if (movevertical < 0)
        {
            movevertical = movevertical * speedBack * Time.deltaTime; //si movevertical < 0 alors le vaisseau recule à la vitesse "speedBack"
        }
        transform.Translate(0, 0, movevertical); //déplacement en z en fonction de movevertical

    }

}	