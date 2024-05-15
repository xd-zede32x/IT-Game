using UnityEngine;
using System.Collections.Generic;

namespace ScriptsEncapsulation
{
    public class Maze
    {
        private Dictionary<Vector2Int, Cell> _cells;

        public Maze(Dictionary<Vector2Int, Cell> cells) => _cells = new Dictionary<Vector2Int, Cell>(cells);

        public IReadOnlyDictionary<Vector2Int, Cell> Cell => _cells;
    }
}