﻿using Data.IRepositories;
using Data.Models;
using Data.Repositories;
using Data.ShopContext;
using Microsoft.AspNetCore.Mvc;

namespace API_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponsController : ControllerBase
    {
        public IAllRepositories<Coupons> _irepos;
        AppDbContext DbContext;

        public CouponsController()
        {
            DbContext = new AppDbContext();
            AllRepositories1<Coupons> repos = new AllRepositories1<Coupons>(DbContext, DbContext.Coupons);
            _irepos = repos;

        }
        // GET: api/<BillController>
        [HttpGet("Show-Coupons")]
        public IEnumerable<Coupons> GetAllCoupons()
        {
            return _irepos.GetAll();
        }


        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Coupons Get(Guid id)
        {
            return _irepos.GetAll().First(p => p.Id == id);
        }
        // POST api/<BillController>
        [HttpPost("Create-Coupons")]
        public bool CreateCoupons(int DiscountValue, int Quantity, string VoucherName)
        {
            Coupons coupon = new Coupons();
            coupon.DiscountValue = DiscountValue;
            coupon.Quantity = Quantity;
            coupon.VoucherName = VoucherName;
            coupon.TimeStart = DateTime.Now;
            coupon.TimeEnd = DateTime.Now.AddDays(7);

            return _irepos.Create(coupon);
        }

        // PUT api/<BillController>/5
        [HttpPut("edit-Coupons-{id}")]
        public bool UpdateCoupons(Guid id, int DiscountValue, int Quantity, string VoucherName, DateTime TimeStart, DateTime TimeEnd)
        {
            Coupons coupon = _irepos.GetAll().FirstOrDefault(p => p.Id == id);
            coupon.DiscountValue = DiscountValue;
            coupon.Quantity = Quantity;
            coupon.VoucherName = VoucherName;
            coupon.TimeStart = TimeStart;
            coupon.TimeEnd = TimeEnd;
            return _irepos.Update(coupon);
        }

        // DELETE api/<BillController>/5
        [HttpDelete("Delete-Coupons-/{id}")]
        public bool Delete(Guid id)
        {
            Coupons coupon = _irepos.GetAll().FirstOrDefault(p => p.Id == id);
            return _irepos.Delete(coupon);
        }
    }
}