using UnityEngine;

public class CMWMouse : MonoBehaviour
{
	public float speed = 4;

    void Update()
	{
		Vector2 right = new Vector2 (Camera.main.ViewportToWorldPoint (new Vector2 (0.875f, 0)).x, 0),
		left = new Vector2 (Camera.main.ViewportToWorldPoint (new Vector2 (0.125f, 0)).x, 0);

		Vector2 up = new Vector2 (0, Camera.main.ViewportToWorldPoint (new Vector2 (0, 0.875f)).y),
		down = new Vector2 (0, Camera.main.ViewportToWorldPoint (new Vector2 (0, 0.125f)).y);

		Vector3 t = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		if (t.x > right.x) transform.Translate (speed * Time.deltaTime, 0, 0);
		else if (t.x < left.x) transform.Translate (-speed * Time.deltaTime, 0, 0);

		if (t.y > up.y) transform.Translate (0, speed * Time.deltaTime, 0);
		else if (t.y < down.y) transform.Translate (0, -speed * Time.deltaTime, 0);
    }
}
