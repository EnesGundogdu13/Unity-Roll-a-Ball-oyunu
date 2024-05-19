using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    Rigidbody fizik;
    public int hiz;
    int sayac = 0;
    public Text sayactext;
    public Text oyunbitti;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        Vector3 Vec = new Vector3(yatay, 0, dikey);
        fizik.AddForce(Vec * hiz);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Engel")
        {
            Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            sayac++;
            sayactext.text = "Sayaç = " + sayac;
            if (sayac==8)
            {
                oyunbitti.text = "Oyunu Bittirdin!";
            }
        }

    }
}
