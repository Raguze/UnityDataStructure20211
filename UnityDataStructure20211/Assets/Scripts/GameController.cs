using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ChessPieces { None, Pawn, Tower, Knight, Bishop, Queen, King }

public class GameController : MonoBehaviour
{
    public Dictionary<string, int> hps = new Dictionary<string, int>();

    public Dictionary<Vector2Int, ChessPieces> tableChess = new Dictionary<Vector2Int, ChessPieces>();

    void Start()
    {
        hps.Add("Megaman", 100);
        hps.Add("Zero", 80);

        //Debug.Log(hps["Megaman"]);
        //Debug.Log(hps["Zero"]);

        tableChess.Add(new Vector2Int(0, 0), ChessPieces.Tower);
        tableChess.Add(new Vector2Int(1, 0), ChessPieces.Knight);
        tableChess.Add(new Vector2Int(2, 0), ChessPieces.Bishop);
        tableChess.Add(new Vector2Int(3, 0), ChessPieces.Queen);
        tableChess.Add(new Vector2Int(4, 0), ChessPieces.King);
        tableChess.Add(new Vector2Int(5, 0), ChessPieces.Bishop);
        tableChess.Add(new Vector2Int(6, 0), ChessPieces.Knight);
        tableChess.Add(new Vector2Int(7, 0), ChessPieces.Tower);

        foreach (KeyValuePair<Vector2Int,ChessPieces> position in tableChess)
        {
            //Debug.LogFormat("Coordenada: {0} peça: {1}", position.Key, position.Value);
        }

        Debug.Log(tableChess[new Vector2Int(3, 0)]);
    }

    
    void Update()
    {
        
    }
}
