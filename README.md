# **Tugas Besar II Strategi Algoritma**
# Pengaplikasian Algoritma BFS dan DFS dalam Fitur People You May Know Jejaring Sosial Facebook

## **Algoritma Program**
========================

Aplikasi ini memanfaatkan BFS dan DFS untuk pencarian hubungan antar akun yang tersimpan dalam file teks eksternal. 

Akun direpresentasikan sebagai simpul, pertemanan sebagai sisi, koneksi antar akun direpresentasikan sebagai graf.

Pada file eksternal, akun yang tertulis di sebelah akun yang lainnya memiliki hubungan pertemanan dengan akun tersebut.

Elemen-elemen algoritma:
1. Jalur awal: akun pertama
2. Jalur tujuan: akun yang dicari koneksinya (semua akun pada file eksternal/semua simpul pada graf)
3. Rute: jalur yang dilalui antar akun

Dengan pendekatan BFS, yang dikunjungi adalah semua simpul yang bertetangga dengan simpul awal terlebih dahulu.

Dengan pendekatan DFS, yang dikunjungi adalah tetangga dari simpul awal. Kemudian, DFS dimulai lagi dari simpul tetangga tersebut.

## **Requirement Program dan Instalasi**
====================================

Pastikan Visual Studio terinstal dengan kakas .NET dan MSAGL.

Program dijalankan pada sistem operasi Windows.

## **Cara Menggunakan Program**
==============================

1. Buka folder pada Visual Studio
2. Buka file Program.cs pada folder GUI > tubes2 stima > test.
3. Jalankan program.
4. Tuliskan nama file teks eksternal yang akan divisualisasi dalam bentuk graf.
5. Pilih algoritma BFS atau DFS untuk menggunakan menu lanjutan.
6. Tekan submit dan visualisasi graf akan ditampakkan.
7. Pilih salah satu menu utama, yaitu friend recommendation atau explore friends.

    ### Friend Recommendation
    -------------------------

    Pilih nama akun yang akan ditunjukkan rekomendasinya dan tekan submit. Akan ditampilkan daftar nama rekomendasi beserta dengan jalur hubungan tersebut.

    ### Explore Friends
    -------------------

    Pilih dua akun yang akan dicari jalur keterhubungannya, lalu tekan submit. Akan ditampilkan jalur pembuatan hubungan beserta visualisasi jalur tersebut pada graf. Apabila tidak ada jalur yang dapat ditempuh, maka akan ditampilkan pesan “No path to make connection”.
8. Fitur tambahan yang dapat digunakan dengan menekan tulisannya pada bagian menu:
   
    - Help
    - About Us

## **Author/Identitas Pembuat**
===========================

* Jesica (13519011)
* Rhea Elka Pandumpi (13519047)
* Nabila Hannania (13519097)