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
    private Vector3  posSlot = Vector3.one;
    
    
    private RectTransform rt;
    // Start is called before the first frame update
    void Start()
    {   
        rt = ItemSlot.GetComponent<RectTransform>();
        
        slots = grillaX + grillaY;
        escala = Screen.width/grillaY;

        Ancho = rt.rect.width * rt.localScale.x;
        Largo = rt.rect.height * rt.localScale.y;
        Debug.Log("Ancho: " + Ancho + " Largo: " + Largo + " Escala: " + escala);

        GenerarGrilla();
    }

    private void GenerarGrilla(){
        
        while (cX != grillaX){
            while (cY != grillaY){
                posSlot = new Vector3(this.transform.position.x + Ancho*cX,this.transform.position.y + Largo*cY,0)*-1;
                Debug.Log(posSlot);
                Instantiate(ItemSlot, posSlot , Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                cY = cY+1;
            }
            cX = cX+1;
            cY = 0;
        }
         for(int i = 0; i < slots; i++)
        {
        // Code to be repeated.
        }

    }
}
