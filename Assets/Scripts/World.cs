using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World {
    private Tile[, ] tileMap;
    private List<Entity>[, ] entityMap;
    private int width;
    private int height;

    public World(int width = 100, int height = 100) {
        this.width = width;
        this.height = height;

        CreateTileMap(width, height);
        CreateEntityMap(width, height);

        Debug.Log($"Generated World with width = {width}, height = {height}");
    }

    private void CreateTileMap(int width, int height) {
        tileMap = new Tile[width, height];
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                tileMap[x, y] = new Tile(this, x, y);
            }
        }
    }

    private void CreateEntityMap(int width, int height) {
        entityMap = new List<Entity>[width, height];
    }

    public Tile GetTileAt(int x, int y) {
        return tileMap[x, y];
    }
}