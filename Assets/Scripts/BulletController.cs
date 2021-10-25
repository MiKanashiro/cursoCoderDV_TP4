using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speedBullet = 0.2f;
    public Vector3 direction = Vector3.right;
    public float damageBullet = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedBullet * Time.deltaTime * direction);
    }
}