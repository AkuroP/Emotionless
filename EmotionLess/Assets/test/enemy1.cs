using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public static gameMaster instanceGM;
    public GameObject enemy1Fight;
    public bool collideIntoFight = false;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(collideIntoFight)
        {
            instanceGM.battleEnemies.Add(enemy1Fight);
            instanceGM.enemiesID.Add(1);
            instanceGM.LoadScene(sceneName);
        }
    }
}
