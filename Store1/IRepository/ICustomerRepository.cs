using Store1.Entity;

namespace Store1.IRepository
{
    public interface ICustomerRepository
    {
        dynamic AddCustomer(CustomerInput input);
        IEnumerable<FetchCustomerDetail> GetAll();
        dynamic ReadCustomer();
        //dynamic UpdateCustomer(CustomerInput input);
        //dynamic DeleteCustomer(CustomerInput input);
    }
}
