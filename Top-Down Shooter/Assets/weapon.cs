using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public float damage = 30;
    public float fireRate = 1;
    public float range = 15;
    public GameObject muzzleFlash;
    public AudioClip shotSFX;
    public AudioSource _audioSourse;

    public GameObject pos;
    public Transform Pos;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }

    void Shoot ()
    {
        // _audioSourse.PlayOneShot(shotSFX);
        //Instantiate(muzzleFlash, Pos.position,Pos.rotation);  - создать и добавить частицы после переписать эту строчку ( на вкл и выкл)

        RaycastHit hit;



        if (Physics.Raycast(pos.transform.position, pos.transform.forward, out hit, range))
        {
            Debug.DrawLine(pos.transform.position, hit.point , Color.red);
        }




    }
}
