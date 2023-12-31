using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotateCommand : ICommand {
    public string Name { get; set; }

    public int CameraIndex { get; set; }

    public Vector3 RotateAxis { get; set; }

    public float Degrees { get; set; }

    public void Execute(Dictionary<string, GameObject> gameObjects) {
        var agent = gameObjects[Name];
        if (agent != null) {
            var entityComponent = agent.GetComponent<Entity>();
            entityComponent.CameraRotate(CameraIndex, RotateAxis, Degrees);
        }
    }
}
