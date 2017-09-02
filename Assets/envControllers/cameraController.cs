using UnityEngine;

public class cameraController : MonoBehaviour {

	public float panSpeed = 100f;
	public float panBorderThickness = 100f;
	public Vector2 panLimit;

	public float scrollSpeed = 20f;
	public float minY = 20f;
	public float maxY = 120f;

	
	// Update is called once per frame
	void Update () {

		Vector3 pos = transform.position;

			if(Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness && Input.mousePosition.y < Screen.height)
			{
				pos.z += panSpeed * Time.deltaTime;
			}
			
			if(Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness && Input.mousePosition.y > 0)
			{
				pos.z -= panSpeed * Time.deltaTime;
			}
			if(Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness && Input.mousePosition.x < Screen.width)
			{
				pos.x += panSpeed * Time.deltaTime;
			}
			if(Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness && Input.mousePosition.x > 0)
			{
				pos.x -= panSpeed * Time.deltaTime;
			}
			//
			
			//scroll wheel
			float scroll = Input.GetAxis("Mouse ScrollWheel");
			pos.y -= scroll * scrollSpeed * 100f * Time.deltaTime;
			//limit on sides
			pos.x = Mathf.Clamp(pos.x,-panLimit.x,panLimit.x);
			pos.z = Mathf.Clamp(pos.z,-panLimit.y,panLimit.y);
			//limit on scroll
			pos.y = Mathf.Clamp(pos.y,minY,maxY);
			//limit for mouse

			
			transform.position = pos;
			
	}
}
