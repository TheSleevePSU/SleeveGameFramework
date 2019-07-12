using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {

    public enum TileType { Empty, Floor }
    private TileType tileType = TileType.Empty;
    private World world;
    private int x;
    private int y;

    public Tile(World world, int x, int y) {
        this.world = world;
        this.x = x;
        this.y = y;
    }
}