using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField]
    public static List<Point> points=new List<Point>();
    public static Point SelectedPoint;
    public static int team;
    public static void InactiveAllPoints()
    {
        Debug.Log("InactiveAllPoints");
        foreach(var point in points)
        {
            point.GetComponent<BoxCollider2D>().enabled=false;
            point.content.transform.localScale = new Vector3(2, 2, 0);
        }
    }
    public static void CheckAllNearby(Stone stone)
    {
        InactiveAllPoints();
        foreach (var item in points)
        {
            if(item.content == stone)
            {
                SelectedPoint = item;
                item.ActiveAllNearby();
                return;
            }
        }
    }
     public static void ChangeTeam()
    {
        if(team == 0)
        {
            team = 1;
        }
        else if(team== 1)
        {
            team = 0;
        }
    }
}
