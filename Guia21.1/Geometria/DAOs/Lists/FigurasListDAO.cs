using Geometria.Models;

namespace Geometria.DAOs.Lists;

public class FigurasListDAO : IFigurasDAO
{

    List<FiguraModel> figuras = new List<FiguraModel>();
       

    async public Task<List<FiguraModel>> GetAll()
    {
        return figuras;
    }

    async public Task<FiguraModel?> GetById(int id)
    {
        return (from f in figuras where f.Id == id select f).FirstOrDefault();
    }

    async public Task<FiguraModel> Save(FiguraModel entidad)
    {
        entidad.Id = GenId();
        figuras.Add(entidad);
        return entidad;
    }
    
    async public Task<FiguraModel> Add(FiguraModel figura)
    {
        figura.Id = GenId();
        figuras.Add(figura);
        return figura;
    }

    async public Task<bool> Remove(int id)
    {
        var figura = await GetById(id);
        if (figura != null)
        {
            figuras.Remove(figura);
        }

        return true;
    }

    protected int? GenId()
    {
        return (from f in figuras select f.Id).DefaultIfEmpty(0).Max() + 1;
    }
}
