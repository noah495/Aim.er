
using UnityEngine;

public class weaponholder : MonoBehaviour
{
public int SelectedWeapon = 0;

    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
        
    }

    // Update is called once per frame
    void Update()
    {

        int previousSelectedWeapon = SelectedWeapon;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SelectedWeapon = 0;
        }
             
        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            SelectedWeapon = 1;
        }        
        if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3)
        {
            SelectedWeapon = 2;
        }  
              if (Input.GetKeyDown(KeyCode.Alpha4) && transform.childCount >= 4)
        {
            SelectedWeapon = 3;
        }  
        if (Input.GetKeyDown(KeyCode.Alpha5) && transform.childCount >= 5)
        {
            SelectedWeapon = 4;
        }  
        if(previousSelectedWeapon !=SelectedWeapon)
        {
            SelectWeapon();
        }
    }
    void SelectWeapon()
    {


        int i = 0;
        foreach(Transform weapon in transform)
        {
            if (i == SelectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
