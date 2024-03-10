using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class testscript : MonoBehaviour
{
    public GameObject scene_1, scene_2, scene_3, scene_4, scene_5, scene_6, scene_7, scene_8, scene_9, scene_10, scene_11, scene_12;
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

    public void Rifle()
    {
        scene_7.SetActive(false);
        scene_8.SetActive(true);
    }

    public void Return()
    {
        scene_4.SetActive(true);
        scene_6.SetActive(false);
    }

    public void NotoDoor()
    {
        scene_8.SetActive(false);
        scene_9.SetActive(true);
    }
    
    public void doNothing()
    {
        scene_9.SetActive(false);
        scene_8.SetActive(true);
    }

    public void GotoDoor()
    {
        scene_8.SetActive(false);
        scene_10.SetActive(true);
    }

    public void shootNo()
    {
        scene_10.SetActive(false);
        scene_11.SetActive(true);
    }

    public void shootRats()
    {
        scene_10.SetActive(false);
        scene_12.SetActive(true);
    }
}
