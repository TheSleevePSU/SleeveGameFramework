using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    private static ILogger logger = Debug.unityLogger;
    private static string TAG = "Game";
    private FileLogger fileLogger;
    private World world;

    void Start() {
        fileLogger = new FileLogger();
        logger.Log(TAG, "Start()");
        CreateWorld();
    }

    private void CreateWorld() {
        world = new World();
    }

    void Update() {

    }
}