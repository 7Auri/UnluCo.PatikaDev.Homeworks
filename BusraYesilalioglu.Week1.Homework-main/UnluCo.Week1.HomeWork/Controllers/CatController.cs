using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.Week1.HomeWork.Controllers
{
    [Route("[controller]s")]
    [ApiController]
    public class CatController : ControllerBase
    {

        private static List<Cats> CatsList = new List<Cats>(){


        new Cats
        {
            Id = 1,
            Ad="Arya",
            Irk="British Shorthair",
            Cinsiyet="Dişi",
            Yas= 2,
            Renk="Siyah",
            DogumTarihi= new DateTime(2020,11,27)


        },
        new Cats
        {
            Id = 2,
            Ad="Oscar",
            Irk="British Shorthair",
            Cinsiyet="Erkek",
            Yas= 0.6,
            Renk="Gri-Beyaz-Siyah",
            DogumTarihi= new DateTime(2021,06,29)

            },
        new Cats
        {
            Id = 3,
            Ad="Pamir",
            Irk="British Shorthair",
            Cinsiyet="Erkek",
            Yas= 0.6,
            Renk="Gri",
            DogumTarihi= new DateTime(2021,06,29)

            },
         new Cats
        {
            Id = 4,
            Ad="Tarçın",
            Irk="British Shorthair",
            Cinsiyet="Erkek",
            Yas= 0.6,
            Renk="Kahverengi-Beyaz",
            DogumTarihi= new DateTime(2021,06,29)

            },
          new Cats
        {
            Id = 5,
            Ad="Mia",
            Irk="British Shorthair",
            Cinsiyet="Dişi",
            Yas= 0.6,
            Renk="Beyaz-Siyah",
            DogumTarihi= new DateTime(2021,06,29)

            }
        };
        [HttpGet("all")]


        public List<Cats> GetCats()
        {
            var catlist = CatsList.OrderBy(x => x.Id).ToList<Cats>();
            return catlist;
        }

        [HttpGet("{id}/catswithId")]

        public Cats GetById(int id)
        {
            var cat = CatsList.Where(cat => cat.Id == id).SingleOrDefault();
            return cat;
        }

        //  [HttpGet]  // [HttpGet("{id}")]'in farklı bir kullanım şekli. Ama yukarıda da [HttpGet] olduğu için diğer [HttpGet] ile aynı anda çalıştırılamıyor.

        //  public Cats Get([FromQuery]string id)
        // {
        //     var cat = CatsList.Where(cat => cat.Id == Convert.ToInt32(id)).SingleOrDefault();
        //     return cat;
        // }

        [HttpPost("addNewCat")]

        public IActionResult AddCat([FromForm] Cats newCat)
        {
            var cat = CatsList.SingleOrDefault(x => x.Id == newCat.Id);
            if (cat != null)
            {
                return BadRequest();  //Send empty value açık olursa bu hata alınıyor.

            }
            CatsList.Add(newCat);
            return StatusCode(201);
        }

        [HttpPut("{id}/updateCatInformations")]

        public IActionResult UpdateCat(int id, [FromForm] Cats updateCat)
        {

            var cat = CatsList.SingleOrDefault(x => x.Id == id);
            if (cat == null)
            {
                return BadRequest();
            }
            cat.Ad = updateCat.Ad != default ? updateCat.Ad : cat.Ad; // Eğer cat.Ad, updateCat.Ad'ten farklı ise cat.Ad'ı updateCat.Ad ile değiştir.
            cat.Yas = updateCat.Yas != default ? updateCat.Yas : cat.Yas;
            cat.Cinsiyet = updateCat.Cinsiyet != default ? updateCat.Cinsiyet : cat.Cinsiyet;
            cat.Irk = updateCat.Irk != default ? updateCat.Irk : cat.Irk;
            cat.Renk = updateCat.Renk != default ? updateCat.Renk : cat.Renk;
            cat.DogumTarihi = updateCat.DogumTarihi != default ? updateCat.DogumTarihi : cat.DogumTarihi;
            return Ok();

        }
        [HttpPatch("{id}/updateCatName")]
        public IActionResult UpdateCatAd(int id, [FromBody] Cats updateCatAd)
        {
            var cat = CatsList.SingleOrDefault(x => x.Id == id);
            if (cat == null)
            {
                return BadRequest();
            }
            cat.Ad = updateCatAd.Ad != default ? updateCatAd.Ad : cat.Ad;
            return Ok();
        }


        [HttpDelete("{id}deleteCat")]

        public IActionResult DeleteCat(int id)
        {
            var cat = CatsList.SingleOrDefault(x => x.Id == id);
            if (cat == null)
            {
                return BadRequest();
            }
            CatsList.Remove(cat);
            return Ok();

        }

        [HttpGet("List/{colon}/{orderby}")]
        public IActionResult GetCatList(string colon="Ad",string orderby = "asc")
        {
            var cat = new List<Cats>();
            if(colon=="Ad"&& orderby == "asc")
            {
                cat = CatsList.OrderBy(x => x.Ad).ToList();
            }
            else if(colon=="Ad"&& orderby == "desc")
            {
                cat = CatsList.OrderByDescending(x => x.Ad).ToList();
            }
            if (cat.Count == 0)
            {
                return NotFound("Liste Boş");
            }
            return Ok(cat);
        }

    }
}
