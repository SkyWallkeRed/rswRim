using System.Collections;
using UnityEngine;

public class Tile {
   public enum TileType {Empty, Solid};

    TileType type = TileType.Empty;

    public TileType Type{
        get{
            return type;
        }
        set{
            type = value;
        }
    }

    LooseObject looseObject;
    InstalledObject InstalledObject;

    World world;
    int x;
    public int X{
        get{
            return X;
        }
    }
    int y;
    public int Y{
        get{
            return y;
        }
    }

    public Tile(World world, int x, int y){
        this.world = world;
        this.x = x;
        this.y = y;
    }
}
