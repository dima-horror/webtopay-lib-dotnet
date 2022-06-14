﻿using System.Collections.Generic;

namespace EVP.WebToPay.ClientAPI
{
    public class MacroCallbackData : ICallbackData
    {

        private int _projectId;
        private string _orderId;
        private string _language;
        private int _amount;
        private string _currency;
        private string _payment;
        private string _country;
        private string _payText;
        private string _firstName;
        private string _lastName;
        private int _status;
        private bool _test;
        private string _email;
        private int _requestId;
        private int _payAmount;
        private string _payCurrency;
        private string _version;
        private string _account;
        private int? _personCodeStatus;
        private Dictionary<string, string> _additionalParameters = new Dictionary<string, string>();


        public MacroCallbackData(Dictionary<string, string> dataQueryParams)
        {
            EnhancedDictionary<string, string> parameters = new EnhancedDictionary<string, string>(dataQueryParams);
            this._projectId = int.Parse(parameters.Take("projectid"));
            this._orderId = parameters.Take("orderid");
            this._amount = int.Parse(parameters.Take("amount"));
            this._currency = parameters.Take("currency");
            this._payment = parameters.Take("payment");
            this._payText = parameters.Take("paytext");
            this._status = int.Parse(parameters.Take("status"));
            this._test = HttpQueryUtility.QueryParameterToBoolean(parameters.Take("test"));

            if (parameters.ContainsKey("country"))
            {
                this._country = parameters.Take("country");
            }
            if (parameters.ContainsKey("lang"))
            {
                this._language = parameters.Take("lang");
            }
            if (parameters.ContainsKey("name"))
            {
                this._firstName = parameters.Take("name");
            }
            if (parameters.ContainsKey("surename"))
            {
                this._lastName = parameters.Take("surename");
            }
            if (parameters.ContainsKey("p_email"))
            {
                this._email = parameters.Take("p_email");
            }
            if (parameters.ContainsKey("requestid"))
            {
                this._requestId = int.Parse(parameters.Take("requestid"));
            }
            if (parameters.ContainsKey("payamount"))
            {
                this._payAmount = int.Parse(parameters.Take("payamount"));
            }
            if (parameters.ContainsKey("paycurrency"))
            {
                this._payCurrency = parameters.Take("paycurrency");
            }
            if (parameters.ContainsKey("version"))
            {
                this._version = parameters.Take("version");
            }
            if (parameters.ContainsKey("account"))
            {
                this._account = parameters.Take("account");
            }
            if (parameters.ContainsKey("personcodestatus"))
            {
                this._personCodeStatus = int.Parse(parameters.Take("personcodestatus"));
            }

            if (parameters.Count != 0)
            {
                foreach (KeyValuePair<string, string> param in parameters)
                {
                    this._additionalParameters[param.Key] = param.Value;
                }
            }
        }


        public int ProjectId
        {
            get { return this._projectId; }
        }


        public string OrderId
        {
            get { return this._orderId; }
        }


        public string Language
        {
            get { return this._language; }
        }


        public int Amount
        {
            get { return this._amount; }
        }


        public string Currency
        {
            get { return this._currency; }
        }


        public string Payment
        {
            get { return this._payment; }
        }


        public string Country
        {
            get { return this._country; }
        }


        public string PayText
        {
            get { return this._payText; }
        }


        public string FirstName
        {
            get { return this._firstName; }
        }


        public string LastName
        {
            get { return this._lastName; }
        }


        public int Status
        {
            get { return this._status; }
        }


        public bool Test
        {
            get { return this._test; }
        }


        public string Email
        {
            get { return this._email; }
        }


        public int RequestId
        {
            get { return this._requestId; }
        }


        public int PayAmount
        {
            get { return this._payAmount; }
        }


        public string PayCurrency
        {
            get { return this._payCurrency; }
        }


        public string Version
        {
            get { return this._version; }
        }


        public string Account
        {
            get { return this._account; }
        }


        public int? PersonCodeStatus
        {
            get { return this._personCodeStatus; }
        }


        public Dictionary<string, string> AdditionalParameters
        {
            get { return this._additionalParameters; }
        }

    }
}
