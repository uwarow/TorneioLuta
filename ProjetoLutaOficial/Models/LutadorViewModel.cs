using ProjetoLutaOficial.Data;
using ProjetoLutaOficial.Repositories.Interface;

namespace ProjetoLutaOficial.Models
{
    public class LutadorViewModel : ILutadorRepository
    {
        public List<Lutador> Listagem()
        {
            List<Lutador> lista = new List<Lutador>();
            using (var db = new ApplicationContext())
            {
                List<Lutador> listaTemporaria = db.Lutadores.Where(p => p.Id > 0).ToList();

                foreach (Lutador lutador in listaTemporaria)
                {
                    lista.Add(lutador);
                }
            }
            return lista;
        }

        public void Update(Lutador lutador)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Lutadores.Update(lutador);
                db.SaveChanges();
            }

        }
    }
}
