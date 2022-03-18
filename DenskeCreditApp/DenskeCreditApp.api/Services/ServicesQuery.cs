using DenskeCreditApp.api.Services.ResponceModel;

namespace DenskeCreditApp.api.Services
{
    public class ServicesQuery : IServices
    {
        public CreditResponceModel GetCreditDetails(double applliedAmount)
        {
            CreditResponceModel crm = new CreditResponceModel();
            if (applliedAmount<20000)
            {
                    crm.IntrestRate = 3;
                    crm.DecisionSelection = "No";
            }
            else if (applliedAmount >=20000 && applliedAmount<=39000)
            {
                crm.IntrestRate = 4;
                crm.DecisionSelection = "Yes";
            }
            else if (applliedAmount >= 40000 && applliedAmount <= 59000)
            {
                crm.IntrestRate = 5;
                crm.DecisionSelection = "Yes";
            }
            else if (applliedAmount >60000)
            {
                crm.IntrestRate = 6;
                crm.DecisionSelection = "No";
            }
            return crm;
        }
    }
}
