using Microsoft.AspNetCore.Mvc;
using PrimeiroMVC.Models;

namespace PrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Thiago Vanucci", "thiago.dev24@gmail.com", 4413);
            Aluno a2 = new Aluno(2, "Pedro Henrique", "mxpedro.araujo11@gmail.com", 8899);
            Aluno a3 = new Aluno(3, "Erick Penazzi", "djerick@gmail.com", 4044);
            Aluno a4 = new Aluno(4, "Tiago Perereira", "tiago.pereira@gmail.com", 3980);
            Aluno a5 = new Aluno(5, "marcus Vinicius", "marcus.mvn@gmail.com", 4273);

            //Criar uma lista de alunos 
            List<Aluno> ListaAlunos = new List<Aluno>();
            //adicionar os objetos alunos na lista de alunos
            ListaAlunos.Add(a1);
            ListaAlunos.Add(a2);
            ListaAlunos.Add(a3);
            ListaAlunos.Add(a4);
            ListaAlunos.Add(a5);
            //enviando a lista de Alunos por parametros na View index
            return View(ListaAlunos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
