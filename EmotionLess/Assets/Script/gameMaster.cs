using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameMaster : MonoBehaviour
{
    public static gameMaster instanceGM;
    public List<GameObject> battleEnemies;
    public List<int> enemiesID;
    
    private void Awake()
    {
        if(instanceGM == null)
        {
            instanceGM = this;  
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(instanceGM.gameObject);
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void LoadScene(string sceneName)
    {

    }
}
