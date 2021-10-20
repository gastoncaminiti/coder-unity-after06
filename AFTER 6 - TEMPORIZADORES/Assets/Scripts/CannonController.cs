using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    //POSICION QUE DETERMINA LA APARICION DEL PREFAB
    public Vector3 spawnPosition = new Vector3(7, 2, 7);
    //VARIABLE PARA ASOCIAR EL PREFAB
    public GameObject prefabBullet;
    //VARIABLE PARA DETERMINAR EL COOLDOWN MAXIMO
    public float cooldown = 3f;
    //VARIABLE PARA DETERMINAR EL TIEMPO QUE PASO DESDE QUE SE DISPARO
    public float timePass = 0;
    //VARIABLE PARA CONTROLAR EL ESTADO DE DISPARO
    public bool  isShoot  = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //SI SE PRESIONA LA TECLA ESPACIO Y SE PUEDE DISPARAR (SI NO SE DISPARO isShoot = false SE PUEDE DISPARAR)
        if (Input.GetKeyDown(KeyCode.Space) && !isShoot)
        {
            isShoot = true; 
            Instantiate(prefabBullet, spawnPosition, prefabBullet.transform.rotation);
        }
        //SI SE DISPARO SE SUMA EL TIEMPO DE DISPARO A timePass
        if (isShoot)
        {
            timePass += Time.deltaTime;
        }
        //SI timePass SUPERA EL COOLDOWN SE DEJA DE CONTAR EL TIEMPO PASADO, SE REINICIA LA CUENTA A CERO Y SE DETERMINA QUE NO SE ESTA DISPARANDO.
        if(timePass > cooldown)
        {
            isShoot  = false;
            timePass = 0;
        }

    }
}
