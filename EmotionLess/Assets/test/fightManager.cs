using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightManager : MonoBehaviour
{
    public static gameMaster instanceGM;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < instanceGM.enemiesID.Count; i++)
        {
            Instantiate(instanceGM.battleEnemies[i]);
            FightEnemiesID(instanceGM.enemiesID[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FightEnemiesID(int id)
    {
        if(id == 1)
        {
            Debug.Log("Enemi 1");
        }
    }
}
