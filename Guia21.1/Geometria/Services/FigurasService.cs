using Geometria.DAOs;
using Geometria.Models;

namespace Geometria.Services;

public class FigurasService:IFigurasService
{
    IFigurasDAO _figurasDAO;

    public FigurasService(IFigurasDAO figurasDAO)
    {
        _figurasDAO = figurasDAO;
    }

    async public Task<List<FiguraModel>> GetAll()
    {
        return await _figurasDAO.GetAll();
    }

    async public Task<FiguraModel> GetById(int id)
    {
        return await _figurasDAO.GetById(id);
    }

    async public Task<FiguraModel> AddFigura(FiguraModel nueva)
    {
        return await _figurasDAO.Add(nueva);
    }
}