using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBApi;

namespace TWSHelper
{
    public static class ContractFactory
    {
        public static Contract getStock(string Symbol, string Exchange, string Currency)
        {
            Contract contract = new Contract();
            contract.Symbol = Symbol;
            contract.SecType = "STK";
            contract.Currency = Currency;
            contract.Exchange = Exchange;
            return contract;
        }

        public static Contract getFuture(string strSymbol, string strExchange, string strExpiry, string strCurrency)
        {
            Contract contract = new Contract();

            contract.Symbol = strSymbol;
            contract.SecType = "FUT";
            contract.Exchange = strExchange;
            contract.Currency = strCurrency;
            contract.Expiry = strExpiry;

            return contract;
        }

        public static Contract getCFD(string strSymbol, string strExchange, string strCurrency)
        {
            Contract contract = new Contract();

            contract.Symbol = strSymbol;
            contract.SecType = "CFD";
            contract.Exchange = strExchange;
            contract.Currency = strCurrency;

            return contract;
        }

        public static Contract getINDEX(string strSymbol, string strExchange, string strCurrency)
        {
            Contract contract = new Contract();

            contract.Symbol = strSymbol;
            contract.SecType = "IND";
            contract.Exchange = strExchange;
            contract.Currency = strCurrency;

            return contract;
        }

        public static Contract getFOP(string strSymbol, double Strike, string strRight, string strCurrency, string strExpiry, string strExchange)
        {
            Contract contract = new Contract();

            contract.Symbol = strSymbol;
            contract.SecType = "FOP";
            contract.Strike = Strike;
            contract.Right = strRight;
            contract.Currency = strCurrency;
            contract.Expiry = strExpiry;
            contract.Exchange = strExchange;

            return contract;
        }

        public static Contract getOption(string strSymbol, double Strike, string strRight, string strCurrency, string strExpiry, string strExchange)
        {
            Contract contract = new Contract();

            contract.Symbol = strSymbol;
            contract.SecType = "OPT";
            contract.Strike = Strike;
            contract.Right = strRight;
            contract.Currency = strCurrency;
            contract.Expiry = strExpiry;
            contract.Exchange = strExchange;

            contract.Multiplier = "100";

            return contract;
        }

        public static Contract getCurrency(string strSymbol)
        {
            Contract contract = new Contract();
            contract.Symbol = strSymbol;
            contract.Currency = "USD";
            contract.Exchange = "IDEALPRO";
            return contract;
        }
    }
}
