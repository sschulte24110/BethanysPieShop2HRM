using System;

namespace BethanysPieShop2HRM.HR;

internal class StoreManager : Employee
{
  public StoreManager(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate) : base(firstName, lastName, email, birthDay, hourlyRate)
  {
  }
}
