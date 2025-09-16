using TMPro;
using UnityEngine;

public class GoalPostScript : MonoBehaviour
{
    [SerializeField] LevelManager LevelManager;
    [SerializeField] private GameObject Manager;
    [SerializeField] GameObject Score;
    [SerializeField] private TextMeshProUGUI TMP;
    int score = 0;
    string finalscore = "";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TMP = Score.GetComponent<TextMeshProUGUI>();
        LevelManager = Manager.GetComponent<LevelManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            score++;
            finalscore = score.ToString();
            TMP.SetText(finalscore);
            Destroy(GameObject.FindGameObjectWithTag("Ball"));
            LevelManager.SpawnerFunction();
        }
    }
}
