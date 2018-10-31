using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeGenerator : MonoBehaviour {

    public ExplodeEffectController exploder;
    public float explodedSpeed;
    public float explodedTime;
    public float forceSize;
    private bool does;

    void Start()
    {
        does = true;
    }

    void OnApplicationQuit()
    {
        does = false;
    }

    void OnDestroy()
    {
        if (does)
        {
            ExplodeEffectController boom = Instantiate(exploder, transform.position, Quaternion.identity) as ExplodeEffectController;
            boom.explodedSpeed = explodedSpeed;
            boom.explodedTime = explodedTime;
        }
    }

    public void ForceBombGenerator()
    {
        ExplodeEffectController boom = Instantiate(exploder, transform.position, Quaternion.identity) as ExplodeEffectController;
        boom.ForceBombed(forceSize);
    }
}
