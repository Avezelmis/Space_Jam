using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject[] hazards;

    public Vector3 spawnValues;

    public int hazardCounts;

    public float spawnWait;

    public float startWait;

    public float waveWait;

    public TextMesh scoreLabel;

    public TextMesh restartText;

    public TextMesh gameOverText;

    private int score;

    private bool gameover;

    private bool restart;
    
    private void Start()
    {
        gameover = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
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
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
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
    public void GameOver()
    {
        gameOverText.text = "GAME OVER!";
        gameover = true;
        if (gameover)
        {
            restartText.text = "Press Enter to Restart";
            restart = true;
        }
    }

    public void Update()
    {
        if (restart)
        {
            if (Input.GetButton("Submit"))
            {
                SceneManager.LoadScene("main", LoadSceneMode.Single);
            }
        }
    }
}
