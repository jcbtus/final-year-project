using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class ScenarioManager : MonoBehaviour
{
    private static ScenarioManager _instance;
    
    public GameObject Node;
    public GameObject Path;

    public static ScenarioManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("Scenario manager is null");
            }

            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public List<Node> nodes;

    public void AddNode(Node node)
    {
        nodes.Append(node);
    }

    public void RemoveNode(Node node)
    {
        nodes.Remove(node);
    }

    private void Update()
    {
        Debug.Log(nodes);
    }
}


