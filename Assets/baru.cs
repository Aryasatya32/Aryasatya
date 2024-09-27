using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baru : MonoBehaviour
{
    public int health = 100;
    public int armor = 40; // Tambahkan variabel armor
    public int[] scores = new int[5];
    // Start is called before the first frame update
    void Start()
    {
        // Health 
        while (health > 0)
        {
            health -= 10;
            Debug.Log("Health tersisa: " + health);
        }
        Debug.Log("Pemain telah kalah!");

        // Kondisi Pemain
        if (health > 50)
        {
            Debug.Log("Pemain Sehat");
        }
        else if (health >= 20 && health <= 50)
        {
            Debug.Log("Pemain Perlu Berhati-hati");
        }
        else
        {
            Debug.Log("Pemain dalam Bahaya");
        }


        // Cek Armor
        if (armor > 30 && health > 50) 
        {
            Debug.Log("Pemain Siap Bertarung");
        } 
        else 
        {
            Debug.Log("Pemain Perlu Bersiap");
        }

        // Skor
        scores[0] = 100;
        scores[1] = 90;
        scores[2] = 85;
        scores[3] = 70;
        scores[4] = 60;

        // Cek Kualitas Pemain
        bool berkualitasTinggi = false;
        foreach (int skor in scores)
        {
            if (skor > 80)
            {
                berkualitasTinggi = true;
                break; // Keluar dari loop jika sudah menemukan skor di atas 80
            }
        }

        if (berkualitasTinggi)
        {
            Debug.Log("Pemain berkualitas tinggi");
        }
        else
        {
            Debug.Log("Pemain butuh latihan");
        }

        int totalSkor = 0;
        foreach (int skor in scores)
        {
            totalSkor += skor;
        }

        float rataRata = (float)totalSkor / scores.Length;
        Debug.Log("Rata-rata skor: " + rataRata);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
