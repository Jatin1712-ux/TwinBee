using UnityEngine;

namespace Enemies
{
    public class EnemySpawner : MonoBehaviour
    {
        public Transform[] spawnpoints;

        public GameObject[] enemyPrefabs;



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
            int randomSpawnpoint = Random.Range(0, spawnpoints.Length * 2) % spawnpoints.Length;
            int randomenemy = Random.Range(0, enemyPrefabs.Length);

            Instantiate(enemyPrefabs[randomenemy], spawnpoints[randomSpawnpoint].position, transform.rotation);
        }
    }
}
