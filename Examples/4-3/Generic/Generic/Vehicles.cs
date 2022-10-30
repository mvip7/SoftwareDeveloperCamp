using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class Vehicles<T>
    {
        /* 
            İlk Once Tanımlayacagımız Dizilerin Referansını Tutmak İçin 2 Değişken Tanımlıyoruz
        */
        T[] _array;
        T[] _tempArray;

        /*
         Dizideki Elemanları Saymak İçin Geriye Değer Döndüren Bir Property Tanımlıyorum
         */
        public int Count
        {
            get { return _array.Length; }
        }
        public T[] this[int index] { get { return _array; } }

        /*
         Diziyi Yeni Bir Eleman Ekleyip Çağırdığımda Çalışacak Olan Kodu Yazıyorum
         */
        public Vehicles()
        {
            _array = new T[0];
        }

        /*
         Add isminde bir Operasyon Tanımladım
         */
        public void Add(T item)
        {
            /*
             Yeni Bir Eleman Eklediğimde Eski Verilerin Kaybolmaması İçin tempArray Değişkeninde
             Tutuyorum
             */
            _tempArray = _array;

            /*
             _array değişkeninde tuttuğum diziye yeni bir eleman eklediğimde eleman sayısınında 
            artması gerekiyor bu yüzden dizinin uzunlugu +1 yaparak yeni eleman ekliyorum
             */
            _array = new T[_array.Length + 1];

            /*
             Yeni bir eleman eklediğimde varolanlar siliniyor bu yüzden öncesinde _tempArrayde
            tuttugum elemanları for dongusu yardimi ile _array dizisine ekliyorum
             */
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            /*
             * Son Olarak Dışarıdan Gelen Değeri _array Dizisinin Son Elemanına Veriyorum
             */
            _array[_array.Length - 1] = item;
        }
    }
}
