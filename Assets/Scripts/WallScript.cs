using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public NextLevelName nextLevel;

    

    public int health;

    private bool i = true;

    void Update()
    {
        if (i == true)
        {
            
            if (health <= 0)
            {
                LevelControler newLevelControler = GameObject.Find("WinSquare").GetComponent<LevelControler>();

                newLevelControler.WinScreenAppear();

                i = false;

            }
        }
        if (i == false)
        {
            LevelControler newLevelControler = GameObject.Find("WinSquare").GetComponent<LevelControler>();

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("space pressed");
                newLevelControler.LevelChanger();
            }

        }
    }
           
        
        
    
       
    
      

}

