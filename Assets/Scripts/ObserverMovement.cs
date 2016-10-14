using UnityEngine;
using System.Collections;

[System.Serializable]
public abstract class ObserverMovement
{
	public abstract void move(Transform t);
}

[System.Serializable]
public class AngularMovement : ObserverMovement
{
	public override void move(Transform t)
	{
		t.position = t.position + t.forward * 1.5f;
		Vector3 v = t.rotation.eulerAngles;
		v.z += UnityEngine.Random.Range (-3, 4);
		v.y += UnityEngine.Random.Range (-3, 4);
		v.x += UnityEngine.Random.Range (-3, 4);
		t.rotation = Quaternion.Euler (v);
	
		//Others can change the angle they point by up to 3 Euler degrees each axis each time step (FixedUpdate)

	}
}

[System.Serializable]
public class ForwardMovement: ObserverMovement
{
	public override void move(Transform t)
	{
		t.position = t.position + t.forward * 1.5f;
	}
}

[System.Serializable]
public class JitterMovement : ObserverMovement
{
	public override void move(Transform t)
	{
		Vector3 movestr = new Vector3 (Random.Range (-0.03f, 0.03f), Random.Range (-0.03f, 0.03f), Random.Range (-0.03f, 0.03f));

		t.position = t.position + movestr + t.forward * 1.5f;
	}
}


