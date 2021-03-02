using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    public GameObject CardFront;
    public GameObject CardBack;
    public GameObject PlayerZone;
    public GameObject BotZone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DrawClick()
    {
        GameObject playerCard = Instantiate(CardFront, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
