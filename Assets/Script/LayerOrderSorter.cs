using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerOrderSorter : MonoBehaviour {

    SpriteRenderer spriteRenderer;
    public Transform origin;

	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (origin == null)
            origin = transform;
	}
	
	protected virtual void Update () {
        spriteRenderer.sortingOrder = -(int)(origin.position.z * 12);
    }
}