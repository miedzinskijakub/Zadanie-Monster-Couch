using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField] float numberEnemiesToSpawn;
    [SerializeField] GameObject enemyObject;
    [SerializeField] GameObject enemiesParent;

    private void Start() {
        
        SpawnRandom();
    }


      private void SpawnRandom()
     {
         for(int i = 0; i < numberEnemiesToSpawn; i++)
        {
               Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0,Screen.width), Random.Range(0,Screen.height), Camera.main.farClipPlane/2));
           GameObject enemy = Instantiate(enemyObject, screenPosition, Quaternion.identity);
           enemy.transform.parent = enemiesParent.transform;
        }
      
     }
}
