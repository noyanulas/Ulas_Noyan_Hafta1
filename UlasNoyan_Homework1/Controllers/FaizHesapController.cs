using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UlasNoyan_Homework1.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class FaizHesapController : ControllerBase
    {




        [HttpGet("Anlık Bileşik Faiz Hesaplama")]
        public string Get(float AnaPara, double FaizOrani, double DonemMiktari)
        {
            double anlik_Sureli = 2.71;
            
            for (int i = 0; i < DonemMiktari*FaizOrani - 1; i++)
            {
                anlik_Sureli *= 2.71;
            }
            double FaizGetirisi = AnaPara * anlik_Sureli;
            return "Toplam Bakiye: " + Convert.ToString(FaizGetirisi) + " Toplam Kazanılan Faiz Tutarı: " + Convert.ToString(FaizGetirisi-AnaPara);
             
        }
    }
}

