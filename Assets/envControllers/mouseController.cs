using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseController : MonoBehaviour {

    RaycastHit hit;
	Ray ray;
	private float rayLenght = 500;
	public Squad test = new Squad();
	
    // Use this for initialization
    void Start () {
		Squad test = new Squad();
		test.createSquad("test",10,15);
		
	}
	
	// Update is called once per frame
	void Update () {

		Select select = new Select();
		//GameObject Player = GameObject.Find("test");

		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray,out hit,rayLenght)){
			//Debug.Log(hit.collider.name);
			if(hit.collider.name == "Terrain"){
				//Player.transform.position = hit.point;
				select.selection(hit,ray,test.unitLeader);
			}
		}

		Debug.DrawRay(ray.origin,ray.direction * rayLenght,Color.yellow);
		//select.selection(hit,ray);
	}
}
