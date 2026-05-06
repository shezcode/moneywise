namespace moneywise.Core.Models;

public class Transaction
{
  public int Id { get; set; }
  public int AccountId { get; set; }
  public string Description { get; set; } = string.Empty;
  public decimal Amount { get; set; }
  public bool IsIncome { get; set; }
  public DateTime TransactionDate { get; set; }

  public string Category { get; set; } = string.Empty;

  public int ReferenceNumber { get; set; }
}