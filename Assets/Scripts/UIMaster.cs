using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIMaster : MonoBehaviour
{
    bool ispause;
    public static UIMaster Instance;
    public GameObject Panel;
    public TMP_Text Scores;
    public TMP_Text Scores2;
    public static bool GameIsOver;
    int score = 0;

    public void Again()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Scores.text = score.ToString();
        Scores2.text = score.ToString();
        Panel.SetActive(false);
    }
    public void ScoreUp()
    {        
        score += 1;
        Scores.text = score.ToString();
        Scores2.text = score.ToString();
    }
    // Update is called once per frame
    public void GameOver(bool GameIsOver)
    {
        Panel.SetActive(true);
        Time.timeScale = 0;
        GameObject.FindObjectOfType<Spawn>().Desible(true);
        
    }
    public void Resume()
    {
        Time.timeScale = 1;
        Panel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            Panel.SetActive(true);
        }
       
    }
       
}

