using UnityEngine;

namespace ScriptsEncapsulation
{
    public class Cell 
    {
        public Vector2Int Coordinates => _coordinates;

        private Vector2Int _coordinates;

        public Cell(Vector2Int coordinates) => _coordinates = coordinates;
    }
}