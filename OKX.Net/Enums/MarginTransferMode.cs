﻿using CryptoExchange.Net.Attributes;

namespace OKX.Net.Enums;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public enum MarginTransferMode
{
    [Map("automatic", "auto_transfers_ccy")]
    AutoTransfer,
    [Map("autonomy")]
    ManualTransfer
}