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
            
        }
    }

}

