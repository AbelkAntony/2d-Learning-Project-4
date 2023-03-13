using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learning.Aditya
{
    public class ObstacleSpawner : MonoBehaviour
    {
        public GameObject obstaclePrefab;
        public Transform[] spawnPoints;
        public int pathCount;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnObstacles();
            }
        }

        // private void PathSpawn(Transform[] obstacles)
        private void PathSpawn(List<Transform> obstacles)
        {                
            for (int i = 0; i < pathCount; i++)
            {
                int index = Random.Range(0, obstacles.Count);

                Transform obstacle = obstacles[index];
                obstacles.RemoveAt(index);                
                Destroy(obstacle.gameObject);
                
            }
        }

        private void SpawnObstacles()
        {
            //Transform[] obstacles = new Transform[spawnPoints.Length];
            List<Transform> obstacles = new List<Transform>();
            for (int i = 0; i < spawnPoints.Length; i++)
               obstacles.Add(SpawnSingleObstacle(spawnPoints[i]));

            PathSpawn(obstacles);
        }

        public Transform SpawnSingleObstacle(Transform spawnPoint)
        {
            return Instantiate(obstaclePrefab, spawnPoint.position, spawnPoint.rotation, spawnPoint).transform;
        }
    }
}
