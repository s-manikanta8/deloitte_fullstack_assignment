using AutoMapper;

namespace WebApplicationautomapper.data
{
    public class InvoiceProfile:Profile
    {
        public InvoiceProfile() {
            //CreateMap<Invoice, InvoiceDTO>();
            CreateMap<Invoice, InvoiceDTO>()
               // .ForMember(dest => dest.Descriptionofpayment,
              //  opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.DiscountedPrice, opt => opt.Condition(src => src.Amount > 100))
            .ForMember(dest => dest.DiscountedPrice, opt => opt.MapFrom(src => src.Amount * 0.9M));

            
        }
    }
}
