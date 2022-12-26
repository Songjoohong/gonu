using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public Stone content = null;
    public Point[] nearby;

    public void ActiveNode()
    {
        Debug.Log("active");
        GetComponent<BoxCollider2D>().enabled = true;
    }
    public void ActiveAllNearby()
    {
        foreach(Point p in nearby)
        {
            if (p.content == null)
            {
                p.ActiveNode();
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Board.points.Add(this);
        if(content)
        {
            content.transform.position = transform.position;
        }
      

    }
    private void OnMouseDown()
    {
        content = Board.SelectedPoint.content;
        Board.SelectedPoint.content= null;
        Board.SelectedPoint = null;
        Board.InactiveAllPoints();
        content.transform.localScale = new Vector3(2, 2, 0);
        content.transform.position = transform.position;
        Board.ChangeTeam();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
