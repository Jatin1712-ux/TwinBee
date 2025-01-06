using UnityEngine;

namespace Enemies
{
    public class RandomShoot : MonoBehaviour
    {
        public Transform[] shootpoints;
        public GameObject bullet;
        public float sprate = 6;

        private void OnEnable()
        {
            InvokeRepeating(nameof(Shoot), sprate, Random.Range(3, 7));
        }
        private void OnDisable()
        {
            CancelInvoke(nameof(Shoot));
        }

        public void Shoot()
        {
            int randomSp = Random.Range(0, shootpoints.Length * 2) % shootpoints.Length;
            Instantiate(bullet, shootpoints[randomSp].position, Quaternion.identity);
        }
    }
}
