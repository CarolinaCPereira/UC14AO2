using ExoApi.Contexts;
using ExoApi.Models;

namespace ExoApi.Repositories
{
    public class ProjetoRepository
    {

        private readonly SqlContext _context;
        public ProjetoRepository(SqlContext context)
        {
            _context = context;
        }
        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }
        public Projeto BuscarPorId(int id)
        {
            return _context.Projetos.Find(id);
        }

        public void Cadastrar(Projeto p)
        {
            _context.Projetos.Add(p);
            _context.SaveChanges();
        }
        public void Deletar(int id)
        {
            Projeto p = _context.Projetos.Find(id);

            _context.Projetos.Remove(p);
            _context.SaveChanges();

        }

        public void Alterar(int id, Projeto p)
        {
            Projeto projetobuscado = _context.Projetos.Find(id);
            if (projetobuscado != null)
            {
                projetobuscado.Titulo = p.Titulo;
                projetobuscado.Status = p.Status;
                projetobuscado.Tecnologias = p.Tecnologias;

                _context.Livros.Update(projetobuscado);
                _context.SaveChanges();
            }
        }
    }
}


