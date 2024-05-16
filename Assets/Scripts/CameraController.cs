using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private float offset = 30;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + new Vector3(0, offset, 0);
	}
}
