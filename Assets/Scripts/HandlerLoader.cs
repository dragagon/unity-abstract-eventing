using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerLoader : MonoBehaviour {

    protected List<GameMessage> gameMessages = new List<GameMessage>();

	// Use this for initialization
	void Start ()
    {
        foreach (GameMessage message in Resources.LoadAll<GameMessage>(""))
        {
            gameMessages.Add(message);
        }
    }
}
