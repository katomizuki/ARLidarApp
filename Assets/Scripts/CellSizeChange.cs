using UnityEngine;
using UnityEngine.UI;

namespace FirstScene
{
    [RequireComponent(typeof(GridLayoutGroup))]
    public class CellSizeChange : MonoBehaviour
    {
        private void Awake()
        {
            var gridLayoutGroup = GetComponent<GridLayoutGroup>();
            gridLayoutGroup.cellSize = new Vector2(Screen.width / 2, Screen.height / 2);
        }
    } 
}

