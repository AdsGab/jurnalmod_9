using Microsoft.AspNetCore.Mvc;
using modul9_1302220053;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul9_1302220053.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> t = new List<Mahasiswa>
        {
            new Mahasiswa("Gabrielle Adsense Felime", "1302220053",["Logmat","Matdis","AKA"],2022),
            new Mahasiswa("Reinhard Efraim Situmeang", "13022220001",["Alpro","Strukdat"],2022),
            new Mahasiswa("Muhammad Rizqi Fadilah", "1302220020",["Pemodelan","ADPL"],2022)

        };
        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return t;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return t[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa m)
        {
            t.Add(m);
        }

       

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            t.RemoveAt(id);
        }
    }
}
