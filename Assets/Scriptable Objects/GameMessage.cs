using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu]
public class GameMessage : ScriptableObject
{
    public MessageOperationCode code;
    public MessageSubCode subCode;

    private List<GameMessageHandler> handlers = new List<GameMessageHandler>();

    public void Subscribe(GameMessageHandler handler)
    {
        handlers.Add(handler);
    }

    public void Unsubscribe(GameMessageHandler handler)
    {
        handlers.Remove(handler);
    }

    public void Notify(Dictionary<byte, object> parameters, string debugMessage = "", int returnCode = 0)
    {
        for(int i = handlers.Count-1; i >= 0; i--)
        {
            handlers[i].HandleMessage(parameters, debugMessage, returnCode);
        }
    }
}