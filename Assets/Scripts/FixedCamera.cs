using UnityEngine;

public class FixedCamera : MonoBehaviour
{
    public Transform Target;
    private Vector3 _relativePosition;

    private void Start()
    {
        _relativePosition = transform.position - Target.position;
    }

	private void Update()
    {
		transform.position = Target.position + _relativePosition;
	}
}
