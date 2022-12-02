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
    [SerializeField] private GameObject Tablero;
    
    
    private RectTransform rt;
    // Start is called before the first frame update
    void Start()
    {   
        rt = ItemSlot.GetComponent<RectTransform>();
        
        slots = grillaX + grillaY;
        escala =  (Tablero.GetComponent<RectTransform>().sizeDelta.y * -0.1f) / grillaY;
        Debug.Log(Tablero.GetComponent<RectTransform>().sizeDelta.y);

        Ancho = rt.rect.width;
        Largo = rt.rect.height;
        Debug.Log("Ancho: " + Ancho + " Largo: " + Largo + " Escala: " + escala);

        GenerarGrilla();
    }

    private void GenerarGrilla(){
        
        Transform Tablero = GameObject.FindGameObjectWithTag("Canvas").transform;
        ItemSlot.transform.localScale =  Vector2.one;//new Vector2(escala,escala);

        while (cX != grillaX){
            while (cY != grillaY){
                posSlot = new Vector3(Tablero.position.x + Ancho*cX, Tablero.position.y + Largo*cY,0)*-1;
                posSlot = Tablero.localToWorldMatrix * posSlot;
                Instantiate(ItemSlot, posSlot , Quaternion.identity, Tablero);
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
