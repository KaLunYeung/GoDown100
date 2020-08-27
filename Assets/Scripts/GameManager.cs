using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private GameObject[] Tiles;
    private Transform gameCanvas;
    private Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        Tiles = Resources.LoadAll<GameObject>("Tiles");
        gameCanvas = GameObject.Find("GameCanvas").transform;
        player = GameObject.Find("Player").transform;
        

        InvokeRepeating("CreateTiles", 0, 0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.y <= -5.5)
        { SceneManager.LoadScene("MainMenu"); }
    }

    private void CreateTiles()  // creating Tiles

    {
        int rangNum = Random.Range(0, Tiles.Length);
        GameObject tempTile = Tiles[rangNum];
        GameObject Tile = null;
        if (rangNum == 1 || rangNum == 2)
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
}
