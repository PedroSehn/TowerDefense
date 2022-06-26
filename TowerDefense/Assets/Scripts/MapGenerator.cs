using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
   public GameObject mapTile;

   [SerializeField] private int MapWidth;
   [SerializeField] private int MapHeight;

   private List<GameObject> mapTiles = new List<GameObject>();
   private List<GameObject> pathTiles = new List<GameObject>();

   private void Start(){
    generateMap();
   }

   private void generateMap(){
        for(int y =0; y < MapHeight; y++){
            for(int x = 0; x < MapWidth; x++){
                GameObject newTile = Instantiate(mapTile);
                mapTiles.Add(newTile);
                newTile.transform.position = new Vector2(x,y);
            }
        }

        Destroy(mapTiles[0]);
   }
}
