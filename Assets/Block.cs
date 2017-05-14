
using UnityEngine;

public class Block : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D col)
	{	if (col.tag == "Ball")
		{
			Destroy(gameObject);
		}
	}
}
