using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book
{
    public string accountHolderName;
    public float balance;
    static public int accountCount;
    public void InitializeAccount(string holderName, float initialBalance)
    {
        accountHolderName = holderName;
        balance = initialBalance;
    }

    public void Deposit(float amount)
    {
        balance += amount;
        Debug.Log(balance);
    }
    public void Withdraw(float amount)
    {
           if (amount > balance)
        {
            Debug.Log("Insufficient funds. Cannot withdraw " + amount);
        }
        else
        {
            balance -= amount; 
            Debug.Log("Withdrawal successful. Updated balance: " + balance);
        }
    }
      public void ShowAccountCount()
    {
        Debug.Log("Total accounts: " + accountCount);
    }


    /*
        public string model;
        public int fuel;
        static public int carCount;
        public void InitializeCar(string carModel, int initialFuel)
        {
            model = carModel;
            fuel = initialFuel;
            carCount++;
        }
        public void Refuel(int amount)
        {
            fuel += amount;
            Debug.Log(fuel);
        }
        public void Refuel(bool fullTank)
        {
            if (fullTank == true)
            {
                fuel = 100;
            }
        }
        public void ShowCarCount()
        {
            Debug.Log(carCount);

        }
    */





    /*
    public string title;
    public int pages;
    static public int bookCount;
    public void InitializeBook(string bookTitle, int bookPages)
    {
        title = bookTitle;
        pages = bookPages;
        bookCount++;
    }
    public void AddPages(int numberOfPages)
    {
        pages+=numberOfPages;
        Debug.Log(numberOfPages);
    }

    public void ShowBookCount()
    {
        Debug.Log(bookCount);
    }*/
}
