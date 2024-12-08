using AuctionProject.Models.Common;

namespace AuctionProject.Models.Entities
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }          // The date and time when the order was placed

        public decimal TotalAmount { get; set; }         // The total amount for the order

        public string ShippingAddress { get; set; }      // The shipping address for the order

        public string OrderStatus { get; set; }          // The current status of the order (e.g., Pending, Shipped)

        public string PaymentStatus { get; set; }        // The status of the payment (e.g., Pending, Paid)

        public string PaymentMethod { get; set; }        // The method used for payment (e.g., Credit Card, PayPal)

        public string ShippingMethod { get; set; }        // The method of shipping (e.g., Standard, Express)

        public DateTime? EstimatedDeliveryDate { get; set; } // Estimated delivery date

        public DateTime? OrderCompleted { get; set; }    // Date when the order was completed (nullable)

        // Navigation property to the user (Optional)
        public string AppUserId { get; set; } // Foreign key to the User who placed the order
        public AppUser AppUser { get; set; }
    }
}
