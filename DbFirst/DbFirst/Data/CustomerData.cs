﻿using DbFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbFirst.Data
{
    public class CustomerData:ICustomer
    {
        SalesDbContext db;

        public CustomerData(SalesDbContext _db)
        {
            db = _db;
        }

        public IEnumerable<Customer> GetData()
        {

            var context = new SalesDbContext();
            try
            {


                var result = context.Customer.Include(s => s.Orders).ToList();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public Customer GetDataById(int id)
        {
            var context = new SalesDbContext();


            try
            {
                var result = context.Customer.Where(c => c.CustomerId == id).Include(s => s.Orders).ThenInclude(s => s.FkProduct).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool InsertData(Customer customer)
        {
            var context = new SalesDbContext();
            try
            {

                context.Add(customer);
                context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool DeleteData(Orders orders)
        {
            try
            {
                var context = new SalesDbContext();
                var o = context.Customer.First(d => d.CustomerId == orders.FkCustomerId);
                context.Customer.Remove(o);


                var c = context.Orders.First(d => d.OrderId == orders.OrderId);
                context.Orders.Remove(c);

              

                var p = context.Product.First(d => d.ProductId == orders.FkProductId);
                context.Product.Remove(p);

                var result=context.SaveChanges();
                if (result > 0)
                    return true;
                else
                    return false;

                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateData(int id,Orders orders)
        {
            try
            {
                var context = new SalesDbContext();
                var std = context.Orders.Include(o => o.FkCustomer).Include(p => p.FkProduct).FirstOrDefault(s => s.OrderId == id);


                //std.FkCustomer.CustomerId = orders.FkCustomerId;
                //std.FkProduct.ProductId = orders.FkProductId;
                ///std.FkProduct.ProductId = orders.FkProductId;
                std.FkProductId = orders.FkProductId;
                std.OrderDate = orders.OrderDate;
                
                std.Quantity = orders.Quantity;
                


                context.Entry(std).State = EntityState.Modified;
                context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
