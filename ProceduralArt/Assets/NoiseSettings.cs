using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NoiseSettings 
{
    public float strenght = 1;
    [Range(1,8)]
    public int numLayers = 1;
    public float baseRoughness = 1;
    public float roughness = 2;
    public float persisence = .5f;
    public Vector3 centre;
    public float minValue;

}