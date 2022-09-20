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

    public string getBalance() {
        return balance;
    }

}

