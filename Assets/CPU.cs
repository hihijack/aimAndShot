using UnityEngine;
using System.Collections;

public class CPU : MonoBehaviour {

   public Camera cameraMain;
    // Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
	    if(Input.GetMouseButtonDown((0))){
            GameObject gobjAimPoint = Tools.LoadResourcesGameObject("Prefabs/aim_point");
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 0f;
            Vector3 touchPos = cameraMain.ScreenToWorldPoint(mousePos);
            touchPos.z = 0f;
            gobjAimPoint.transform.position = touchPos;
        }
	}
}
