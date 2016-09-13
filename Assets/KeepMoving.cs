using UnityEngine;
using System.Collections;

public class KeepMoving : MonoBehaviour {

    private Transform tr;
    public float speed = 1f;


    // Use this for initialization
    void Start () {
        tr = GetComponent<Transform>();

    }
	
	// Update is called once per frame
	void Update () {
        if (FlagManager.moveFlg)
        {
            Vector3 toward = tr.TransformDirection(Vector3.forward) * speed;
            tr.position += new Vector3(toward.x, 0, toward.z); ;

        }
    }
}
