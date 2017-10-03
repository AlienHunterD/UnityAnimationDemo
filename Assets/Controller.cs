using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    Transform _transform;
    Vector3 _direction = new Vector3(-1f, 0f, 0f);

    // Public variables
    public float speed = 1.5f;


    //Use this for initialization
    void Start () {
        _transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        float deltaT = Time.deltaTime;
		if(Input.GetKey(KeyCode.A)) // Move to the left
        {
            _transform.Translate(_direction * speed * deltaT);
        }
        if (Input.GetKey(KeyCode.D)) // Move to the left
        {
            _transform.Translate(-_direction * speed * deltaT);
        }

        if (_transform.position.x < -4)
            _transform.position = new Vector3(-4, 0, 0);

        if (_transform.position.x > 4)
            _transform.position = new Vector3(4, 0, 0);


    }
}
