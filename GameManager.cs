using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> enemys;

    public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        StartCoroutine(SpawnTarget());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // While game is active spawn a random target
    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(1);
            int index = Random.Range(0, enemys.Count);

            if (isGameActive)
            {
                for(int x = 0; x < 7; x++){
                    Instantiate(enemys[index], RandomSpawnPosition(), enemys[index].transform.rotation);
                }
            
            }
        }
    }

    // Generate a random spawn position based on a random index from 0 to 3
    Vector3 RandomSpawnPosition()
    {
        float zPos = -25;
        float xPos = Random.Range(19, -19);
        return new Vector3(xPos, 0, zPos);
    }


}
