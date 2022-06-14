using System.Collections.Generic;

namespace EVP.WebToPay.ClientAPI
{
    internal class EnhancedDictionary<Tkey, Tvalue> : Dictionary<Tkey, Tvalue>
    {

        public EnhancedDictionary(Dictionary<Tkey, Tvalue> source)
        {
            foreach (KeyValuePair<Tkey, Tvalue> keyValue in source)
            {
                this[keyValue.Key] = keyValue.Value;
            }
        }


        public Tvalue Take(Tkey key)
        {
            Tvalue value = this[key];
            this.Remove(key);
            return value;
        }

    }
}
