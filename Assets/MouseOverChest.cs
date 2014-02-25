using UnityEngine;
using System.Collections;

public class MouseOverChest : MonoBehaviour {

	 float timer = 0;

	void Update(){
		timer = timer+1*Time.deltaTime;
		if(timer > 3){Destroy (gameObject);}
	}

		void OnMouseEnter()
		{
			//move treasure chest to money and increase money by 100
			
			EnergyManager.energy += 100;
			Debug.Log("MOUSE ENTERED");
		Destroy(gameObject);
		}
	}

