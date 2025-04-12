using CadastroData.DTO;
using CadastroData.DAO;
using CadastroWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroWebApp.Controllers;
   
    public class ClienteController : Controller
    {
        ClienteDao clienteDao;
        ClienteDto clienteDto;


        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ClienteViewModel clienteVM)
        {
            if (ModelState.IsValid)
            {

                clienteDao = new ClienteDao();
                clienteDto = new ClienteDto();

                clienteDto.ClienteId = clienteVM.ClienteId;
                clienteDto.Empresa = clienteVM.Empresa;
                clienteDto.Endereço = clienteVM.Endereço;
                clienteDto.Telefone = clienteVM.Telefone;

                clienteDto.IncluiCliente(clienteDto);

                return RedirectToAction("Index");
            }


            return View();
        }

        public ClienteDao GetClienteDao()
        {
            return clienteDao;
        }

        [HttpGet]
        public IActionResult ListarCliente()
        {
            
            {
                clienteDao = new ClienteDao();
                clienteDto = new ClienteDto();
                ClienteViewModel clienteVM = new ClienteViewModel();

                List<ClienteViewModel> listar = new List<ClienteViewModel>();

                List<Cliente> listaDto = new List<Cliente>();

                List<Cliente> listaDao = new List<Cliente>(); 
            

                foreach (Cliente cliente in listaDto)
                {
                    ClienteViewModel clienteViewModel = new ClienteViewModel();
                    clienteVM.ClienteId = cliente.ClienteId;
                    clienteVM.Empresa = cliente.Empresa;
                    clienteVM.Endereço = cliente.Endereço;
                    clienteVM.Telefone = cliente.Telefone;

                    listar.Add(clienteVM);
                }

                return View(listar);
            }
        }
    }
    
