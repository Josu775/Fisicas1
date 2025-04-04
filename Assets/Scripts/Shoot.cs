using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float force = 5000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Clic izquierdo del ratón
        {
            ShootBullet();
        }
    }

    void ShootBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position + transform.forward, transform.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * force);

        Destroy(bullet, 5f);
    }
}