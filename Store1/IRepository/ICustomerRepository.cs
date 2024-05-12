using Store1.Entity;

namespace Store1.IRepository
{
    public interface ICustomerRepository
    {
        dynamic AddCustomer(CustomerInput input);
    }
}
