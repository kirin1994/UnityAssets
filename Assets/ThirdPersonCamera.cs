using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

	private const float Y_ANGLE_MIN = 15.0f;
	private const float Y_ANGLE_MAX = 40.0f;

	public Transform lookAt;
	public Transform camTransform;

	private Camera cam;

	private float distance = 12.0f;
	private float CurrentX = 0.0f;
	private float CurrentY = 0.0f;
	private float sensitvityX = 4.0f;
	private float sensitvityY = 0.3f;

	private void Start()
	{
		camTransform = transform;
		cam = Camera.main;

	}

	private void Update()
	{
		CurrentX += Input.GetAxis("Mouse X")*sensitvityX;
		CurrentY += Input.GetAxis("Mouse Y")*sensitvityY;

		CurrentY = Mathf.Clamp(CurrentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
	}

	private void LateUpdate()
	{
		Vector3 dir = new Vector3(0, 0, -distance);
		Quaternion rotation = Quaternion.Euler(CurrentY, CurrentX, 0);
		camTransform.position = lookAt.position + rotation * dir;
		camTransform.LookAt(lookAt.position);
	}
}
