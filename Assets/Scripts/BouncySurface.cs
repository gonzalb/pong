using UnityEngine;

public class BouncySurface : MonoBehaviour 
{
	public float bounceStrength;
	public string sound;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Ball ball = collision.gameObject.GetComponent<Ball>();

		if (ball != null)
		{
			Vector2 normal = collision.contacts[0].normal;
			ball.AddForce(-normal * this.bounceStrength);
			SoundManager.PlaySound(sound);	 
		} 
	}
}
