using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private GameObject[] Tiles;
    private Transform gameCanvas;
    private GameObject player;
    public AudioSource DeathAudioSource;
    private bool triggered = false;

    public Text text1;

    private int score = 0;
    void Start()
    {
        Tiles = Resources.LoadAll<GameObject>("Tiles");
        gameCanvas = GameObject.Find("GameCanvas").transform;
        player = GameObject.Find("Player");



        InvokeRepeating("AddScore", 3f, 3f);
        InvokeRepeating("CreateTiles", 0, 0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (player.transform.position.y <= -5.5 )
        {

            if (!triggered)
            { 
                DeathAudioSource.Play();
                triggered = true;
            }

            StartCoroutine(LoadScene());
        }


    }
    private void AddScore() 
    {

        score += 1;
        text1.text = score.ToString();
        
    }
    private void CreateTiles()  // creating Tiles

    {
        int rangNum = Random.Range(0, Tiles.Length);
        GameObject tempTile = Tiles[rangNum];
        GameObject Tile = null;
        if (rangNum == 1 || rangNum == 2 || rangNum == 4)
        {
            Tile = Instantiate(tempTile, new Vector3(Random.Range(-180, 180), -570, 0), Quaternion.identity);
        }
        else
        {
            Tile = Instantiate(tempTile, new Vector3(Random.Range(-180, 180), -500, 0), Quaternion.identity);
        }

        Tile.transform.SetParent(gameCanvas, false);

        Tile.AddComponent<TileMove>();


    }
    IEnumerator LoadScene()
    {
        
        

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MainMenu");


    }
}
