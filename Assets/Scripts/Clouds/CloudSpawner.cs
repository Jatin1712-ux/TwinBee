using Players;
using UnityEngine;

namespace Clouds
{
    public class CloudSpawner : MonoBehaviour
    {
        public Transform[] spawnpoints;

        public GameObject cloudPrefabs;

    

        public float spawnRate = 10f;

        private void OnEnable()
        {
            InvokeRepeating(nameof(Spawn), spawnRate, Random.Range(7, 13));
        }

        private void OnDisable()
        {
            CancelInvoke(nameof(Spawn));
        }

        private void Spawn()
        {
            if (PlayerPowerUp.isPowerActive == false)
            {
                int randomSpawnpoint = Random.Range(0, spawnpoints.Length * 2) % spawnpoints.Length;

                Instantiate(cloudPrefabs, spawnpoints[randomSpawnpoint].position, transform.rotation);
            }
       
        }
    }
}
