using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class PlanetAudio : MonoBehaviour
{
    public AudioPeer audioPeer;
    public NoiseSettings noise;
    public GameObject planet;

    public float max = 1f;
    public float min = 0f;

    public float _noiseFrequency;

    public Vector2 _noiseOffset, _noiseSpeed;
    private bool invert;

    private void Start()
    {
        invert = false;
        planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.centre.x = 0;
        planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.baseRoughness = 0;
        planet.GetComponent<Planet>().shapeSettings.noiseLayers[1].noiseSettings.rigidNoiseSettings.centre.z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.centre.x += audioPeer._audioBand[1] * Time.deltaTime;
        planet.GetComponent<Planet>().shapeSettings.noiseLayers[1].noiseSettings.rigidNoiseSettings.centre.z += audioPeer._audioBand[2] * Time.deltaTime;


        planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.baseRoughness += Time.deltaTime * audioPeer._audioBand[4] * audioPeer._audioBand[3] * audioPeer._AmplitudeBuffer;

        if (planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.baseRoughness > 2)
        {
            planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.baseRoughness = 0.1f;
        }

        planet.GetComponent<Planet>().OnColourSettingsUpdated();
        planet.GetComponent<Planet>().OnShapeSettingsUpdated();

        planet.GetComponent<Planet>().autoUpdate = true;
    }
}
