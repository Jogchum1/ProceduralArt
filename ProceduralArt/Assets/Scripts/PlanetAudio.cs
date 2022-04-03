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
    }

    // Update is called once per frame
    void Update()
    {
        //planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.centre.x += 0.01f * Time.deltaTime;


        planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.baseRoughness += Time.deltaTime * audioPeer._audioBand[4] * audioPeer._audioBand[3] * audioPeer._AmplitudeBuffer;

        //for (int i = 0; i < audioPeer._audioBand.Length; i++)
        //{
        //    planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.baseRoughness += Mathf.Clamp(audioPeer._audioBand[i] * audioPeer._AmplitudeBuffer * Time.deltaTime, min, max);
        //    if (planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.baseRoughness > max)
        //    {
        //        planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.baseRoughness = 0;
        //    }
        //}


        //planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.baseRoughness += Mathf.Clamp(Time.deltaTime * audioPeer._audioBand[4] / 10, 0, 5);

        //if (audioPeer._audioBand[4] < 0.04 && planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.baseRoughness >= 0)
        //{
        //    planet.GetComponent<Planet>().shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.baseRoughness -= 0.02f * Time.deltaTime;
        //}




        planet.GetComponent<Planet>().OnColourSettingsUpdated();
        planet.GetComponent<Planet>().OnShapeSettingsUpdated();

        planet.GetComponent<Planet>().autoUpdate = true;
    }
}
