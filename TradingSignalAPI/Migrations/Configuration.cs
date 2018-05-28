namespace TradingSignalAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TradingSignalAPI.Models.Signal;

    internal sealed class Configuration : DbMigrationsConfiguration<TradingSignalAPI.Models.Shared.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TradingSignalAPI.Models.Shared.ApplicationDbContext context)
        {
            if (context.Signals.Count() == 0)
            {
                context.Signals.Add(new Signal
                {
                    Id = "110464201",
                    Currency = "EURUSD",
                    Type = SignalType.BuyStop,
                    Lots = 0.0100,
                    OpenPrice = 1.19750,
                    ClosePrice = 0.00000,
                    Comment = "Open OnInit",
                    State = 0,
                    Profit = 0.00000,
                    OpenTime = DateTime.Now,
                    CloseTime = DateTime.Now,
                    Expire = DateTime.Now
                });
                context.SaveChanges();
            }
        }
    }
}
