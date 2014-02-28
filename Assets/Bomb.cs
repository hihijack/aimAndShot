using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{

    public void OnAnimEnd()
    {
        DestroyObject(gameObject);
    }
}
