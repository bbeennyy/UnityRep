using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select: MonoBehaviour{
	public GameObject selectedObject;
	public RaycastHit Hit;
	public Ray Ray;
	public bool selected;

	
	
	public void selection(RaycastHit hit,Ray ray,GameObject obj = null){

			this.Hit = hit;
			this.Ray = ray;
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray,out hit)){
				GameObject hitObject = hit.transform.root.gameObject;
				Selected(hitObject);
			}else{
			ClearSelection();
		}
		
	}
	public void Selected(GameObject obj){
		this.selectedObject = obj;
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

