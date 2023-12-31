using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFovCommand : ICommand {
    public string Name { get; set; }

    public int CameraIndex { get; set; }

    public float Fov { get; set; }

    public void Execute(Dictionary<string, GameObject> gameObjects) {
        var agent = gameObjects[Name];
        if (agent != null) {
            var entityComponent = agent.GetComponent<Entity>();
            entityComponent.CameraFov(CameraIndex, Fov);
        }
    }
}
