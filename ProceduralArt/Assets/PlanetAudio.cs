using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class PlanetAudio : MonoBehaviour
{
    public AudioPeer audioPeer;
    public NoiseSettings noise;
    public GameObject planet;

    public float _noiseFrequency;

    public Vector2 _noiseOffset, _noiseSpeed;



    // Update is called once per frame
    void Update()
    {
        //planet.autoUpdate = true;
        //planet.shapeSettings.noiseLayers[1].noiseSettings.roughness =+ 0.01f;
        //noise.roughness += Time.deltaTime * audioPeer._audioBand[1];
        //noise.roughness += Time.deltaTime * audioPeer._audioBand[1];

        planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.baseRoughness += Time.deltaTime * audioPeer._audioBand[4] * audioPeer._audioBand[3] * audioPeer._AmplitudeBuffer;
        //planet.GetComponent<Planet>().shapeSettings.noiseLayers[1].noiseSettings.strenght += Time.deltaTime * audioPeer._audioBand[3] * audioPeer._AmplitudeBuffer * Time.deltaTime;

        //_noiseOffset = new Vector2(_noiseSpeed.x * Time.deltaTime * audioPeer._audioBand[1], _noiseSpeed.y * Time.deltaTime * audioPeer._audioBand[4]);
        //float noise = (Mathf.PerlinNoise((_noiseOffset.x) * _noiseFrequency, (_noiseOffset.y) * _noiseFrequency));


        //planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.baseRoughness += noise * Time.deltaTime;

        //planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.strenght += Time.deltaTime * audioPeer._audioBand[3] * audioPeer._AmplitudeBuffer * Time.deltaTime;

        planet.GetComponent<Planet>().OnColourSettingsUpdated();
        planet.GetComponent<Planet>().OnShapeSettingsUpdated();

        planet.GetComponent<Planet>().autoUpdate = true;
    }
}
