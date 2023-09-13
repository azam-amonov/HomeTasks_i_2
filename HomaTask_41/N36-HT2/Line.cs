namespace HomaTask_41.N36_HT2;

public struct Line
{
    public string PointA { get; set; }
    public string PointB { get; set; }

    public Line(string pointA, string pointB)
    {
        PointA = pointA;
        PointB = pointB;
    }
}