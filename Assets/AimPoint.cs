using UnityEngine;
using System.Collections;

public class AimPoint : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnAimEnd()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        GameObject[] enemyS = GameObject.FindGameObjectsWithTag("Emeny");
        GameObject gobjToKill = null;
        foreach (GameObject item in enemyS)
        {
            Bounds boundEnemy = item.transform.renderer.bounds;
            Bounds boundAim = sr.bounds;
            if (boundAim.Intersects(boundEnemy))
            {
                // bomb
                GameObject gobjBomb = Tools.LoadResourcesGameObject("Prefabs/bomb");
                gobjBomb.transform.position = transform.position;
                // kill enemy
                gobjToKill = item;
            }
        }
        if (gobjToKill != null)
        {
            DestroyObject(gobjToKill);
        }
        DestroyObject(gameObject);
    }
}
