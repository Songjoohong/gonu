using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Stone : MonoBehaviour
{
    public int team;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(this.team == Board.team)
        {
            Board.CheckAllNearby(this);
            transform.localScale = new Vector3(3, 3, 0);
        }
       
    }

   
}
