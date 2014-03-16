using UnityEngine;
using System.Collections;

public class Starter : MonoBehaviour {
	bool once = false;
	float timer = 0;
	public AudioClip startSound;
	void Update(){
		if(once==true){
			timer = timer+1*Time.deltaTime;}

		if(timer>0.8f){
			Application.LoadLevel("scene1");}
		
		

	}
	void OnMouseEnter()
	{
		renderer.material.color = Color.red;
		//Debug.Log("MOUSE ENTERED");
	}
	
	void OnMouseExit()
	{
		renderer.material.color = Color.yellow;
		
	}
	
	void OnMouseUp()
	{
		audio.PlayOneShot(startSound);
		once = true;
	}
}