using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameController : MonoBehaviour
{
    [SerializeField] TMP_Text storyContent;
    [SerializeField] State baslangicDurumu;

    State guncelDurum;
    void Start()
    {
        guncelDurum = baslangicDurumu;
        storyContent.text = guncelDurum.GetStateStories();

    }

    // Update is called once per frame
    void Update()
    {
        //var sonrakiDurumlar = guncelDurum.GetNextStates(); -> var == State[]
        State[] sonrakidurumlar = guncelDurum.GetNextStates(); //mevcut durumun sonras�nda ne var, onu ald�k

        for (int i = 0; i < sonrakidurumlar.Length; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 +i)) //i == 0 ---> 1. tu�a bas�lm��: guncel durum 0. indis, (Alpha1 == 2)
                                                    //i == 1 ---> 2. tu�a bas�lm��: guncel durum 1. indis,
                                                    //i == 2 ---> 3. tu�a bas�lm��: guncel durum 2. indis
            {
                guncelDurum = sonrakidurumlar[i];
            }

        }


        /*if(Input.GetKeyDown(KeyCode.Alpha1))//1'e bas�ld���nda
        {
            guncelDurum = sonrakidurumlar[0];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))//2'ye bas�ld���nda
        {
            guncelDurum = sonrakidurumlar[1];
        }
        else if(Input.GetKeyDown (KeyCode.Alpha3))//3'e bas�ld���nda
        {
            guncelDurum = sonrakidurumlar[2];
        }*/

        storyContent.text = guncelDurum.GetStateStories();
    }
}
