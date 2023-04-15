
using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302213043.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Mahasiswa : Controller
    {
        
        public static List<mahasiswa> mhs = new List<mahasiswa>
        {
            new mahasiswa {Nama = "Jaatsiyah Maulidina Astrianto", nim = "1302213043"},
            new mahasiswa {Nama = "Hilman Fariz Hirzi", nim = "1302213092"},
            new mahasiswa {Nama = "Putri Auliya Rahmah", nim = "1302210033"},
            new mahasiswa {Nama = "Rihan Hidayat", nim = "1302210028"},
            new mahasiswa {Nama = "Liyan Made Leon WAYAN", nim = "1302213037"}
        };

        // Mengembalikan output berupa list/array dari semua objek mahasiswa yang tersimpan
        [HttpGet]
        public IEnumerable<mahasiswa> Get()
        {
            return mhs;
        }

        // Mengembalikan output berupa objek mahasiswa untuk index ke-'index'
        [HttpGet("{idx}")]
        public mahasiswa Get(int idx)
        {
            return mhs[idx];
        }

        // Menambahkan objek mahasiswa baru dengan menyertakan nama dan nim
        [HttpPost]
        public IActionResult Post([FromBody] mahasiswa newMahasiswa)
        {
            mhs.Add(newMahasiswa);
            return Ok();
        }

        // Menghapus objek mahasiswa dengan index ke-'index'
        [HttpDelete("{idx}")]
        public IActionResult Delete(int idx)
        {
            if (idx >= mhs.Count)
            {
                return NotFound();
            }

            mhs.RemoveAt(idx);
            return Ok();
        }


    }

    public class mahasiswa
    {
        public string Nama { get; set; }
        public string nim { get; set; }
    }

}


