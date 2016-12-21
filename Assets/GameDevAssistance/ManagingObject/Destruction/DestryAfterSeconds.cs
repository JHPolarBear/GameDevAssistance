using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestryAfterSeconds : MonoBehaviour {

    public float Time;

    //Count down from start and destroy object.
    IEnumerator Start()
    {
        yield return new WaitForSeconds(Time);
        Destroy(gameObject);
    }
}
