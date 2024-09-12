using System;

namespace BethanysPieShop2HRM.Accounting;

public record Account
{
  private string accountNumber;

  public string AccountNumber
  {
    get { return accountNumber; }
    set { accountNumber = value; }
  }
} 
