using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;

public class MainStorycs : MonoBehaviour
{
    private int scriptCnt = 0;
    private bool nextFlag = false;
    private ScriptPlayer player = null;

    private string[] scriptList = new string[]
    {
    "MainStoryTxt"
    };

    public async void NaninovelInitial()
    {
        Engine.OnInitializationFinished += () =>
        {
            nextFlag = true;
            player = Engine.GetService<ScriptPlayer>();
            player.OnStop += (Script script) =>
        {
            scriptCnt++;
            nextFlag = true;
        };
        };
        await RuntimeInitializer.InitializeAsync();
    }
    void Update()
    {
        if (nextFlag)
        {
            nextFlag = false;
            if (scriptList.Length > scriptCnt)
            {
                Message(scriptList[scriptCnt]);
            }
        }
    }

    async void Message(string id)
    {
        await player.PreloadAndPlayAsync(id);
    }

}