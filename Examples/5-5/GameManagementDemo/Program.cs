using _5_5.Abstract;
using _5_5.Concrete;
using _5_5.Entities;
using System;

namespace _5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Users users1 = new Users();
            users1.ID = 1;
            users1.Name = "Yunus Emre";
            users1.LastName = "Kobal";
            users1.NationalID = 17341713490;
            users1.BirthOfDate = new DateTime(2010, 07, 22);
            UsersManager userManager = new UsersManager(new MernisCheckManager());
            userManager.Add(users1);
            

            Games games1 = new Games();
            games1.ID = 1;
            games1.Name = "FIFA";
            games1.Price = 145;
            GamesManager gamesManager = new GamesManager();
            gamesManager.Add(games1);

            Campaigns campaigns1 = new Campaigns();
            campaigns1.Id = 1;
            campaigns1.CampaignName="Summer Sale";
            campaigns1.DiscountRate = 45;
            CampaignsManager campaignsManager = new CampaignsManager();
            campaignsManager.AddCampaign(campaigns1);

            SalesManager salesManager = new SalesManager();
            salesManager.Sells(games1,users1,campaigns1);

            Console.ReadLine();
        }
    }
}
