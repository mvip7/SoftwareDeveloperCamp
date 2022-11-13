using _5_5.Abstract;
using _5_5.Entities;
using _5_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5_5.Concrete
{
    public class UsersManager : IUserService
    {
        IMernisCheckService _mernisCheckService;

        public UsersManager(IMernisCheckService _mernisCheckService)
        {
            this._mernisCheckService = _mernisCheckService;
        }

        public void Add(Users users)
        {
            int year = users.BirthOfDate.Year;
            int nowYear = DateTime.Now.Year;
            int age = nowYear - year;
            if (_mernisCheckService.CheckUser(users)==true && age>=18)
            {
                Console.WriteLine(users.Name+" "+users.LastName+" İsimli Kayıt Oluşturuldu");
            }
            else if (age<18)
            {
                Console.WriteLine("Kullanıcı 18 yaşından büyük olmalıdır ");
            }
            else
            {
                Console.WriteLine("Yeni Kayıt Oluşturulamadı...\n Doğrulama Hatası !!!");
            }
            
        }
        public void Delete(Users users)
        {
            Console.WriteLine(users.Name + "İsimli Kayıt Silindi");
        }
        public void Update(Users users, string firstName, string lastName)
        {
            string beforeName = users.Name;
            Console.WriteLine(beforeName + "İsimli Kayıt" + users.Name + " Olarak Güncellendi");
        }

    }
}
