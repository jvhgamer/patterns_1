using UnityEngine;
using System.Collections;

public class MoveObservers : MonoBehaviour {

	public ObserverMovement spheremove;

	void FixedUpdate()
	{
        /*int x = Random.Range (-1, 3);
		Debug.Log (x);
		switch (x)
		{
		case 0:
			formove.move (transform);
			break;
		case 1:
			angmove.move (transform);
			break;
		case 2:
			jitmove.move (transform);
			break;
		}*/

        /*if (observers[i].Equals(null))
        {
                observers.Remove(observers[i]);
                return;
        }*/
        if (spheremove == null )
            return;
        spheremove.move (transform);
	}

}
