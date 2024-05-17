using UnityEngine;

public class TeleporterController : MonoBehaviour {

    // teleporter works as pair : one source (this), one target
    public GameObject TeleporterTarget;

    // is the teleporter in service (ie. is functioning)
    public bool inService = false;

	// Use this for initialization
	void Start () {
	}
	

    void OnTriggerExit(Collider other)
    {
        inService = false;
    }
}
