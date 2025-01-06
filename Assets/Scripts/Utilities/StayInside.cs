using UnityEngine;

namespace Utilities
{
	public class StayInside : MonoBehaviour
	{
		// Update is called once per frame
		void Update()
		{
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.65f,1.65f),
				Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);
		}
	}
}
