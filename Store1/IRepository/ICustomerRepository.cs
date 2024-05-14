using Store1.Entity;

namespace Store1.IRepository
{
    public interface ICustomerRepository
    {
        dynamic AddCustomer(CustomerInput input);
        dynamic ReadCustomer(CustomerInput input);
        dynamic UpdateCustomer(CustomerInput input);
        dynamic DeleteCustomer(CustomerInput input);
    }
}
