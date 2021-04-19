using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loading : MonoBehaviour
{
    public Transform LoadingBar;

    [SerializeField]
    private float waktu;

    [SerializeField]
    private float kecepatan;

    // Update is called once per frame
    void Update()
    {
        if(waktu < 100)
        {
            //fungsi untuk mengatur waktu
            waktu += kecepatan * Time.deltaTime;
            Debug.Log((int)waktu);
        }
        else
        {
            //fungsi untuk menghubungkan splash screen dan halaman menu utama
            Application.LoadLevel("h_menu_utama");
        }

        LoadingBar.GetComponent<Image>().fillAmount = waktu / 100;

    }
}
