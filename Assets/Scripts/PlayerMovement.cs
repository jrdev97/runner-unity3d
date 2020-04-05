using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float force = 200f;

	private void FixedUpdate()
	{
		Rigidbody player;

		player = GetComponent<Rigidbody>();

		// Move player on the Z axis (sideways)
		if (Input.GetKey(KeyCode.RightArrow))
		{
			player.AddForce(force * Time.fixedDeltaTime, 0f, 0f, ForceMode.VelocityChange);
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			player.AddForce(-force * Time.fixedDeltaTime, 0f, 0f, ForceMode.VelocityChange);
		}
		else if (Input.GetKey(KeyCode.UpArrow))
		{
			player.AddForce(0f, 50 * force * Time.fixedDeltaTime, 0f, ForceMode.Impulse);
		}
	}
}
