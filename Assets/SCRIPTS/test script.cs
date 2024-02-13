using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class testscript : MonoBehaviour
{
    public GameObject scene1, scene2, scene3;
    public GameObject stats;
    public TextMeshProUGUI sanityPoints;
    //public int sanityPoints;


    // Start is called before the first frame update
    void Start()
    {
        scene1.SetActive(true);
        scene2.SetActive(false);
        scene2.SetActive(false);
        stats.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton()
    {
        scene1.SetActive(false);
        scene2.SetActive(true);
        scene3.SetActive(false);
        stats.SetActive(true);
    }

    public void LookAround()
    {
        scene1.SetActive(false);
        scene2.SetActive(false);
        scene3.SetActive(true);
        stats.SetActive(true);
    }
}
