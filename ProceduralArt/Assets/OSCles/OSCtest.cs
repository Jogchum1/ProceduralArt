using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SharpOSC;

public class OSCtest : MonoBehaviour
{

    UDPListener listener;

    // Start is called before the first frame update
    void Start()
    {
        HandleOscPacket callback = delegate (OscPacket packet)
        {
            var messageReceived = (OscMessage)packet;
            Debug.Log("Received a message!");
        };

        listener = new UDPListener(55555, HandlePacket);
    }

    void HandlePacket(OscPacket packet)
    {
        OscMessage messageReceived = (OscMessage)packet;

        Debug.Log("Received a message: " + messageReceived.Address);
       foreach(object o in messageReceived.Arguments)
        {
            Debug.Log("Arguments" + o);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UDPSender JustinSender = new UDPSender("10.3.4.208", 55555);
            OscMessage message = new OscMessage("/hallo", "Hallo FakeArtist");
            JustinSender.Send(message);
            JustinSender.Close();
        }
    }

    void OnApplicationQuit()
    {
        listener.Close();
    }

    
}
