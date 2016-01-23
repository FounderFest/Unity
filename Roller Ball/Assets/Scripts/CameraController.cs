using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        // Get difference between camera and player(sphere)
        // X, Y, Z
        offset = transform.position - player.transform.position;
        
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
        
	}
}
