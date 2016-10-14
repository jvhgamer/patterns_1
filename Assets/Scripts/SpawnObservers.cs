using UnityEngine;
using System.Collections;

public class SpawnObservers : MonoBehaviour {

	public GameObject observer; //incoming objects
	public Vector3 spawnValues; //range of values to spawn
	public double Timer;
	
	// Update is called once per frame
	void Update () {
		Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), Random.Range (-spawnValues.y, spawnValues.y), spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;



		if (Timer < Time.time) {
			//Instantiate (observer, spawnPosition, spawnRotation);
			Object o = Instantiate (observer, spawnPosition, spawnRotation);
			GameObject go = (GameObject)o;
			MoveObservers s = go.GetComponent<MoveObservers> ();
			int x = Random.Range (0, 3);

            if (s.Equals(null))
            {
                return;
            }

			switch (x)
			{
			case 0:
				s.spheremove = new JitterMovement ();
				break;
			case 1:
				s.spheremove = new ForwardMovement ();
				break;
			case 2:
				s.spheremove = new AngularMovement ();
				break;
			}

			Timer = Time.time + 0.01;
		}

	}

	void Awake()
	{
		Timer = Time.time + 0.01;
	}

}
