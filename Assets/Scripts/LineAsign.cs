using UnityEngine;

public class LineAsign : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private PointsToLineRenderer line;

    void Start()
    {
        line.SetUpLine(points);
    }
}

