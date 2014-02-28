using UnityEngine;
using System.Collections;

public enum AIType{
    Cureve,
    Throw
}

public class AI : MonoBehaviour {

	// Use this for initialization
    Transform thisTF;

    public AIType aiType;
    public float speedX;

    void Start () {
        thisTF = transform;
	}
	
	// Update is called once per frame
	void Update () {
        if(aiType == AIType.Cureve){
            float x = thisTF.position.x;
            x += (speedX * Time.deltaTime);
            float y = Mathf.Sin(x);
            thisTF.position = new Vector3(x, y, 0f);
        }
        else if (aiType == AIType.Throw)
        {
            
        }
        
	}
}
