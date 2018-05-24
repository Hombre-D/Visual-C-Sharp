//Exercise 4.10, Invoice class

class Invoice
{
    public string PartNumber { get; set; }
    public string Description { get; set; }
    private int quantity;
    private decimal pricePerItem;

    public Invoice (string partNumber, string description, int quantity, decimal pricePerItem)
    {
        PartNumber = partNumber;
        Description = description;
        Quantity = quantity;
        PricePerItem = pricePerItem;
    }

    public int Quantity
    {
        get
        {
            return quantity;
        }

        set
        {
            if (value > 0)
            {
                quantity = value;
            }
        }
    }

    public decimal PricePerItem
    {
        get
        {
            return pricePerItem;
        }

        set
        {
            if (value > 0.0m)
            {
                pricePerItem = value;
            }
            
        }
    }

    public decimal GetInvoiceAmount()
    {
        return quantity * pricePerItem;
    }

}
