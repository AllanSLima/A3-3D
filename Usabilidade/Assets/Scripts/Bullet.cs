using UnityEngine;

public class Bullet : MonoBehaviour
{
	public GameObject hitVFX;


   void OnCollisionStay(Collision hit)
   {
		Instantiate(hitVFX, transform.position, transform.rotation);
		Destroy(gameObject);
   }
}
