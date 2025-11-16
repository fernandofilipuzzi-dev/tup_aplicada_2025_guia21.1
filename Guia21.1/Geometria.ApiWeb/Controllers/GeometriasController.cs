using ASP.NET.Core.API.DTOs;
using Geometria.Models;
using Geometria.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Core.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GeometriasController : Controller
{

    readonly IFigurasService _figurasService;

    public GeometriasController(IFigurasService figurasService)
    {
        this._figurasService = figurasService;
    }

    // GET: api/<GeometriaController>
    [HttpGet]
    async public Task<ActionResult<List<FiguraDTO>>> Get()
    {
        var figuras=from f in await _figurasService.GetAll()
                    select new FiguraDTO
                    {
                        Id = f.Id,
                        Tipo = f is RectanguloModel ?0:1,
                        Area = f.Area,
                        Ancho = f is RectanguloModel ? ((RectanguloModel)f).Ancho : null,
                        Largo = f is RectanguloModel ? ((RectanguloModel)f).Largo : null,
                        Radio = f is CirculoModel ? ((CirculoModel)f).Radio : null,
                    };

        if (figuras.Any() == false) return NotFound("No se encontraron figuras");
        return Ok(figuras);
    }

    // GET api/<GeometriaController>/5
    [HttpGet("{id}")]
    async public Task<ActionResult<FiguraDTO>> Get(int id)
    {
        var figura = (from f in new List<FiguraModel>{  await _figurasService.GetById(id)}
                      select new FiguraDTO
                      {
                          Id = f.Id,
                          Tipo = f is RectanguloModel ? 1 : 0,
                          Area = f.Area,
                          Ancho = f is RectanguloModel ? ((RectanguloModel)f).Ancho : null,
                          Largo = f is RectanguloModel ? ((RectanguloModel)f).Largo : null,
                          Radio = f is CirculoModel ? ((CirculoModel)f).Radio : null,
                      }).FirstOrDefault();

        if (figura == null) return NotFound("No se encontro la figura");

        return Ok(figura);
    }

    // POST api/<GeometriaController>
    [HttpPost]
    async public Task<ActionResult<FiguraDTO>> Post([FromBody] FiguraDTO figuraDTO)
    {
        FiguraModel figura = null;
        if (figuraDTO.Tipo == 0)
        { 
            figura= new RectanguloModel
            {
                Area = figuraDTO.Area,
                Ancho = figuraDTO.Ancho,
                Largo = figuraDTO.Largo
            };
        }
        else if (figuraDTO.Tipo == 0)
        {
            figura = new CirculoModel
            {
                Area = figuraDTO.Area,
                Radio = figuraDTO.Radio
            };
        }

        var figuraNueva = await _figurasService.AddFigura(figura);
        figuraDTO.Id = figuraNueva.Id;

        return Ok(figuraDTO);    
    }

    // PUT api/<GeometriaController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] FiguraDTO value)
    {
        //var figura = (from f in figuras where f.Id == id select f).FirstOrDefault();
        //figura.Ancho = value.Ancho;
        //figura.Largo = value.Largo;
        //figura.Radio = value.Radio;
        //figura.Tipo = value.Tipo;
    }

    // DELETE api/<GeometriaController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        //var figura = (from f in figuras where f.Id == id select f).FirstOrDefault();
        //figuras.Remove(figura);
    }
}