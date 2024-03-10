using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class testscript : MonoBehaviour
{
    public GameObject scene_1, scene_2, scene_3, scene_4, scene_5, scene_6, scene_7;
    //public int sanityPoints;


    // Start is called before the first frame update
    void Start()
    {
        scene_1.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton()
    {
        scene_1.SetActive(false);
        scene_2.SetActive(true);
    }

    public void LayDown()
    {
        scene_2.SetActive(false);
        scene_3.SetActive(true);
    }
    public void SitGetUP()
    {
        scene_2.SetActive(false);
        scene_3.SetActive(false);
        scene_4.SetActive(true);
    }

    public void CheckDoor()
    {
        scene_4.SetActive(false);
        scene_5.SetActive(true);
    }

    public void CheckChair()
    {
        scene_4.SetActive(false);
        scene_5.SetActive(false);
        scene_6.SetActive(true);
    }

    public void CheckLocker()
    {
        scene_4.SetActive(false);
        scene_5.SetActive(false);
        scene_6.SetActive(false);
        scene_7.SetActive(true);
    }
}
