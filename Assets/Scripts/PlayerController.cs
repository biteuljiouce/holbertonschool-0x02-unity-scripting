using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // move speed
    public float speed;

    // score
    private int score = 0;

    private KeyCode _currentKey;

	// Use this for initialization
	void Start()
	{
        Debug.Log("Start");
        speed = 10f;
    }

	// Update is called once per frame
	void Update()
	{
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Debug.Log("left arrow");
            _currentKey = KeyCode.LeftArrow;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Debug.Log("right arrow");
            _currentKey = KeyCode.RightArrow;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("up arrow");
            _currentKey = KeyCode.UpArrow;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Debug.Log("down arrow");
            _currentKey = KeyCode.DownArrow;
        }

    }

    // FixedUpdate is when messing with physics
    void FixedUpdate()
	{
        if (_currentKey == KeyCode.LeftArrow)
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if (_currentKey == KeyCode.RightArrow)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (_currentKey == KeyCode.UpArrow)
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (_currentKey == KeyCode.DownArrow)
        {
            transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        { 
            score++;
            Debug.Log("score: " + score);
            Object.Destroy(other.gameObject);
        }
    }
}
