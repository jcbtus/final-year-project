using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private void Awake()
    {
        ScenarioManager.Instance.AddNode(this);
    }

    private void OnDestroy()
    {
        ScenarioManager.Instance.RemoveNode(this);
    }
}
