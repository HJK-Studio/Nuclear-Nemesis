using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public GameObject muzzleFlashPrefab;
    // public GameController GameController;
    public int count = 1;
    public int count2 = 1;
    public Slider slider;
    public float bulletSpeed;
    public bool isRed;
    public float DestroyTime;
    public AudioSource shoot;

    void reducecount()
    {
        count--;
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && count > 0)
        {
            bulletSpeed = (isRed ? slider.value * 20 : ((1-slider.value) * 20));
            if(Mathf.Floor(bulletSpeed) != 0 && count2 > 0)
            {
                Shoot();
                muzzleFlash();
            }
            count2--;
            Invoke("reducecount", 3f);
        }
        
    }

    void muzzleFlash()
    {
        GameObject effect = Instantiate(muzzleFlashPrefab, firePoint.position, firePoint.rotation);
        Destroy(effect, 0.14f);
    }

    void Shoot()
    {
        // Instantiate a new bullet
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Access the Rigidbody2D component of the bullet
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        // Apply force to the bullet
        rb.AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);
        shoot.Play();

        Destroy(bullet, DestroyTime);
    }
}
