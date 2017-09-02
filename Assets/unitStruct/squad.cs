using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squad: MonoBehaviour {

	private string nume;
	private float speed ;
	public int units;
	
	public GameObject unitLeader;


	public string Name
	{
		get { return nume; }
		set { nume = value; }
	}
	public float Speed
	{
		get { return speed; }
		set { speed = value; }
	}
	public int Units
	{
		get{ return units;}
		set{ units = value;}
	}

    public GameObject UnitLeader 
	{ 	
		get { return unitLeader;} 
		set { unitLeader = value;} 
	}

   



    public void createSquad(string name,float speed,int units,GameObject unitleader = null){
		this.Name = name;
		this.Speed = speed;
		this.Units = units;
		this.UnitLeader =  unitleader;

		

		//creates an empty object with name(should be parent to soldiers)
		unitleader  = new GameObject(name);
		//adding script to leader aka empty object
		unitleader.AddComponent<Select>();
		//unitleader.AddComponent<Rigidbody>();
	    //unitleader.AddComponent<UnitController>();
		GameObject [] n = new GameObject[units];
		
		int a;
		GameObject [,] c = new GameObject[3,5];

		for(a = 0;a < units;a++){
			//creates [units] game objects
			n[a] = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			//[units] are child to the empty objects
			n[a].transform.parent = unitleader.transform;
			//assgin position for the number of objects create i e [0,0]= n[a](GameObject.CreatePrimitive);
			// i might need to hardcode this 
			//c[0,0] = n[0]
			//c[0,1] = n[1]
			//c[0,2] = n[2]
			//c[0,3] = n[3]
			//c[0,4] = n[4]
			//c[1,0] = n[5]
			//c[1,1] = n[6]
			//c[1,2] = n[7]
			//c[1,3] = n[8]
			//c[1,4] = n[9]
			//c[2,0] = n[10]
			//c[2,1] = n[11]
			//c[2,2] = n[12]
			//c[2,3] = n[13]
			//c[2,4] = n[14]
			
		

			/*for(i = 0,j=0;j<5;j++){
				c[i,j] = n[a];
				Debug.Log(c[i,j] = n[a]);
			}*/

			
		}
		
		

	}
	
}