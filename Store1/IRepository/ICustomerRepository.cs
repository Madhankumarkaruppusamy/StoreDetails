using Store1.Entity;

namespace Store1.IRepository
{
    public interface ICustomerRepository
    {
        dynamic AddCustomer(CustomerInput input);
        dynamic AddNewCustomer(CustomerInput add);
        dynamic ReadCustomer(CustomerInput input );
        dynamic UpdateCustomer(CustomerInput input);
        dynamic DeleteCustomer(int ID);
    }
}
