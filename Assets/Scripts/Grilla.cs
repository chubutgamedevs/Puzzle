using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grilla : MonoBehaviour
{
    public GameObject ItemSlot;
    public int grillaX;
    public int grillaY; 
    private int cX = 0;
    private int cY = 0;
    private int slots;
    private float escala;
    private Vector3  posSlot = Vector3.one;
    [SerializeField] private GameObject Tablero;
    private RectTransform rt;
    private RectTransform rta;
    private float correccion = -1;
    public GameObject origen;
    // Start is called before the first frame update
    void Start()
    {   
        rt = ItemSlot.GetComponent<RectTransform>();
        rta = this.gameObject.GetComponent<RectTransform>();

        slots = grillaX + grillaY;
        escala = rta.rect.y / grillaY;
        rt.sizeDelta = new Vector2(escala * correccion, escala*correccion);

        Debug.Log(rt.sizeDelta + " "+ Screen.height);
        GenerarGrilla();
    }
    private void GenerarGrilla(){

       /// ItemSlot.transform.localScale =  new Vector2(escala,escala);
        Transform Tablero = GameObject.FindGameObjectWithTag("Canvas").transform;

        while (cX != grillaX){
            while (cY != grillaY){
                posSlot = new Vector3(origen.transform.position.x+(rt.sizeDelta.x*2)*cX,origen.transform.position.y+ (rt.sizeDelta.y*2)*cY,0);
                posSlot = Tablero.localToWorldMatrix * posSlot;
                Instantiate(ItemSlot, posSlot , Quaternion.identity, Tablero);
                cY = cY+1;
            }
            cX = cX+1;
            cY = 0;
        }
    }

}
