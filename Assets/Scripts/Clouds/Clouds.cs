using UnityEngine;

namespace Clouds
{
    public class Clouds : MonoBehaviour
    {
        public float speed = 5f;

        private float _bottomEdge;

        public GameObject bellPrefab;

        bool _doneOnce = false;
        private void Start()
        {
            if (Camera.main != null) _bottomEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).y - 1f;
        }

        private void Update()
        {
            transform.position += Vector3.down * (speed * Time.deltaTime);

            if(transform.position.y < _bottomEdge)
            {
                Destroy(gameObject);
            }
        }
     
        private void BellSpawn() 
        {
            Instantiate(bellPrefab, transform.position, Quaternion.identity);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.CompareTag("Bullet") && _doneOnce == false)
            {
                BellSpawn();
                _doneOnce = true;
            }
        }

    }
}
