using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject hazard;

    public Vector3 spawnValues;

    public int hazardCounts;

    public float spawnWait;

    public float startWait;

    public float waveWait;

    public TextMesh scoreLabel;

    private int score;

    private void Start()
    {
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        {
            for (int i = 0; i < hazardCounts; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(Random.Range(0.5f, spawnWait));
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
    void UpdateScore()
    {
        scoreLabel.text = "Score: " + score;
    }
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
}
