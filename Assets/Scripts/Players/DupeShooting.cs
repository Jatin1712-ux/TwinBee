using UnityEngine;

namespace Players
{
    public class DupeShooting : MonoBehaviour
    {
        public Bullet BulletPrefab;
        public float fireRate = 0.4f;
        public float nextFire = 0f;

        public void Shoot()
        {
            if(Time.time > nextFire)
            {
                if (PlayerPowerUp.Power == true)
                {
                    nextFire = Time.time + fireRate;
                    Bullet bullet = Instantiate(this.BulletPrefab, this.transform.position, Quaternion.identity);
                    bullet.Project(this.transform.up);
                }
            }
        }

    }
}
