using System;

public class cardHolder {

    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;

    // initialize constructor
    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance) {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName
        this.balance = balance;
    }

    // getters
    public string getNum() {
        return cardNum;
    }

    public int getPin() {
        return pin;
    }

    public string getFirstName() {
        return firstName;
    }

    public string getLastName() {
        return lastName;
    }

    public double getBalance() {
        return balance;
    }

    // setters
    public void setNum(string newCardNum) {
        cardNum = newCardNum;
    }

    public void setPin(int newPin) {
        pin = newPin;
    }

    public void setFirstName(string newFirstName) {
        firstName = newFirstName;
    }

    public void setLastName(string newLastName) {
        lastName = newLastName;
    }

    public void setBalance(double newBalance) {
        balance = newBalance;
    }

    // Main method to run atm
    public static void Main(String[] args) {
        // Gives user different options
        void printOptions() {
            Console.WriteLine("Please choose from the following options");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        // Handles deposits from user
        void deposit(cardHolder currentUser) {
            Console.WriteLine("How much to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit + balance);
            Console.WriteLine("Thanks for depositing. Your new balance is: " + currentUser.getBalance);
        }

        // Manage withdraws
        void withdraw(cardHolder currentUser) {
            Console.WriteLine("How much would you like to withdraw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            // Check if user has enough money
            if (currentUser.getBalance() < withdrawal) {
                Console.WriteLine("Insufficient balance: ");
            }
            else {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Thank you. You're good to go")
            }
        }

        // Balance
        void balance(cardHolder currentUser) {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }

        // Create list of cardholders
        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("4843707622692872", 1234, "John", "Jones", 3990.34));
        cardHolders.Add(new cardHolder("4916820856540816", 4356, "April", "Ninja", 3343.45));
        cardHolders.Add(new cardHolder("4716337454863237", 5234, "Mike", "Jones", 345.09));
        cardHolders.Add(new cardHolder("4916946031895799", 0982, "Jeff", "Jones", 432));
        cardHolders.Add(new cardHolder("4485361277545705", 4321, "Jimbo", "Jones", 435.78));

        // Prompt user
        Console.WriteLine("Welcome to my ATM");
        Console.WriteLine("Please insert your card: ");
        string debitCardNum = "";
        cardHolder currentUser;

        while(true) {
            try {
                debitCardNum = Console.ReadLine
                // Check against our db
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum === debitCardNum);
                if (currentUser != null) {
                    break;
                }
                else {
                    Console.WriteLine("Card not recognized. Please try again");
                }
            }
            catch {
                    Console.WriteLine("Card not recognized. Please try again");
            }
        }

        // Check user's pin against db
        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;

        while (true) {
            try {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin) {
                    break;
                } 
                else {
                    Console.WriteLine("Incorrect pin. Please try again.")
                }
        }
            catch {
                Console.WriteLine("Incorrect pin. Please try again.")
        } 
        }

        // Start program by welcoming user 
        Console.WriteLine("Welcome " + currentUser.getFirstName());
        int option = 0;
        do {
            printOptions();
            try {
                option = int.Parse(Console.Readline());
            }
            catch {
                if (option == 1) {
                    deposit(currentUser);
                }
                else if (option == 2) {
                    withdraw(currentUser);
                }
                else if (option == 3) {
                    balance(currentUser);
                }
                else {
                    option = 0;
                }
            }
        }
        while (option != 4);
        Console.WriteLine("Thank you. Have a nice day!")
    }

}

