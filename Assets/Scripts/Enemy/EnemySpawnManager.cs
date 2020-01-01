using UnityEngine;
using System.Collections;

public class EnemySpawnManager : MonoBehaviour
{

    public static EnemySpawnManager instance;
    int currentSpawn = 0;
    public int enemyAmount = 3;
	public int CurrentSpawn {
		get {return currentSpawn;}
		set {currentSpawn = value;}
	}

    public int EnemyAmount{
        get {return enemyAmount;}
    }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }else if(instance != null)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
}