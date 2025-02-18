using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //TextMashProUGUI¿¡ ÇÊ¿ä

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI newGame;
    public TextMeshProUGUI loadGame;
    public TextMeshProUGUI score;
    public TextMeshProUGUI exit;



    // Start is called before the first frame update
    void Start()
    {
        loadGame.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            loadGame.gameObject.SetActive(true);
        }
    }
}
