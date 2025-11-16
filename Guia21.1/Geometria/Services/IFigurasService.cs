
using Geometria.Models;

namespace Geometria.Services;

public interface IFigurasService
{
    Task<List<FiguraModel>> GetAll();
    Task<FiguraModel> GetById(int id);
   Task<FiguraModel> AddFigura(FiguraModel nueva);
    
}
