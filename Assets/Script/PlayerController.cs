using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody rigidBody;
    SpriteRenderer spriteRenderer;
    Animator animator;

	void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
        spriteRenderer = gameObject.GetComponentInChildren<SpriteRenderer>();
    }
	
	void FixedUpdate()
    {
        Vector3 axisV3, scaleV3;
        axisV3 = getPlayerAxis();
        scaleV3 = new Vector3(0.035f, 0, 0.035f);
        rigidBody.MovePosition(transform.position + Vector3.Scale(axisV3, scaleV3));
	}

    void Update ()
    {
        UpdateAnimation();
    }

    private Vector3 getPlayerAxis()
    {
        return new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
    }

    private void UpdateAnimation()
    {
        Vector3 v3 = getPlayerAxis();
        float speed = v3.magnitude;

        UpdateFlip();
    }

    private void UpdateFlip()
    {
        Vector3 v3 = getPlayerAxis();
        if (v3.x > 0)
            spriteRenderer.flipX = false;
        else if (v3.x < 0)
            spriteRenderer.flipX = true;
    }
}
