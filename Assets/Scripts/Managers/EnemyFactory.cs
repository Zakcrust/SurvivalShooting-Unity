using System;
using UnityEngine;

public class EnemyFactory : MonoBehaviour, IFactory{

	[SerializeField]
	public GameObject[] enemyPrefab;

	public GameObject FactoryMethod(int id)
	{
		GameObject enemy = Instantiate(enemyPrefab[id]);
		return enemy;
	}
}
