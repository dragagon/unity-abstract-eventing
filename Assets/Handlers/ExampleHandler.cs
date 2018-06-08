using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleHandler : GameMessageHandler
{
    protected override void OnHandleMessage(Dictionary<byte, object> parameters, string debugMessage, int returnCode)
    {
        Debug.Log("Handing Message");
    }
}
