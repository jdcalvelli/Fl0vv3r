using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace extOSC.Examples
{
  public class OSCtoAnimator : MonoBehaviour
  {
    Animator m_Animator;

    private OSCReceiver _receiver;
    private const string _oscAddress = "/flower";

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();

        // Creating a receiver.
  			_receiver = gameObject.AddComponent<OSCReceiver>();

  			// Set local port.
  			_receiver.LocalPort = 12345;

  			// Bind "MessageReceived" method to special address.
  			_receiver.Bind(_oscAddress, MessageReceived);

    }

    // Update is called once per frame
    void Update()
    {
    }

    protected void MessageReceived(OSCMessage message)
    {
      Debug.Log(message);
    }

  }
}
