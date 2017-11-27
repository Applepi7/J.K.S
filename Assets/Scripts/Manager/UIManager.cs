using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public static UIManager instance;

    public bool isShowText;
    public bool isClear;

    [SerializeField]
    private Text keyText;

    [SerializeField]
    private Image light;

    [SerializeField]
    private Image clearImg;

    private float alpha;
    private float imgAlpha;
    private int changeSpeed = 1;

	void Awake ()
    {
        UIManager.instance = this;
        isShowText = false;
        isClear = false;
	}

    void Update()
    {
        ShowLeftKeys();
        ShowEnding();
    }

    void ShowLeftKeys()
    {
        if (isShowText)
        {
            if (GameManager.instance.keyNum == 0)
                keyText.text = "Open The Door";
            else
                keyText.text = "Keys " + GameManager.instance.keyNum + "/7";

            if (alpha >= 2)
                changeSpeed *= -1;
            else if (alpha <= -0.1)
            {
                changeSpeed *= -1;
                isShowText = false;
            }
            alpha += changeSpeed * Time.deltaTime;

            keyText.color = new Color(255, 255, 255, alpha);

        }
    }

    public void ShowEnding()
    {
        if(isClear)
        {
            imgAlpha += changeSpeed * Time.deltaTime;
            light.color = new Color(255, 255, 255, imgAlpha);
            if(imgAlpha >= 1)
            {
                SceneManager.LoadScene("EndingScene");
            }

        }
    }

}
