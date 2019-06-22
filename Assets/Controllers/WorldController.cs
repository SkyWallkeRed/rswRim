using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour {

    public Sprite floorSprite;

    World world;
	// Use this for initialization
	void Start () {
        world = new World();
        world.RandomaizeTiles();

        for (int x = 0; x < world.Width; x++){
            for (int y = 0; y < world.Height; y++){
                GameObject tile_go = new GameObject();
                Debug.Log( x);
                Tile tile_data = world.GetTileAt(x, y);

                tile_go.name = "Tile" + x + "_" + y;

                if (tile_data.Type == Tile.TileType.Solid){
                    SpriteRenderer tile_sr = tile_go.AddComponent<SpriteRenderer>();
                    tile_sr.sprite = floorSprite;
                    tile_go.transform.position = new Vector3(tile_data.X, tile_data.Y, 0);
                }

            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
