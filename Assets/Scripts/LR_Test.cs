using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LR_Test : MonoBehaviour
{
    [SerializeField] private ClueLineRenderer line;
    [SerializeField] private Transform[] points;


    private void Start() {
        line.SetUpLine(points);
    }
}
