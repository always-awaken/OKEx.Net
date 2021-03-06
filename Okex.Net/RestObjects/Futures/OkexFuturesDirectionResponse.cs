﻿using CryptoExchange.Net.Attributes;
using CryptoExchange.Net.Converters;
using Okex.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Okex.Net.Enums;
using Okex.Net.Attributes;

namespace Okex.Net.RestObjects
{
    public class OkexFuturesDirectionResponse

    {
        /// <summary>
        /// The result of request
        /// </summary>
        [JsonProperty("result")]
        public bool Result { get; set; }

        /// <summary>
        /// Error code. It will return a ‘0’ if the order is placed successfully. Otherwise, the corresponding error code will be shown to indicate the reason of order failure.
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; } = "";

        /// <summary>
        /// The error_message would be blank if the order is placed successfully. Otherwise, an error_message would be returned to signal failure of order placement.
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; } = "";

        /// <summary>
        /// Contract ID, e.g.BTC-USD-180213,BTC-USDT-191227
        /// </summary>
        [JsonProperty("instrument_id")]
        public string Symbol { get; set; } = "";

        /// <summary>
        /// Side (long or short)
        /// </summary>
        [JsonProperty("direction"), JsonConverter(typeof(FuturesDirectionConverter))]
        public OkexFuturesDirection Direction { get; set; }
    }
}
