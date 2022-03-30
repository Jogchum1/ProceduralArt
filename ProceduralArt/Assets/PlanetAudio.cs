using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class PlanetAudio : MonoBehaviour
{
    public AudioPeer audioPeer;
    public NoiseSettings noise;
    public GameObject planet;


    
    
    // Update is called once per frame
    void Update()
    {
        //planet.autoUpdate = true;
        //planet.shapeSettings.noiseLayers[1].noiseSettings.roughness =+ 0.01f;
        //noise.roughness += Time.deltaTime * audioPeer._audioBand[1];
        //noise.roughness += Time.deltaTime * audioPeer._audioBand[1];
        planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.roughness += audioPeer._audioBand[1];
        planet.GetComponent<Planet>().OnColourSettingsUpdated();
        planet.GetComponent<Planet>().OnShapeSettingsUpdated();

        planet.GetComponent<Planet>().autoUpdate = true;
    }
}
