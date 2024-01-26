﻿using System.Collections.Generic;
using _0_Framwork.Domain;
using ShopManagement.Application.Contracts.Order;

namespace ShopManagement.Domain.Order
{
    public interface IOrderRepository : IRepository<int, OrderEntity>
    {
        double GetAmountBy(int id);
        List<OrderVIewModel> GerOrders();
        List<OrderItemViewModel> GerOrderItems(int orderId);
    }
}