using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FINALMVC.BL
{
    public class VendorCollection
    {
        private Dictionary<string, Vendor> vendorCol;

        public VendorCollection()
        {
            vendorCol = new Dictionary<string, Vendor>();
        }
        public void AddVendor(Vendor v)
        {
            vendorCol.Add(v.vendorId, v);
        }

        public Vendor GetVendor(string id)
        {
            return vendorCol[id];
        }

        public List<Transaction> GetVendors(string id)
        {
            List<Vendor> transList = new List<Vendor>();

            foreach (KeyValuePair<string, Vendor> vend in vendorCol)
            {
                if (vend.Value.transactionId.ToUpper().Equals(id.ToUpper()))
                {
                    transList.Add(vend.Value);
                }
            }

            return vend;
        }

    }
}
