#include <iostream>
#include <conio.h>
using namespace std;

void hitung_nilai_ipk (int *jumlah, int *a){
    float ipk;
    cout <<"----------- IPK Mahasiswa AMIKOM Yogyakarta -----------"<<endl;
    ipk = (float) (*jumlah) / (*a);
    cout<<"IPK = "<<ipk;
}
int main(){
    int a, jumlah;
    string nama, nim;

    cout<<"========== Data Diri Mahasiswa AMIKOM Yogyakarta =========="<<endl;

    cout<<"Nama :\t";
    getline(cin, nama);
    cout<<"NPM/NIM : ";
    cin>>nim;

    cout<<"========== Nilai Mahasiswa =========="<<endl;
    cout<<"Masukkan Jumlah Mata Kuliah :\t";
    cin>>a;
    int nilai_matkul[a];

    for(int i=0 ; i<a ; i++){
        cout<<"Masukkan Mata Kuliah "<<i+1<<" = ";
        cin>>nilai_matkul[i];
        jumlah += nilai_matkul[i];
    }
    hitung_nilai_ipk(&jumlah, &a);
    getch();
}