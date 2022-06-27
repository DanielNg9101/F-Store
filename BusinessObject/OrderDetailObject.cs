﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject;
public class OrderDetailObject
{
    [Required]
    public int OrderId { get; set; }
    public OrderObject Order { get; set; }
    [Required]
    public int ProductId { get; set; }
    public ProductObject Product { get; set; }
    [Required, Column(TypeName = "money")]
    public double UnitPrice { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public double Discount { get; set; }
}
