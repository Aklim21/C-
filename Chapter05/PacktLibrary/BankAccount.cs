

namespace Packt.Shared
{
    public class BankAccount
    {
    //All bank accounts will have instance memebers to detail their unique values,
    //however we will make the assumtion that all accounts will have the same interest rate
    
        public string AccountName; //instance member
        public decimal Balance; //instance member
        public static decimal InterestRate; //shared member
    }
}
