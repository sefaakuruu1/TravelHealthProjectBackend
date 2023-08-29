using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deeneme2.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    public class TravelFormsController : Controller
    {
        private readonly TravelFormDataContext _context;

        public TravelFormsController(TravelFormDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("travelform/getallentries")]
        public List<TravelForm> GetAllEntries()
        {
            List<TravelForm> allForms = _context.TravelFormData.ToList();
            return allForms;
        }
        [HttpGet]
        [Route("travelform/getlatestentry/{id}")]
        public TravelForm GetLatestEntry()
            {

            // En büyük Id'ye sahip veriyi çekiyoruz
            TravelForm latestEntry = _context.TravelFormData.OrderByDescending(tf => tf.Id).FirstOrDefault();
            if (latestEntry != null)
            {
                // Ülke adına karşılık gelen rastgele bir fiyat alıyoruz.
                latestEntry.Price = (decimal)GetRandomPriceByCountry((latestEntry.Country).ToString());

                return latestEntry;
            }
            // Veri bulunamazsa hata sayfasına yönlendiriyoruz
            return null;
        }
        private decimal GetRandomPriceByCountry(string country)
        {
            // Ülke adına karşılık gelen rastgele bir fiyat almak için burada ilgili mantığı uygulamanız gerekecek.
            // Bu, bir veritabanı sorgusu veya önceden tanımlanmış bir eşleme kullanmayı içerebilir.
            // Basit bir örnek olarak, ülkeleri rastgele fiyatlara eşlemek için bir sözlük kullanalım.
            Dictionary<string, decimal> countryPriceMap = new Dictionary<string, decimal>
    {
        { "Antarctica", 75 },
        { "Afghanistan", 150 },
        { "France", 70 },
        { "Algeria", 100 },
        { "Italy", 50 },
        { "Iran", 125 },
        { "Belgium", 60 },
        { "Sweden", 50 },
        { "Norway", 40 },
        { "Argentina", 120 },
    };

            if (countryPriceMap.ContainsKey(country))
            {
                return countryPriceMap[country];
            }
            else
            {
                // Eğer eşleme bulunmazsa varsayılan bir fiyat döndürün
                return 300;
            }
        }



        [HttpPost]
      
        [Route("travelform/create")]
       
        public async Task<TravelForm> Create([FromBody] TravelForm travelForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(travelForm);
                await _context.SaveChangesAsync();
                return travelForm;
            }
            return travelForm;

        }
    }
}