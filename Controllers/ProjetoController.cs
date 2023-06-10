using ExoApi.Models;
using ExoApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

internal class Program
{
    private static void Main(string[] args)
    {
        namespaceExoApi.Controllers;
        {
            [Produces("application/json")]
            [Route("api/[controller]")]
            [ApiController]
            public }
    }

    private class ProjetoController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;
        public ProjetoController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }
        [HttpGet]
        public IActionResult Listar()
        {

            try
            {
                return Ok(_projetoRepository.Listar);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet("(id)")]
        public IActionResult BuscarPorId(int id)
        {

            try
            {
                Projeto projetobuscado = _projetoRepository.BuscarPorId(id);
                if (projetobuscado == null)
                {
                    return NotFound();
                }

                {
                    return Ok(projetobuscado);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        [HttpPost]

        public IActionResult Cadastrar(Projeto p)
        {
            try
            {
                _projetoRepository.Cadastrar(l);
                return StatusCode(201);
                //return Ok("Projeto cadastrado");

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete("(id)")]

        public IActionResult Deletar(int id)
        {
            try
            {
                _projetoRepository.Deletar(id);
                return Ok("Projeto deletado com sucesso");

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut("(id)")]

        public IActionResult Alterar(int id, Projeto p)
        {
            try
            {
                _projetoRepository.Alterar(id, p);
                return StatusCode(204);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }




    }
}
