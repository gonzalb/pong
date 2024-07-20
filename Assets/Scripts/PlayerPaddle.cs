using UnityEngine;

public class PlayerPaddle : Paddle 
{
	private Vector2 _direction;
	public int player;

	private void Update()
	{
		if (player == 1)
		{
			if (Input.GetKey(KeyCode.W))
			{
				_direction = Vector2.up;
			}
			else if (Input.GetKey(KeyCode.S))
			{
				_direction = Vector2.down;
			}
			else
			{
				_direction = Vector2.zero;
			}
		}

		else if (player == 2)
		{
			if (Input.GetKey(KeyCode.UpArrow))
			{
				_direction = Vector2.up;
			}
			else if (Input.GetKey(KeyCode.DownArrow))
			{
				_direction = Vector2.down;
			}
			else
			{
				_direction = Vector2.zero;
			}
		}
	}

	private void FixedUpdate()
	{
		if (_direction.sqrMagnitude != 0)
		{
			_rigidbody.AddForce(_direction * this.speed);
		}
	}	
}
