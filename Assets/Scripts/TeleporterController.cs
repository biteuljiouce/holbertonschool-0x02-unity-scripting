using UnityEngine;

public class TeleporterController : MonoBehaviour {

    // teleporter works as pair : one source (this), one target
    public GameObject TeleporterTarget;

    // is the teleporter in service (ie. is functioning)
    public bool inService;

	// Use this for initialization
	void Start () {
        inService = true;
    }
	

    void OnTriggerExit(Collider other)
    {
        inService = true;
    }
}
