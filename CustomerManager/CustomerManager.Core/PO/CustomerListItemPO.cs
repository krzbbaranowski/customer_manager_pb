namespace CustomerManager.Core.PO
{
    public class CustomerListItemPO
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Number { get; set; }

        public string AvatarUrl { get; set; }

        public string FullName
        {
            get { return $"{Name} {Surname}"; }
        }
    }
}