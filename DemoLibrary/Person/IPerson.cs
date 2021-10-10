namespace DemoLibrary.Person
{
    /// <summary>
    /// Person
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// First name
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        string PhoneNumber { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        string EmailAddress { get; set; }
    }
}