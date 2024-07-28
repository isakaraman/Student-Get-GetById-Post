using BasicWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicWebApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class StudentController
	{
		static List<Students> students = new List<Students>
		{
			new Students{Id=1,Name="Pelorat"},
			new Students{Id=2,Name="Trevize"},
			new Students{Id=3,Name="Bliss"}

		};

		[HttpGet]
		public List<Students> Get()
		{
			return students;
		}

		[HttpGet("{id}")]
		public Students GetById(int id)
		{
			return students.FirstOrDefault(x=>x.Id==id);
		}

		[HttpPost]
		public Students Post(Students newStudent)
		{
			students.Add(newStudent);
			return newStudent;
		}
		
	}
}
