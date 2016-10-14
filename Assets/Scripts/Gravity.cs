using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

	public ArrayList observers = new ArrayList();
	public GameObject o;


	void FixedUpdate()
	{
		for (int i = 0; i < observers.Count; i++) 
		{
			if (observers[i].Equals(null)) {
				observers.Remove (observers [i]);
				return;
			}
				o = (GameObject)observers[i];
				Vector3 diff = o.transform.position - transform.position;
				diff.Normalize ();
				o.transform.position -= diff * .9f;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Planet")
			return;
		observers.Add (other.gameObject);
	}

	void OnTriggerExit(Collider other)
	{
		observers.Remove (other.gameObject);
	}
}
