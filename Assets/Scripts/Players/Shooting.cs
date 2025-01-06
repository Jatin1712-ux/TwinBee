using UnityEngine;
using Utilities;

namespace Players
{
    public class Shooting : MonoBehaviour
    {
        public Bullet BulletPrefab;
        private float fireRate = 0.4f;
        private float nextFire = 0f;

        public void Shoot()
        {
            if (Time.time > nextFire)
            {
                SfxManager.Instance.PlaySound("Shoot");
                nextFire = Time.time + fireRate;
                Bullet bullet = Instantiate(this.BulletPrefab, this.transform.position, Quaternion.identity);
                bullet.Project(this.transform.up);
            } 
        }
    
    }
}
