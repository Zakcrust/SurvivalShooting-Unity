using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour
{
	public PlayerHealth playerHealth;
	public GameObject enemy;
	public float spawnTime = 3f;
	public Transform[] spawnPoints;

	
	[SerializeField]
	MonoBehaviour factory;
	IFactory Factory { get { return factory as IFactory; } }

	void Start ()
	{


		StartCoroutine(enemySpawn());
		//Mengeksekusi fungs Spawn setiap beberapa detik sesui dengan nilai spawnTime
		/* if(currentSpawn < EnemySpawnManager.instance.EnemyAmount)
			InvokeRepeating ("Spawn", spawnTime, spawnTime); */
		
	}

	IEnumerator enemySpawn()
	{
		while(true)
		{
			if(EnemySpawnManager.instance.CurrentSpawn < EnemySpawnManager.instance.EnemyAmount)
				Spawn();
			yield return new WaitForSeconds(spawnTime);
		}
		
	}

	void Spawn ()
	{
		//Jika player telah mati maka tidak membuat enemy baru
		if(playerHealth.currentHealth <= 0f)
		{
			return;
		}

		//Mendapatkan nilai random
		int spawnPointIndex = Random.Range (0, spawnPoints.Length); 
		int spawnEnemy = Random.Range(0, 2);

		//Memduplikasi enemy
		Factory.FactoryMethod(spawnEnemy);
		EnemySpawnManager.instance.CurrentSpawn++;
		Debug.Log(EnemySpawnManager.instance.CurrentSpawn);

	}
}