namespace Store1.Entity
{
    public class CustomerInput
    {
        public int? ID { get; set; }
        public string? CustomerName { get; set; }
        public string? Email { get; set; }
        public long? PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? FatherName { get; set; }
        public string? DOB { get; set; }
        public string? Country { get; set; }


        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public int PageNumberCount
        {
            get
            {
                return PageNumber++;
            }
        }


    }
}
