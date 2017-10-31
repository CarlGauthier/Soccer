using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Height2D : MonoBehaviour {

    public float offset;
    public Transform transformToFollow;

	void FixedUpdate () {
        transform.localPosition = new Vector3(0, transformToFollow.position.y + offset);
    }
}
