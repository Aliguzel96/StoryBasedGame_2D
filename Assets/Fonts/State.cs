using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "State")] //Asset Menüsünde "State" isimli bir menü oluþturur -> proje sayfasýnda sað týklayýp create deyince artýk kendi menümüz de görünecek
public class State : ScriptableObject //Üzerine yazýlabilir, üstünde oynanabilir
{


    //SerializeField -> Biliyoruz ki public bir deðiþkenimiz varsa bunu Inspectordan görüp , deðer atayabiliyoruz. Ayrýca diðer scriptlerden de eriþim saðlayýp deðer müdahale edebiliyoruz. Ama private kullanýrsak ne inspectordan ne de baþka bir scriptten müdahale edilebiliyor iþte burada SerializeField dediðimiz yapý devreye giriyor. Bize þöyle bir avantaj saðlýyor. Inspectordan bu deðeri deðeri deðiþtirip atayabiliyoruz ama baþka scriptlerden müdahale edemiyoruz. 
    //Eðer tam tersini istersek Inspector'da gözükmesin ama baþka scriptlerden eriþebilelim. Protected yapýsý da bu isteðimizi gerçekleþtrime de yeterli deðil. O zaman iþte HideInInspector kullanýyoruz. SerializeField yapýsýna benzer þekilde kullanýlýyor.
    
    [TextArea(12, 10)][SerializeField] string storyText; //hikayemizin ekleneceði bir textArea (baþlangýçta 12 satýrlýk alan ver, 10. satýrdan sonra scrollBar çalýþsýn)

    [SerializeField] State[] nextStates; //sonraki durumlarý içeren bir dizi

    public string GetStateStories()//Durumdaki hikayeleri alan fonks (hikaye metnini al)
    {


        return storyText;
    }

    public State[] GetNextStates()//Sonraki hikayeleri alan fonks. (sonraki durumlarý al)
    {
        return nextStates;

    }
}

