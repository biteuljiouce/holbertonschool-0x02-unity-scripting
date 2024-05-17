using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // move speed
    public float speed;

    // health
    public float health;

    // score
    private int score = 0;

    private Direction _currentDir;
    private enum Direction {
        left,
        right,
        up,
        down,
        left_up,
        right_up,
        left_down,
        right_down
    };

	// Use this for initialization
	void Start()
	{
        Debug.Log("Start");
        speed = 10f;
        health = 5;
    }

	// Update is called once per frame
	void Update()
	{
        // horizontal / vertical

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Q))
        {
            _currentDir = Direction.left;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            _currentDir = Direction.right;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z))
        {
            _currentDir = Direction.up;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            _currentDir = Direction.down;
        }

        // diagonal

        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            _currentDir = Direction.right_down;
        }
        
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            _currentDir = Direction.left_down;
        }

        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            _currentDir = Direction.right_up;
        }

        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            _currentDir = Direction.left_down;
        }

    }

    // FixedUpdate is when messing with physics
    void FixedUpdate()
	{
        Vector3 moves = new Vector3();
        if (_currentDir == Direction.left)
        {
            moves += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if (_currentDir == Direction.right)
        {
            moves += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (_currentDir == Direction.up)
        {
            moves += new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (_currentDir == Direction.down)
        {
            moves += new Vector3(0, 0, -speed * Time.deltaTime);
        }
        if (_currentDir == Direction.right_down)
        {
            moves += new Vector3(speed / 1.5f * Time.deltaTime, 0, -speed / 2 * Time.deltaTime);
        }

        if (_currentDir == Direction.left_down)
        {
            moves += new Vector3(-speed / 1.5f * Time.deltaTime, 0, -speed / 2 * Time.deltaTime);
        }

        if (_currentDir == Direction.right_up)
        {
            moves += new Vector3(speed / 1.5f * Time.deltaTime, 0, speed / 2 * Time.deltaTime);
        }
        if (_currentDir == Direction.left_up)
        {
            moves += new Vector3(-speed / 1.5f * Time.deltaTime, 0, -speed / 2 * Time.deltaTime);
        }
        transform.position += moves;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        { 
            score++;
            Debug.Log("Score: " + score);
            Object.Destroy(other.gameObject);
        }
        else if (other.tag == "Trap")
        {
            health--;
            Debug.Log("Health: " + health);
        }
    }
}

// REFAIRE AVEC RIGIDBODY ET PHYSICS, CAR MOUVEMENT PAS SUPER FLUIDE COMME DANS les VIDEOs des énoncés