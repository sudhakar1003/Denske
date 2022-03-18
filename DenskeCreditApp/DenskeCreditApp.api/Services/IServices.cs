using DenskeCreditApp.api.Services.ResponceModel;

namespace DenskeCreditApp.api.Services
{
    public interface IServices
    {
        CreditResponceModel GetCreditDetails(double applliedAmount);
    }
}
