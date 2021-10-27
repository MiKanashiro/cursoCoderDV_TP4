using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speedBullet = 5f;
    public Vector3 direction = Vector3.right;
    public float damageBullet = 0.1f;

    public float durationTime = 2f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedBullet * Time.deltaTime * direction);

        durationTime -= Time.deltaTime;

        if (durationTime < 0)
        {
            Destroy(this.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = 2 * transform.localScale;
        }
    }
}