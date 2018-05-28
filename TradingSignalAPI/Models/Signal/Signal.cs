using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TradingSignalAPI.Models.Shared;

namespace TradingSignalAPI.Models.Signal
{
    public class Signal : BaseModel
    {
        public string Id { get; set; }
        public string Currency { get; set; }
        public SignalType Type { get; set; }
        public double Lots { get; set; }
        public double OpenPrice { get; set; }
        public double? ClosePrice { get; set; }
        public string Comment { get; set; }
        public SignalState State { get; set; }
        public double? Profit { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? CloseTime { get; set; }
        public DateTime? Expire { get; set; }

        public void Update(Signal signal)
        {
            //Id = signal.Id;
            Currency = signal.Currency;
            Type = signal.Type;
            Lots = signal.Lots;
            OpenPrice = signal.OpenPrice;
            ClosePrice = signal.ClosePrice;
            Comment = signal.Comment;
            State = signal.State;
            Profit = signal.Profit;
            OpenTime = signal.OpenTime;
            CloseTime = signal.CloseTime;
            Expire = signal.Expire;
        }

    }

    public enum SignalType
    {
        [Display(Name = "BUY")]
        Buy,
        [Display(Name = "SELL")]
        Sell,
        [Display(Name = "BUY LIMIT")]
        BuyLimit,
        [Display(Name = "SELL LIMIT")]
        SellLimit,
        [Display(Name = "BUY STOP")]
        BuyStop,
        [Display(Name = "SELL STOP")]
        SellStop

    }

    public enum SignalState
    {
        Pending,
        Opening,
        Closed
    }
}