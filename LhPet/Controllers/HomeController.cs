using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LhPet.Models;

namespace LhPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Instancia clientes
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira ", "123.456.789-00", "arthur.antunes@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "William Henry Gates III", "987.654.321-00", "william.henry@microsoft.co,", "Bug");
        Cliente cliente3 = new Cliente(03, "Ada Lovelace", "543.123.789-00", "ada.lovelace@sesi.br", "Byron");
        Cliente cliente4 = new Cliente(04, "Linus Torvalds", "555-444-333-00", "linus.torvalds@google.com", "Pingui ");
        Cliente cliente5 = new Cliente(05, "Grace Hopper", "333-444-555", "grace.hopper@facebook.com", "Byron");
        //Instancia de fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102.0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15.833.3308.0001-70", "ctrl@dog.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Java PET S/A", "44.222.892.8547-90", "java-c@pet.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Ruby PET S/A", "44.372.102.0001-80", "ruby-rails@sp.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Css PET S/A", "54.892.567.7841-99", "css.html@vscode.com");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
        ViewBag.listaClientes = listaClientes;

        List<Fornecedor> ListaFornecedores = new List<Fornecedor>();
        ListaFornecedores.Add(fornecedor1);
        ListaFornecedores.Add(fornecedor2);
        ListaFornecedores.Add(fornecedor3);
        ListaFornecedores.Add(fornecedor4);
        ListaFornecedores.Add(fornecedor5);

        ViewBag.ListaFornecedores = ListaFornecedores;

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
