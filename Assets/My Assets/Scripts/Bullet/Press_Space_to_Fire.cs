using UnityEngine;
using System.Collections;

public class Press_Space_to_Fire : MonoBehaviour
{

    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject Bullet_Emitter;
    public GameObject Bullet_EmitterRight;
	public GameObject Bullet_EmitterLeft;
    public GameObject Bullet_EmitterRight2;
    public GameObject Bullet_EmitterLeft2;


    //Drag in the Bullet Prefab from the Component Inspector.
    public GameObject Bullet;

    //Enter the Speed of the Bullet from the Component Inspector.
    public float Bullet_Forward_Force;

    // Statement to set the equipped weapon (Pistol = 1, Shotgun = 2, Machingun = 3)
    int weapon = 1; // declaring the variable sets the default weapon

    //Timer
    float timer = 5;//start at 5 so the player can fire immediately

    //gets audio for gunshots
    public AudioClip PistolShot;
    public AudioClip ShotgunShot;
    public AudioClip MGShot;
    public AudioClip WeaponSwitch;

    //gets audio source (player)
    AudioSource audio;


    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
		

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1") && weapon != 1)
        {
            weapon = 1;
            audio.PlayOneShot(WeaponSwitch, 0.9f);
        }
        else if (Input.GetKeyDown("2") && weapon != 2)
        {
            weapon = 2;
            audio.PlayOneShot(WeaponSwitch, 0.9f);
        }
        else if (Input.GetKeyDown("3") && weapon != 3)
        {
            weapon = 3;
            audio.PlayOneShot(WeaponSwitch, 0.9f);
        }


        // Pistol is selected
        if (weapon == 1)
        {
            if (Input.GetMouseButton(0) && timer >= 0.3f)
            {
                //reset timer
                timer = 0;

                //play gunshot
                audio.PlayOneShot(PistolShot, 0.7f);

                //Bullet instantiation
                GameObject Temporary_Bullet_Handler;
                Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;

                //Rotates bullets to correct them
                Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

                //Retrieve the Rigidbody component from the instantiated Bullet and control it.
                Rigidbody Temporary_RigidBody;
                Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

                //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force. 
                Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);

                //Destroy bullets after period of time
                Destroy(Temporary_Bullet_Handler, 1.0f);
            }

            else if (timer < 0.3f)
            {
                timer += Time.deltaTime;
            }//end of else if
        }

        ////////////////////////////////////////////////////////////////////////
        //Shotgun is selected
        else if (weapon == 2)
        {

            if (Input.GetMouseButton(0) && timer >= 1.0f)
            {
                //reset timer
                timer = 0;

                //play gunshot
                audio.PlayOneShot(ShotgunShot, 1.0f);

                //Bullet instantiation
                GameObject Temporary_Bullet_Handler1 = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;
				GameObject Temporary_Bullet_Handler2 = Instantiate(Bullet, Bullet_EmitterRight.transform.position, Bullet_EmitterRight.transform.rotation) as GameObject;
                GameObject Temporary_Bullet_Handler3 = Instantiate(Bullet, Bullet_EmitterLeft.transform.position, Bullet_EmitterLeft.transform.rotation) as GameObject;
                GameObject Temporary_Bullet_Handler4 = Instantiate(Bullet, Bullet_EmitterRight2.transform.position, Bullet_EmitterRight2.transform.rotation) as GameObject;
                GameObject Temporary_Bullet_Handler5 = Instantiate(Bullet, Bullet_EmitterLeft2.transform.position, Bullet_EmitterLeft2.transform.rotation) as GameObject;



                //Rotates bullets to correct them
                //Temporary_Bullet_Handler1.transform.Rotate(Vector3.left * 90);
                //Temporary_Bullet_Handler2.transform.Rotate(Vector3.up*45, Space.Self);
                //Temporary_Bullet_Handler3.transform.Rotate(Vector3.up*-45, Space.Self);


                //Retrieve the Rigidbody component from the instantiated Bullet and control it.
                Rigidbody Temporary_RigidBody1;
                Rigidbody Temporary_RigidBody2;
                Rigidbody Temporary_RigidBody3;
                Rigidbody Temporary_RigidBody4;
                Rigidbody Temporary_RigidBody5;



                Temporary_RigidBody1 = Temporary_Bullet_Handler1.GetComponent<Rigidbody>();
                Temporary_RigidBody2 = Temporary_Bullet_Handler2.GetComponent<Rigidbody>();
                Temporary_RigidBody3 = Temporary_Bullet_Handler3.GetComponent<Rigidbody>();
                Temporary_RigidBody4 = Temporary_Bullet_Handler4.GetComponent<Rigidbody>();
                Temporary_RigidBody5 = Temporary_Bullet_Handler5.GetComponent<Rigidbody>();



                //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force. 
                Temporary_RigidBody1.AddForce(transform.forward * Bullet_Forward_Force);
                Temporary_RigidBody2.AddForce(transform.forward * Bullet_Forward_Force);
                Temporary_RigidBody3.AddForce(transform.forward * Bullet_Forward_Force);
                Temporary_RigidBody4.AddForce(transform.forward * Bullet_Forward_Force);
                Temporary_RigidBody5.AddForce(transform.forward * Bullet_Forward_Force);



                //Destroy bullets after period of time
                Destroy(Temporary_Bullet_Handler1, 0.5f);
                Destroy(Temporary_Bullet_Handler2, 0.5f);
                Destroy(Temporary_Bullet_Handler3, 0.5f);
                Destroy(Temporary_Bullet_Handler4, 0.5f);
                Destroy(Temporary_Bullet_Handler5, 0.5f);



            }
            else if (timer < 1.0f)
            {
                timer += Time.deltaTime;
            }//end of else if
        }

        //////////////////////////////////////////////////////////////////////////////
        // Machinegun is selected
        else if (weapon == 3)
        {
            if (Input.GetMouseButton(0) && timer >= 0.1f)
            {
                //resets timer
                timer = 0;

                //Play gunshot
                audio.PlayOneShot(MGShot, 0.3f);

                //Bullet instantiation
                GameObject Temporary_Bullet_Handler;
                Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;

                //Rotates bullets to correct them
                Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

                //Retrieve the Rigidbody component from the instantiated Bullet and control it.
                Rigidbody Temporary_RigidBody;
                Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

                //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force. 
                Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);

                //Destroy bullets after period of time
                Destroy(Temporary_Bullet_Handler, 0.5f);
            }// end of if

            else if (timer < 0.5f)
            {
                timer += Time.deltaTime;
            }//end of else if

        }// end of else if

    }// end of update

}// end of class
