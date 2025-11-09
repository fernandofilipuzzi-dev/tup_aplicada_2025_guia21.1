
using Geometria.Models;

namespace Geometria.DAOs;

public interface IFigurasDAO
{
    Task<List<FiguraModel>> GetAll();
    Task<FiguraModel?> GetById(int id);
    Task<FiguraModel> Add(FiguraModel figura);
    Task<FiguraModel> Save(FiguraModel entidad);
    Task<bool> Remove(int id);
}
