
using UnityEngine;
using UnityEngine.UI;


public class MutationCordinatorV2 : MonoBehaviour {




    //Buttons
    public Button ShieldButton;
    public Button MagnetButton;
    public Button DmgReduxButton;
    public Button NoEnemyButton;
    public Button PusherButton;
    public Button SqueezeButton;
    public Button TakeAllButton;
    public Button DashButton;

    public SaveSc savesc;
    public float proteinMult=10;



    private void Awake()
    {
        ShieldButton.interactable = false;
        MagnetButton.interactable = false;
        DmgReduxButton.interactable = false;
        NoEnemyButton.interactable = false;
        PusherButton.interactable = false;
        SqueezeButton.interactable = false;
        TakeAllButton.interactable = false;
        DashButton.interactable = false;

    }
    void Start () {
        MutasyonRefresh();
            }

    void MutasyonRefresh()
    {
        ///tier 1 power ups
        ///
        if (savesc.protein >= (savesc.shieldpr+1) * proteinMult && savesc.shieldpr < 4)
        {
            ShieldButton.interactable = true;
        }
        else
        {
            ShieldButton.interactable = false;
        }

        /// Tier 2 Powerups
        /// 
        if (savesc.protein >= (savesc.magnetpr + 2) * proteinMult && savesc.magnetpr < 4 && savesc.shieldpr >=2 )
        {
            MagnetButton.interactable = true;
        }
        else
        {
            MagnetButton.interactable = false;
        }

        if (savesc.protein >= (savesc.dmgredux + 2) * proteinMult && savesc.dmgredux < 4 && savesc.shieldpr >= 2)
        {
            DmgReduxButton.interactable = true;
        }
        else
        {
            DmgReduxButton.interactable = false;

        }
        if (savesc.protein >= (savesc.noenemypr + 2) * proteinMult && savesc.noenemypr < 4 && savesc.shieldpr >= 2)
        {
            NoEnemyButton.interactable = true;
        }
        else
        {
            NoEnemyButton.interactable = false;
        }


        ///tier 3 power ups
        ///
        if (savesc.protein >= (savesc.pusherpr + 3) * proteinMult && savesc.pusherpr < 4 && savesc.magnetpr >= 2)
        {
            PusherButton.interactable = true;
        }
        else
        {
            PusherButton.interactable = false;
        }

        if (savesc.protein >= (savesc.squeezepr + 3) * proteinMult && savesc.squeezepr== 0 && savesc.dmgredux >= 2)
        {
            SqueezeButton.interactable = true;
        }
        else
        {
            SqueezeButton.interactable = false;

        }
        if (savesc.protein >= (savesc.takeallpr + 3) * proteinMult && savesc.takeallpr < 4 && savesc.noenemypr >= 2)
        {
            TakeAllButton.interactable = true;
        }
        else
        {
            TakeAllButton.interactable = false;
        }

        /// tier 4 power ups
        /// 

        if (savesc.protein >= (savesc.dash + 5) * proteinMult && savesc.dash ==0 && savesc.takeallpr >= 2 && savesc.squeezepr ==1 && savesc.noenemypr >= 2)
        {
            DashButton.interactable = true;
        }
        else
        {
            DashButton.interactable = false;
        }

    }

        
 public void PressShieldButton ()
    {
        savesc.protein -= (savesc.shieldpr+1) * proteinMult;
        savesc.shieldpr++;
        Debug.Log("shield " + savesc.shieldpr);
        MutasyonRefresh();
    }


    public void PressMagnetButton()
    {
        savesc.protein -= (savesc.magnetpr + 2) * proteinMult;
        savesc.magnetpr++;
        Debug.Log("shield " + savesc.magnetpr);
        MutasyonRefresh();
    }

    public void PressDmgReduxButton()
    {
        savesc.protein -= (savesc.dmgredux + 2) * proteinMult;
        savesc.dmgredux++;
        Debug.Log("shield " + savesc.dmgredux);
        MutasyonRefresh();
    }


    public void PressNoEnemyButton()
    {
        savesc.protein -= (savesc.noenemypr + 2) * proteinMult;
        savesc.noenemypr++;
        Debug.Log("shield " + savesc.noenemypr);
        MutasyonRefresh();
    }
    public void PressPusherButton()
    {
        savesc.protein -= (savesc.pusherpr + 3) * proteinMult;
        savesc.pusherpr++;
        Debug.Log("shield " + savesc.pusherpr);
        MutasyonRefresh();
    }

    public void PressSqueezeButton()
    {
        savesc.protein -= (savesc.squeezepr + 3) * proteinMult;
        savesc.squeezepr++;
        Debug.Log("shield " + savesc.squeezepr);
        MutasyonRefresh();
    }

    public void PressTakeAllButton()
    {
        savesc.protein -= (savesc.takeallpr + 3) * proteinMult;
        savesc.takeallpr++;
        Debug.Log("shield " + savesc.takeallpr);
        MutasyonRefresh();
    }

    public void PressDashButton()
    {
        savesc.protein -= (savesc.dash + 5) * proteinMult;
        savesc.dash++;
        Debug.Log("shield " + savesc.dash);
        MutasyonRefresh();
    }










}
