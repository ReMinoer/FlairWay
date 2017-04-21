using UnityEngine;

public class SwingController : MonoBehaviour
{
    public Vector3 Direction;
    public float Power;
    public float Drag = 20;

    private void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody>().AddForce(Direction * Power);
	}

    //private void OnCollisionEnter(Collision other)
    //{
    //    GetComponent<Rigidbody>().drag = Drag;
    //    GetComponent<Rigidbody>().angularDrag = Drag;
    //}

    //private void OnCollisionExit(Collision other)
    //{
    //    GetComponent<Rigidbody>().angularDrag = 0;
    //    GetComponent<Rigidbody>().angularDrag = 0;
    //}

    //private void OnCollisionStay(Collision other)
    //{
    //    GetComponent<Rigidbody>().drag = Drag;
    //    GetComponent<Rigidbody>().angularDrag = Drag;
    //}
}
