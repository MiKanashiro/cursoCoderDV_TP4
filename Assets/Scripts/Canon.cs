using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float delayTime = 1.5f;
    public float durationTime = 2f;

    void Start()
    {

    }


    void Update()
    {
        Shoot();
        InvokeRepeating("Shoot", durationTime, delayTime);


        durationTime -= Time.deltaTime;

        if (durationTime < 0)
        {
          Destroy(bulletPrefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            bulletPrefab.transform.localScale = 2 * bulletPrefab.transform.localScale;
        }

    }

    public void Shoot()
    {
        Instantiate(bulletPrefab, transform);
    }
}