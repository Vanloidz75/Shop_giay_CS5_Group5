﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data.Models;
using Newtonsoft.Json;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.Runtime.CompilerServices;
using ProjectViews.Models;

namespace ProjectViews.Controllers
{
    public class BillController : Controller
    {
        private readonly HttpClient _httpClient;
        public BillController()
        {
            _httpClient = new HttpClient();
        }
        // GET: BillController
        public async Task<IActionResult> Show()
        {
            string apiURL = $"https://localhost:7109/api/Bill";
            var response = await _httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var bills = JsonConvert.DeserializeObject<List<Bills>>(apiData);
            return View(bills);
        }

        // GET: BillController/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(Guid Id)
        {
            //string apiURLGetBill = $"https://localhost:7109/api/Bill/GetBillByID/{Id}";
            string apiURLGetBillDetail = $"https://localhost:7109/api/BillDetails/FillterByID/b2805f09-e799-4104-e1dd-08db5c14c0b9";

            //var responseGetBill = await _httpClient.GetAsync(apiURLGetBill);
            var responseGetBillDT = await _httpClient.GetAsync(apiURLGetBillDetail);

            //string apiDataBill = await responseGetBill.Content.ReadAsStringAsync();
            string apiDataBillDT = await responseGetBillDT.Content.ReadAsStringAsync();

            //var bill = JsonConvert.DeserializeObject<Bills>(apiDataBill);
            var billDTs = JsonConvert.DeserializeObject<List<BillDetails>>(apiDataBillDT);

            //var apiURLCoupon = $"https://localhost:7109/api/Coupons/{bill.IdCoupon}";
            //var responseGetCoupon = await _httpClient.GetAsync(apiURLCoupon);
            //string apiDataCoupon = await responseGetCoupon.Content.ReadAsStringAsync();
            //var coupon = JsonConvert.DeserializeObject<Coupons>(apiDataCoupon);

            BillsViewModel billViewMD = new BillsViewModel();
            int price = 0;
            foreach (var item in billDTs)
            {
                price += item.Price * item.Quantity;
            }

           // billViewMD.bill = bill;
            billViewMD.lstBillDT = billDTs;
            //billViewMD.sumPrice = price - price * (coupon.DiscountValue / 100);

            return View(billViewMD);
        }

        // GET: BillController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BillController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Bills bill)
        {

            string apiURL = $"https://localhost:7109/api/Bill/CreateBill";
            var content = new StringContent(JsonConvert.SerializeObject(bill), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(apiURL, content);

            if (response.IsSuccessStatusCode)
            {
                // Bill created successfully
                return this.RedirectToAction("Show");
            }

            return this.View();

        }

        // GET: BillController/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            string apiURL = $"https://localhost:7109/api/Bill/GetBillById/{id}";
            var response = await _httpClient.GetAsync(apiURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var bills = JsonConvert.DeserializeObject<Bills>(apiData);
            return View(bills);
            
        }

        // POST: BillController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Bills bill)
        {
            string apiURL = $"https://localhost:7109/api/Bill/UpdateBill/{id}";
            var content = new StringContent(JsonConvert.SerializeObject(bill), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(apiURL , content);

            if (response.IsSuccessStatusCode)
            {
                // Bill updated successfully
                return this.RedirectToAction("Show");
            }

            return this.View();
        }

        // GET: BillController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BillController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}