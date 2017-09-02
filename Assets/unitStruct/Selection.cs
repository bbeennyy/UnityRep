using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour {

	public GameObject selectedObject;
	
	
	
	public float speed = 50f;
	// Use this for initialization
	Squad n = new Squad();
	void Start () {
		//selectedObject.AddComponent<unitController>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		RaycastHit hitInfo;
		Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(r,out hitInfo)){
				
				
				//GameObject test =	Component.GetComponentInParent(hitInfo);
				GameObject hitObject = hitInfo.transform.root.gameObject;
				//Debug.Log("asta e " + hitObject.name);
				SelectObject(hitObject);
				Debug.Log(selectedObject);
				//ClearSelection();
				
				if(selectedObject != null )
				{
					//n.moveSquad();
				}else
				{
					//Debug.Log(selectedObject);
					selectedObject.AddComponent<Squad>();
				}
				//selectedObject.AddComponent<unitController>();
			
		}else{
			ClearSelection();
		}

		if(selectedObject != null ){
			//n.moveSquad();
		}else{
			selectedObject.AddComponent<Squad>();
		}
		
	}
	void FixedUpdate(){
		
	}


	public void SelectObject(GameObject obj){
		if(Input.GetMouseButtonDown(0)){
		if(selectedObject != null){
			if(obj == selectedObject)
				return;

				ClearSelection();
				
		}
		selectedObject = obj;
		Renderer[] rs = selectedObject.GetComponentsInChildren<Renderer>();
		foreach(Renderer r in rs){
			Material m = r.material;
			m.color = Color.green;
			r.material = m;
			}
		}
	}
	public void ClearSelection(){
		if(selectedObject == null)
			return;
		
		Renderer[] rs = selectedObject.GetComponentsInChildren<Renderer>();
		foreach(Renderer r in rs){
			Material m = r.material;
			m.color = Color.white;
			r.material = m;
			
			
		}
		selectedObject = null;
	}
	

}
