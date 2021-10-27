using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject bulletPrefab;
    //public float intervalTime = 1.5f;

    void Start()
    {
        
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.K))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        Instantiate(bulletPrefab, transform);
    }
}