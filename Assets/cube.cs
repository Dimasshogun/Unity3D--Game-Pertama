using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public float kecepatanPindah;
// Use this for initialization
void Start () {
//print ("Haloooo, saya adalah sebuah cube");
kecepatanPindah = 10f;
}
// Update is called once per frame
void Update () {
// move ke sumbu x
//transform.Translate(1f * Time.deltaTime, 0f, 0f);
// move ke sumbu y
//transform.Translate(0f, 1f * Time.deltaTime, 0f);
//mengetahui nilai kontrol pada saat ditekan arah horizontal (kanan/kiri)
//print(Input.GetAxis("Horizontal"));
// mengetahui nilai kontrol pada saat ditekan arah vertical (atas/bawah)
//print(Input.GetAxis("Vertical"));
// kontrol dengan arah horizontal
//transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);
// beri kontrol untuk vertical dan horizontal input dengan merubah kode pada sumbu X dan Z
//transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Input.GetAxis("Vertical") * Time.deltaTime);
// mengubah kecepatan perpindahan object
transform.Translate(kecepatanPindah*Input.GetAxis("Horizontal") * Time.deltaTime, 0f, kecepatanPindah*Input.GetAxis("Vertical") * Time.deltaTime);
}
}
