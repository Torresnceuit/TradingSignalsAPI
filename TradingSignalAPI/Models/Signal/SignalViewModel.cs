using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TradingSignalAPI.Extensions;
using TradingSignalAPI.Models.Shared;

namespace TradingSignalAPI.Models.Signal
{
    public class SignalViewModel: BaseModel
    {
        public string Id { get; set; }
        public string Currency { get; set; }
        public SignalType Type { get; set; }
        public double OpenPrice { get; set; }
        public double? ClosePrice { get; set; }
        public SignalState State { get; set; }
        public double? Profit { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? CloseTime { get; set; }
        public DateTime? Expire { get; set; }

        public SignalViewModel(Signal signal)
        {
            Id = signal.Id;
            Currency = signal.Currency;
            Type = signal.Type;
            OpenPrice = signal.OpenPrice;
            ClosePrice = signal.ClosePrice;
            State = signal.State;
            Profit = signal.Profit;
            OpenTime = signal.OpenTime;
            CloseTime = signal.CloseTime;
            Expire = signal.Expire;
        }
    }
}