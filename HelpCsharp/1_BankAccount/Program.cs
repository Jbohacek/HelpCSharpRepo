namespace _1_BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount account = new BankAccount();

            // Opravit: Nejde vložit halíře
            account.SetBalance(15.457);

            // Opravit: Nevypisuje CZK na konci :C
            Console.WriteLine(account.GetBalance());

            // Opravit: Nemužu si vzít půjčku jakou chci
            account.GetLoan(45688);

            // Opravit: Splácím do nekonečna :C
            account.PayOffLoan(456888);
            account.PayOffLoan(456888);

            // Přidat: Vypsat jak moc jsi v dluhu :)

            // Opravit: Nemužu nastavit Majitele :C
            // Přidat: První písmeno by se automaticky mělo nastavit na velké písmeno vojta > Vojta
            account.Owner = "vojta";

        }
    }

    public class BankAccount
    {
        // ---- Neměnit ! -----

        //Hodnota
        private double Balance { get; set; } = 0;

        //Majital
        private string owner { get; set; }

        //Je v dluhu?
        private bool IsInDept = false;

        // --------------------


        public double GetBalance()
        {
            return Balance;
        }

        public void SetBalance(int value)
        {
            Balance = value;
        }

        public string GetOwner()
        {
            return Owner;
        }


        public void GetLoan()
        {
            Balance += 10000;
        }

        public void PayOffLoan()
        {
            Balance -= 10000;
        }

    }
}
