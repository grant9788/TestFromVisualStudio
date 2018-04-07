using System;

public class Class1
{
	public Class1()
	{

         void Main(string[] args)
        {
            double bankBal; // This is your bank balance
            Console.WriteLine("Please Enter how much is in your bank account");




            string UserInput = Console.ReadLine(); // User input for balance
            const double INT_RATE = 0.10; // Interest rate
            string InputStringL; // Input string for your loop responseq
            char Response; // User response to connect execution of program
            bankBal = Convert.ToDouble(UserInput);
            // Converting string UserInput to a double
            // Console.WriteLine("Do you want to see your bank balance? Y or N ");
            // InputStringL = Console.ReadLine();
            // Response = Convert.ToChar(InputStringL);

            do
            {
                Console.WriteLine("Bank Balance is {0}", bankBal.ToString("C"));
                bankBal = bankBal + bankBal * INT_RATE; // Your just taking the bank balance and multiply the interest rate
                Console.WriteLine("Do you want to see your bank balance? Y or N ");
                InputStringL = Console.ReadLine();
                Response = Convert.ToChar(InputStringL);

            } while (Response == 'Y');


            // Console.WriteLine(bankBal);
            // Console.ReadLine();
        }

    }
}
