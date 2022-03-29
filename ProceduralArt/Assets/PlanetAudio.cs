using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetAudio : MonoBehaviour
{
    public AudioPeer audioPeer;
    public NoiseSettings noise;
    public Planet planet;
    
    // Update is called once per frame
    void Update()
    {
        planet.autoUpdate = true;
        planet.shapeSettings.noiseLayers[1].noiseSettings.roughness =+ 0.01f;
        //noise.roughness += Time.deltaTime * audioPeer._audioBand[1];
        //noise.roughness += Time.deltaTime * audioPeer._audioBand[1];
    }
}
