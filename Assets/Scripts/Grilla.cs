using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grilla : MonoBehaviour
{
        public GameObject ItemSlot;
    private float Ancho = 1;
    private float Largo = 1;
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

        Ancho = rt.rect.width;
        Largo = rt.rect.height;

        slots = grillaX + grillaY;
        escala = (Screen.height / grillaY) /100;

        Debug.Log("Ancho: " + Ancho + " Largo: " + Largo + " Escala: " + escala+ "ScreenH: "+ Screen.height);
        GenerarGrilla();
    }
    private void GenerarGrilla(){

        ItemSlot.transform.localScale =  new Vector2(escala,escala);
        Transform Tablero = GameObject.FindGameObjectWithTag("Canvas").transform;

        while (cX != grillaX){
            while (cY != grillaY){
                posSlot = new Vector3( this.transform.position.x + Ancho*cX*escala,this.transform.position.y + Largo*cY*escala,0);
                posSlot = Tablero.localToWorldMatrix * posSlot;
                Instantiate(ItemSlot, posSlot , Quaternion.identity, Tablero);
                cY = cY+1;
            }
            cX = cX+1;
            cY = 0;
        }
    }

}
