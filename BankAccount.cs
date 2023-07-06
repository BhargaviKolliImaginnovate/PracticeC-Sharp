using System;
using System.Diagnostics.Contracts;
using System.Dynamic;
using Bank;

namespace Bank{

    class BankAccount{


 public int AccountNumber;
 public string HolderName;
 public double Balance;


public double deposite(int deposite){
   
    return  Balance+=deposite;;
  

}
public double withDrawal(int withDraw){
  return Balance-=withDraw;
}

public void displayDetailes(){
    
    Console.WriteLine($"AccountDetailes:\nAcoountNumber={AccountNumber} \nHolderName={HolderName}\nBalance={Balance}");

}
    }
}
class BankAccountTest{


BankAccount bankAccount;


public BankAccountTest(BankAccount bankAccount){
    this.bankAccount = bankAccount;
}


public static void Main(string[]args){

    BankAccount bank=new BankAccount();
    bank.Balance=50000;
    bank.AccountNumber=12345;
    bank.HolderName="Naveen";

    bank.displayDetailes();
    Console.WriteLine("Balance After deposite:" +bank.deposite(2000));
    Console.WriteLine("Balance after withdrawl:"+  bank.withDrawal(1000));


BankAccountTest test=new BankAccountTest(bank);

test.bankAccount.deposite(8000);
test.bankAccount.withDrawal(2000);
test.bankAccount.displayDetailes();

    

}

}