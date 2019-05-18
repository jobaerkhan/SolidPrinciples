using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.ISP.Solution
{
    //Separate ValidateCardInfo for Online Process Order so that CashOnDeliveryOrderProcess doesn't have to worry about Card Payment
    class CashOnDeliveryOrderProcess : IOrderProcess
    {
        public void ProcessOder()
        {
            // APPLICABLE
        }

        public bool ValidateShippingAddress()
        {
            // APPLICABLE
            return true;
        }
    }
}
