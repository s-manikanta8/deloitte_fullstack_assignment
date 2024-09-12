using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationautomapper.data;

namespace WebApplicationautomapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMapper _mapper;
        public ValuesController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetInvoice()
        {
            Invoice invoicedata = new Invoice()
            {
                Id = 1,
                Name = "mani",
                Description = "Food",
                Phone = "999999999",
                Email = "mani@gmail.com",
                Amount = 1200
            };
           /* InvoiceDTO invoicedto = new InvoiceDTO()
            {
                Name = invoicedata.Name,
                Description = invoicedata.Description,
                Amount = invoicedata.Amount

            };*/
           InvoiceDTO invoicedto = _mapper.Map<InvoiceDTO>(invoicedata);


            return Ok(invoicedto);
        }

    }
}
