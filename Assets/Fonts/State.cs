using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "State")] //Asset Men�s�nde "State" isimli bir men� olu�turur -> proje sayfas�nda sa� t�klay�p create deyince art�k kendi men�m�z de g�r�necek
public class State : ScriptableObject //�zerine yaz�labilir, �st�nde oynanabilir
{


    //SerializeField -> Biliyoruz ki public bir de�i�kenimiz varsa bunu Inspectordan g�r�p , de�er atayabiliyoruz. Ayr�ca di�er scriptlerden de eri�im sa�lay�p de�er m�dahale edebiliyoruz. Ama private kullan�rsak ne inspectordan ne de ba�ka bir scriptten m�dahale edilebiliyor i�te burada SerializeField dedi�imiz yap� devreye giriyor. Bize ��yle bir avantaj sa�l�yor. Inspectordan bu de�eri de�eri de�i�tirip atayabiliyoruz ama ba�ka scriptlerden m�dahale edemiyoruz. 
    //E�er tam tersini istersek Inspector'da g�z�kmesin ama ba�ka scriptlerden eri�ebilelim. Protected yap�s� da bu iste�imizi ger�ekle�trime de yeterli de�il. O zaman i�te HideInInspector kullan�yoruz. SerializeField yap�s�na benzer �ekilde kullan�l�yor.
    
    [TextArea(12, 10)][SerializeField] string storyText; //hikayemizin eklenece�i bir textArea (ba�lang��ta 12 sat�rl�k alan ver, 10. sat�rdan sonra scrollBar �al��s�n)

    [SerializeField] State[] nextStates; //sonraki durumlar� i�eren bir dizi

    public string GetStateStories()//Durumdaki hikayeleri alan fonks (hikaye metnini al)
    {


        return storyText;
    }

    public State[] GetNextStates()//Sonraki hikayeleri alan fonks. (sonraki durumlar� al)
    {
        return nextStates;

    }
}

