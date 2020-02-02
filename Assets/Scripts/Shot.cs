using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float shotSpeed = 500;
    [SerializeField] int shotInterval;
    [SerializeField] private CriAtomSource EnemyCAS;
    void Update ()
    {
        var num = Random.Range (0, shotInterval);

        if (num == 0)
        {
            var bullet = (GameObject) Instantiate (bulletPrefab, this.transform.position + this.transform.forward, Quaternion.identity);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody> ();
            bulletRb.AddForce (transform.forward * shotSpeed);
            EnemyCAS.Play();
        }
    }
}