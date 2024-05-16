using UnityEngine;

public class Rotator : MonoBehaviour {

    //public float rotationSpeed;
    public float degreesPerSecond;

    // Use this for initialization
    void Start () {
        //rotationSpeed = 2f;
        degreesPerSecond = 45.0f;
    }
	
	// Update is called once per frame
	void Update () {
        // transform.localEulerAngles += new Vector3(0, 1, 0) * rotationSpeed;
        transform.Rotate(degreesPerSecond * Time.deltaTime, 0, 0);
    }
}
