using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveList : MonoBehaviour
{
    private static SaveList s_Singleton;


    [Header("Room")]
    public bool baignoire;
    public bool couloir;
    public bool couloirPrincD;
    public bool couloirPrincG;
    public bool couloirPrincipal;
    public bool escalier;
    public bool escalier2;
    public bool fosse;
    public bool hall;
    public bool pallier;
    public bool vestiaire;
    public bool vestibule;
    public bool autel;



    private void Awake()
    {
        if (s_Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            s_Singleton = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        baignoire = SaveSystem.GetBool("baignoire");
        couloir = SaveSystem.GetBool("couloir");
        couloirPrincD = SaveSystem.GetBool("couloirPrincD");
        couloirPrincG = SaveSystem.GetBool("couloirPrincG");
        couloirPrincipal = SaveSystem.GetBool("couloirPrincipal");
        escalier = SaveSystem.GetBool("escalier");
        escalier2 = SaveSystem.GetBool("escalier2");
        fosse = SaveSystem.GetBool("fosse");
        hall = SaveSystem.GetBool("hall");
        pallier = SaveSystem.GetBool("pallier");
        vestiaire = SaveSystem.GetBool("vestiaire");
        vestibule = SaveSystem.GetBool("vestibule");
        autel = SaveSystem.GetBool("autel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationQuit()
    {
        SaveSystem.SetBool("baignoire", baignoire);
        SaveSystem.SetBool("couloir", couloir);
        SaveSystem.SetBool("couloirPrincD", couloirPrincD);
        SaveSystem.SetBool("couloirPrincG", couloirPrincG);
        SaveSystem.SetBool("couloirPrincipal", couloirPrincipal);
        SaveSystem.SetBool("escalier", escalier);
        SaveSystem.SetBool("escalier2", escalier2);
        SaveSystem.SetBool("fosse", fosse);
        SaveSystem.SetBool("hall", hall);
        SaveSystem.SetBool("pallier", pallier);
        SaveSystem.SetBool("vestiaire", vestiaire);
        SaveSystem.SetBool("vestibule", vestibule);
        SaveSystem.SetBool("autel", autel);
    }

   

}
