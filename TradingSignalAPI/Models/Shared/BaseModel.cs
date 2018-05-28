using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TradingSignalAPI.Models.Shared
{
    public class BaseModel
    {
        /// <summary>
        /// The Time this object was created
        /// </summary>
        [Index]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// The Time this object was last updated
        /// </summary>
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// If this object has been deleted or not
        /// </summary>
        [Index]
        public bool IsDeleted { get; set; } = false;
    }
}