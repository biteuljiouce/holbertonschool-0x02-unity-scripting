using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // move speed
    public float speed;

	// Use this for initialization
	void Start()
	{
        Debug.Log("Start");
        speed = 50f;
    }

	// Update is called once per frame
	void Update()
	{
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("left arrow");
            transform.position += new Vector3(- speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("right arrow");
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("up arrow");
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, 0, - speed * Time.deltaTime);
        }

    }

    // FixedUpdate is when messing with physics
    void FixedUpdate()
	{

	}
}
