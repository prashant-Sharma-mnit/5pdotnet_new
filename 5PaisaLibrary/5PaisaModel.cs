﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _5PaisaLibrary
{
    class _5PaisaModel
    {
    }
    public class Token
    {

        public string AccessToken { get; set; }

        public string RequestToken { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }

    }

    class TokenResponse
    {
        public bool status { get; set; }
        public string Message { get; set; }
        public string errorcode { get; set; }
        public Token body { get; set; }
    }
    public class OutputBaseClass
    {
        public string status { get; set; }
        public string http_code { get; set; }

        public string http_error { get; set; }
        public Token TokenResponse { get; set; }

        public OrderResponse PlaceOrderResponse { get; set; }

        public TradeBookResponse TradeBook { get; set; }

        public TradeHistoryResponse TradeHistory { get; set; }

        public MarketFeedResponse MarketFeed { get; set; }

        public OrderBookResponse OrderBook { get; set; }

        public NetPositionNetWiseRes NetPositionNetWise { get; set; }

        public HistoricalDataRes HistoricalWiseData { get; set; }

        public object HistoricalData { get; set; }
        public MultiOrderMarginRes MultiOrderMargin { get; set; }
        public MarketSnapshotV1Res MarketSnapshotV1 { get; set; }
        public NetPositionNetWiseV3Res NetPositionNetWiseV3 { get; set; }

        public TaxReportResponse TaxReportResponse { get; set; }
        public LedgerResponse LedgerResponse { get; set; }
        

    }
    public class HistoricalDataRes
    {
        public string Status { get; set; }

        public HistoricalResBody data { get; set; }
    }

    public class HistoricalResBody
    {

        public ICollection<CandleWiseData> candles { get; set; }
    }
    public class CandleWiseData
    {
        public DateTime Datetime { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public Int64 Volume { get; set; }

    }



    public class NetPositionNetWiseV3Res
    {
        public Reshead head { get; set; }
        public NetPositionNetWiseV3ResBody body { get; set; }
    }

    public class NetPositionNetWiseV3ResBody
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public List<NetPositionNetWiseDetailsV3> NetPositionDetail { get; set; }
    }

    public class NetPositionNetWiseDetailsV3
    {
        public char Exch { get; set; }
        public char ExchType { get; set; }
        public int ScripCode { get; set; }
        public string ScripName { get; set; }
        public int BuyQty { get; set; }
        public double BuyAvgRate { get; set; }
        public double BuyValue { get; set; }
        public int SellQty { get; set; }
        public double SellAvgRate { get; set; }
        public double SellValue { get; set; }
        public int NetQty { get; set; }
        public double BookedPL { get; set; }
        public double LTP { get; set; }
        public char OrderFor { get; set; }
        public int BodQty { get; set; }
        public double PreviousClose { get; set; }
        public double MTOM { get; set; }
        public double Multiplier { get; set; }
        public double AvgRate { get; set; }
        public double CFQty { get; set; }
        public double AvgCFQty { get; set; }
        public double LotSize { get; set; }
        public int ConvertedQty { get; set; }
        public bool IsPhysicalDelivery { get; set; }
        public double AvgCFPrice { get; set; }
    }




    public class MarketSnapshotV1Res
    {

        public Reshead head { get; set; }
        public MarketSnapshotV1ResBody body { get; set; }
    }

    public class MarketSnapshotV1ResBody
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public int CacheTime { get; set; }
        public DateTime TimeStamp { get; set; }
        public List<MarketSnapshotV1ResData> Data { get; set; }
    }

    public class MarketSnapshotV1ResData
    {
        public DateTime LastTradeTime { get; set; }
        public string NetChange { get; set; }
        public string Open { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string PClose { get; set; }
        public string Volume { get; set; }
        public double AverageTradePrice { get; set; }
        public double LastTradedPrice { get; set; }
        public long LastQuantity { get; set; }
        public long BuyQuantity { get; set; }
        public long SellQuantity { get; set; }
        public long TotalBuyQuantity { get; set; }
        public long TotalSellQuantity { get; set; }
        public string OpenInterest { get; set; }
        public string Exchange { get; set; }
        public string ExchangeType { get; set; }
        public int ScripCode { get; set; }
        public string AHigh { get; set; }
        public string ALow { get; set; }
        public string MarketCapital { get; set; }
        public string ExposureCategory { get; set; }
        public double UpperCircuitLimit { get; set; }
        public double LowerCircuitLimit { get; set; }
        public double PrevOpenInterest { get; set; }
    }
    public class NetPositionNetWiseRes
    {
        public NetPositionNetwiseResBody body { get; set; }

        public Reshead head { get; set; }
    }
    public class NetPositionNetwiseResBody
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public List<NetPositionNetWiseDetails> NetPositionDetail { get; set; }
    }
    public class NetPositionNetWiseDetails
    {
        public char Exch { get; set; }
        public char ExchType { get; set; }
        public int ScripCode { get; set; }
        public string ScripName { get; set; }
        public int BuyQty { get; set; }
        public double BuyAvgRate { get; set; }
        public double BuyValue { get; set; }
        public int SellQty { get; set; }
        public double SellAvgRate { get; set; }
        public double SellValue { get; set; }
        public int NetQty { get; set; }
        public double BookedPL { get; set; }
        public double LTP { get; set; }
        public char OrderFor { get; set; }
        public int BodQty { get; set; }
        public double PreviousClose { get; set; }
        public double MTOM { get; set; }
        public double Multiplier { get; set; }
        public double AvgRate { get; set; }
        public double CFQty { get; set; }
        public double AvgCFQty { get; set; }
        public double LotSize { get; set; }
        public int ConvertedQty { get; set; }
    }
    public class MarketFeedResponse
    {

        public MarketfeedMain body { get; set; }

        public Reshead head { get; set; }
    }
    public class MarketfeedMain
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public int CacheTime { get; set; }
        public DateTime TimeStamp { get; set; }

        public List<MarketFeedDataListRes> Data { get; set; }
    }
    public class MarketFeedDataListRes
    {
        public char Exch { get; set; }
        public char ExchType { get; set; }
        public uint Token { get; set; }
        public double LastRate { get; set; }
        public uint TotalQty { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double PClose { get; set; }
        public DateTime TickDt { get; set; }

        public int Time { get; set; }
        public float ChgPcnt { get; set; }
        public float Chg { get; set; }

        public string Symbol { get; set; }
    }


    public class MultiOrderMarginRes
    {
        public Reshead head { get; set; }
        public MultiOrderMarginResBody body { get; set; }

    }

    public class MultiOrderMarginResBody
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public double AvailableMargin { get; set; }
        public double TotalMarginRequired { get; set; }
    }



    public class OrderBookResponse
    {
        public OrderBookMain body { get; set; }

        public Reshead head { get; set; }
    }
    public class OrderBookMain
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public List<OrderBookV3> OrderBookDetail { get; set; }

    }


    public class OrderBookV3
    {
        public char RequestType { get; set; }
        public int BrokerOrderId { get; set; }
        public DateTime BrokerOrderTime { get; set; }
        public char Exch { get; set; }
        public char ExchType { get; set; }
        public int ScripCode { get; set; }
        public string ScripName { get; set; }
        public char BuySell { get; set; }
        public int Qty { get; set; }
        public double Rate { get; set; }
        public char AtMarket { get; set; }
        public char WithSL { get; set; }
        public double SLTriggerRate { get; set; }
        public char SLTriggered { get; set; }
        public string ExchOrderID { get; set; }
        public DateTime ExchOrderTime { get; set; }
        public string OrderStatus { get; set; }
        public char AfterHours { get; set; }
        public char AHProcess { get; set; }
        public int OldorderQty { get; set; }
        public int TradedQty { get; set; }
        public int PendingQty { get; set; }
        public string OrderRequesterCode { get; set; }
        public int DisClosedQty { get; set; }
        public int TerminalId { get; set; }
        public char DelvIntra { get; set; }
        public int OrderValidity { get; set; }
        public string OrderValidUpto { get; set; }
        public string Reason { get; set; }
        public double SMOSLLimitRate { get; set; }
        public double SMOSLTriggerRate { get; set; }
        public double SMOProfitRate { get; set; }
        public double SMOTrailingSL { get; set; }
        public double MarketLot { get; set; }
        public string RemoteOrderID { get; set; }
        public double AveragePrice { get; set; }
    }
    public class OrderData
    {
        public Int32 BrokerOrderID { get; set; }
        public string ClientCode { get; set; }
        public char Exch { get; set; }
        public char ExchType { get; set; }
        public string ExchOrderID { get; set; }
        public Int16 LocalOrderID { get; set; }
        public string RemoteOrderID { get; set; }
        public int RMSResponseCode { get; set; }
        public string Message { get; set; }
        public Int32 ScripCode { get; set; }
        public string Status { get; set; }
        public DateTime Time { get; set; }

    }
    public class Reshead

    {
        public string responseCode { get; set; }
        public string status { get; set; }

        public string statusDescription { get; set; }
    }

    public class TradebookData
    {
        public string status { get; set; }
        public string message { get; set; }
        public List<TradeBookDetailV1> TradeBookDetail { get; set; }
    }
    public class TradeBookDetailV1
    {
        public char Exch;
        public char ExchType;
        public int ScripCode;
        public string ScripName;
        public char BuySell;
        public int Qty;
        public int PendingQty;
        public int OrgQty;
        public double Rate;
        public string ExchOrderID;
        public string ExchangeTradeID;
        public DateTime ExchangeTradeTime;
        public string TradeType;
        public char DelvIntra;
        public double Multiplier;
    }
    public class ScripMasterReposnse
    {
        public char Exch { get; set; }
        public char ExchType { get; set; }
        public int ScripCode { get; set; }

        public string Name { get; set; }
        public string Expiry { get; set; }
        public string ScripType { get; set; }

        public double StrikeRate { get; set; }
        public string FullName { get; set; }

        public int LotSize { get; set; }

        public int QtyLimit { get; set; }

        public int ISIN { get; set; }
        public string ScripData { get; set; }
        public string Series { get; set; }

        public int COBOAllowed { get; set; }



        public int Multiplier { get; set; }
    }
    public class TradeBookResponse
    {
        public TradebookData body { get; set; }

        public Reshead head { get; set; }

    }
    public class TradeHistoryResponse
    {
        public TradeHistoryDataResponse body { get; set; }

        public Reshead head { get; set; }
    }

    public class TradeHistoryDataResponse
    {

        public string Status { get; set; }
        public string Message { get; set; }

        public List<TradeHistoryDataList> TradeHistoryData { get; set; }
    }
    public class TradeHistoryDataList
    {

        public TradeHistoryDataList()
        {
            Exchange = ' ';
            ExchangeType = ' ';
            ScripCode = 0;
            Symbol = "";
            Product = "";
            TransactionType = ' ';
            TradedQty = 0;
            ExchOrderID = "";
            RemoteOrderID = "";
            ExchangeTime = DateTime.Now;
            TradePrice = 0d;
            TradeID = 0;
            OrderType = "";
            Status = 0;
            Message = "";
        }

        public char Exchange;
        public char ExchangeType;
        public int ScripCode;
        public string Symbol;
        public string Product;
        public char TransactionType;
        public int TradedQty;
        public string ExchOrderID;
        public string RemoteOrderID;
        public DateTime ExchangeTime;
        public double TradePrice;
        public int TradeID;
        public string OrderType;
        public int Status;
        public string Message;
    }
    public class OrderResponse
    {
        public bool status { get; set; }
        public string message { get; set; }
        public string errorcode { get; set; }
        public OrderData body { get; set; }

        public Reshead head { get; set; }
    }
    public class OutputBaseTOTPClass
    {
        public string status { get; set; }
        public string http_code { get; set; }
        public string http_error { get; set; }

        public string ClientCode { get; set; }
        public string Message { get; set; }
        public string RedirectURL { get; set; }
        public string RequestToken { get; set; }

        public string Status { get; set; }

        public string Userkey { get; set; }
    }

    /* Input Classes*/
    public class OrderInfo
    {

        public string ClientCode { get; set; }

        public char Exchange { get; set; }

        public char ExchangeType { get; set; }

        public string ScripData { get; set; }

        public double Price { get; set; }

        public string OrderType { get; set; }

        public long Qty { get; set; }

        public long ScripCode { get; set; }

        public long DisQty { get; set; }

        public double StopLossPrice { get; set; }

        public bool IsIntraday { get; set; }

        public OrderValidity iOrderValidity { get; set; }

        public int AppSource { get; set; }

        public string RemoteOrderID { get; set; }

        public char AHPlaced { get; set; }

        public string PublicIP { get; set; }

        public DateTime ValidTillDate { get; set; }

        public string ExchOrderID { get; set; }

        public List<ExchOrderIDList> ExchOrderList { get; set; }

        public DateTime LastRequestTime { get; set; }

        public string RefreshRate { get; set; }
        public string CoverPositions { get; set; }
        public List<MarketFeedDataListReq> MarketFeedData { get; set; }
        public List<MultiOrderMarginReq> Orders { get; set; }

        public List<MarketSnapshotReqBody> Data { get; set; }

        public string FromDate { get; set; }
        public string ToDate { get; set; }

    }
    public class WebsocketConnect
    {

        public string Method { get; set; }
        public string Operation { get; set; }
        public string ClientCode { get; set; }
        public List<WebsocketMarketFeedDataListReq> WebsokectMarketFeedData { get; set; }

    }

    public enum OrderValidity : short
    {
        Day = 0,
        GTD = 1,
        GTC = 2,
        IOC = 3,
        EOS = 4,
        VTD = 5,
        FOK = 6
    }
    public partial class WebsocketMarketFeedDataListReq
    {

        public string Exch { get; set; }

        public string ExchType { get; set; }

        public int ScripCode { get; set; }



    }
    public partial class MarketFeedDataListReq
    {

        public string Exch { get; set; }

        public string ExchType { get; set; }

        public int ScripCode { get; set; }

        public string ScripData { get; set; }
    }



    public class MarketSnapshotReqBody
    {
        public string Exchange { get; set; }
        public string ExchangeType { get; set; }
        public int ScripCode { get; set; }
        public string ScripData { get; set; }

    }
    public class ExchOrderIDList
    {
        public string ExchOrderID { get; set; }
    }


    public partial class MultiOrderMarginReq
    {
        public string Exch { get; set; }
        public string ExchType { get; set; }
        public int ScripCode { get; set; }
        public string ScripData { get; set; }
        public string PlaceModifyCancel { get; set; } = "P"; // Hardcoded value
        public string OrderType { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public bool IsIntraday { get; set; }
    }


    public class TaxReportResponse
    {

        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public TaxReportData data { get; set; }
    }

    public class TaxReportData
    {
        public string PanNo { get; set; }
        public string ClientCode { get; set; }
        public string EmailId { get; set; }
        public string Equity { get; set; }
        public string FNO { get; set; }
        public string Currency { get; set; }
        public string Commodity { get; set; }
        public string MutualFund { get; set; }
    }





    public class LedgerResponse
    {
        public ResheadLedger head { get; set; }
        public LedgerResponseBody body { get; set; }
    }

    public class ResheadLedger

    {
        public string Type { get; set; }
        public string Status { get; set; }
    }


    public class LedgerResponseBody
    {
        public string Message { get; set; }
        public int Count { get; set; }
        public List<LedgerClientData> ClientData { get; set; }
    }

    public class LedgerClientData
    {
        public string PARTYCODE { get; set; }
        public string ExSeg { get; set; }
        public decimal OPEN_BAL { get; set; }
        public DateTime TXNDATE { get; set; }
        public string Particular { get; set; }
        public string VOUCHERNO { get; set; }
        public decimal DEBIT { get; set; }
        public decimal CREDIT { get; set; }
        public decimal BALANCE { get; set; }
        public decimal TOTAL_DR { get; set; }
        public decimal TOTAL_CR { get; set; }
        public decimal NET_BALANCE { get; set; }
        public string MAINCODE { get; set; }
        public int SNO { get; set; }
        public string Particular_Desc { get; set; }
    }

}


