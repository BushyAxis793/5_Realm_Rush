﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    [SerializeField] Color exploredColor;

    public bool isExplored = false;

    public Waypoint exploredFrom;

    Vector2Int gridPos;

    const int gridSize = 10;

    void Start()
    {
        Physics.queriesHitTriggers = true;
    }

    public int GetGridSize()
    {
        return gridSize;
    }

    void Update()
    {
       // neighbour.SetTopColor(Color.blue);
    }

    public Vector2Int GetGridPos()
    {
        return new Vector2Int(
            Mathf.RoundToInt(transform.position.x / gridSize) ,
            Mathf.RoundToInt(transform.position.z / gridSize) 
        );
    }

    void OnMouseOver()
    {
        print(gameObject.name);
    }

}
