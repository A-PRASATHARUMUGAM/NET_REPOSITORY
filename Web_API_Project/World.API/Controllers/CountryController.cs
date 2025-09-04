using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using World.API.Data;
using World.API.DTO.Country;
using World.API.Models;

namespace World.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;


        public CountryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Fetch the Records 
        [HttpGet]
        public ActionResult<IEnumerable<Country>> GetALL()
        {

            var countries = _dbContext.Countries.ToList();
            if(countries == null)
            {
                return NoContent();
            }
            return Ok(countries);
        }


        //Fetch the Specific Data using Id 
        [HttpGet("{id:int}")]
        public ActionResult<Country> GetById(int id)
        {
            var country= _dbContext.Countries.Find(id);

            if(country == null)
            {
                return NoContent();
            }
            return Ok(country);
        }


        //create New Record
        [HttpPost]
        public ActionResult<CreateCountryDTO> Create([FromBody] CreateCountryDTO countryDTO)
        {


            Country country = new Country();

            country.Name = countryDTO.Name;
            country.ShortName = countryDTO.ShortName;
            country.CountryCode = countryDTO.CountryCode;
            _dbContext.Countries.Add(country);
            _dbContext.SaveChanges();
            return Ok();
        }

        //Update the Data

        [HttpPut]
        public ActionResult<Country> Update([FromBody] Country country)
        {
            _dbContext.Countries.Update(country);
            _dbContext.SaveChanges();
            return Ok();
        }

        //Delete the Data

        [HttpDelete("{id:int}")]
        public ActionResult DeleteById(int id)
        {
            var country = _dbContext.Countries.Find(id);
            _dbContext.Countries.Remove(country);
            _dbContext.SaveChanges();
            return Ok();
        }

      
    }
}
