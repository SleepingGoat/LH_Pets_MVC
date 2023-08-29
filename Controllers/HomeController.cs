using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LH_Pets_MVC.Models;
//using AspNetCore;

namespace LH_Pets_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Instâncias de Clientes
        Cliente cliente1 = new Cliente(1, "Pedro Sousa", "476.122.830-00", "pedro.sousa@gmail.com", "Chifu");
        Cliente cliente2 = new Cliente(2, "Ziraldo Nunes", "613.236.820-58", "zi.nunes@gmail.com", "Furi");
        Cliente cliente3 = new Cliente(3, "Manoel Gomes", "798.622.860-16", "manu.gomes@gmail.com", "Belinha");
        Cliente cliente4 = new Cliente(4, "Arilson Neto", "054.870.010-90", "ari.neto@gmail.com", "Kanzas");
        Cliente cliente5 = new Cliente(5, "Guilhermano Nogueira", "434.820.340-79", "gui.nog@gmail.com", "Mia");

        // Lista de Clientes
        List<Cliente> listaClientes =  new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        // Instâncias de Fornecedores
        Fornecedor fornecedor1 = new Fornecedor(1, "Cão de Ló", "63.982.600/0001-12", "cao.de.mel@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(2, "PETSauro", "69.229.687/0001-38", "petsauro@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(3, "Papagaio Amarelo", "18.807.495/0001-20", "papagaio.amarelo@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(4, "Gato Sapeca", "99.474.325/0001-73", "gato.sapeca@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(5, "Show de Cão", "09.549.810/0001-76", "show.de.cao@gmail.com");

        // Lista de Fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;
    
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
