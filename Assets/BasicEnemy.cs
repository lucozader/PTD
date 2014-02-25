using UnityEngine;
using System.Collections;

public class BasicEnemy : MonoBehaviour {
	public GameObject explosion;

	public float health = 10;
	public static float increase1 = 0;
	public GameObject chest;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	
	void OnCollisionEnter(Collision collision){
		if(collision.collider.tag == "Mortar")
		{
			//health= health - (health+ increase1*(health/100));
			Instantiate(explosion, collision.contacts[0].point, Quaternion.identity);
			Destroy(collision.collider.gameObject);
		}
		if(collision.collider.tag == "RapidBullet")
		{
			//health= health - (health+ increase1*(health/100));
			health = health-1;
			Destroy(collision.collider.gameObject);
		}
		if(collision.collider.tag == "Bullet")
		{
			//health= health - (health+ increase1*(health/100));
			health = health-2;
			Destroy(collision.collider.gameObject);
		}
			if(collision.collider.tag == "Explosion")
		{
			health = health -5;
			//Destroy(collision.collider.gameObject);
		}
	
		if(health <= 0)
		{
			Destroy(collision.collider.gameObject);
		
			
		

				//EnergyManager.energy += energyBonus;
				//	Quaternion pathObjectOrientation = Quaternion.LookRotation(pathPoints[0].transform.position - transform.position);
				GameObject test = Instantiate(chest, transform.position, Quaternion.identity) as GameObject;

			Destroy(gameObject);
		}
	}
}
