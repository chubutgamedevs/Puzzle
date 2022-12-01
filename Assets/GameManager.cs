using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ItemSlot;
    private float Ancho;
    private float Largo;
    public int grillaX;
    public int grillaY; 
    private int cX = 0;
    private int cY = 0;
    private int slots;
    private float escala;
    
    
    private RectTransform rt;
    // Start is called before the first frame update
    void Start()
    {   
        rt = ItemSlot.GetComponent<RectTransform>();
        
        slots = grillaX + grillaY;
        escala = Screen.width/grillaY;

        Ancho = rt.rect.width * rt.localScale.x;
        Largo = rt.rect.height * rt.localScale.y;

        GenerarGrilla();
    }

    private void GenerarGrilla(){
        
        while (cX != grillaX){
            while (cY != grillaY){
                Instantiate(ItemSlot, new Vector3(0,this.transform.position.y + Largo*cY,0), Quaternion.identity);
                cY = cY+1;
            }
            Instantiate(ItemSlot, new Vector3(this.transform.position.x + Ancho*cX,0), Quaternion.identity);
            cX = cX+1;
        }

    }
}
