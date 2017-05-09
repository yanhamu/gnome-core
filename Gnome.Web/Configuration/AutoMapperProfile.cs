using AutoMapper;

namespace Gnome.Web.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<DataAccess.FioTransaction, Api.Model.FioTransaction>()
                .ForMember(d => d.Amount, o => o.MapFrom(s => s.Amount))
                .ForMember(d => d.BankIndentifierCode, o => o.MapFrom(s => s.BankIndentifierCode))
                .ForMember(d => d.Comment, o => o.MapFrom(s => s.Comment))
                .ForMember(d => d.ConstantSymbol, o => o.MapFrom(s => s.ConstantSymbol))
                .ForMember(d => d.ContraAccount, o => o.MapFrom(s => s.ContraAccount))
                .ForMember(d => d.ContraAccountBankCode, o => o.MapFrom(s => s.ContraAccountBankCode))
                .ForMember(d => d.ContraAccountBankName, o => o.MapFrom(s => s.ContraAccountBankName))
                .ForMember(d => d.ContraAccountName, o => o.MapFrom(s => s.ContraAccountName))
                .ForMember(d => d.Currency, o => o.MapFrom(s => s.Currency))
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.MessageForReceiver, o => o.MapFrom(s => s.MessageForReceiver))
                .ForMember(d => d.MovementDate, o => o.MapFrom(s => s.MovementDate))
                .ForMember(d => d.MovementId, o => o.MapFrom(s => s.MovementId))
                .ForMember(d => d.Specification, o => o.MapFrom(s => s.Specification))
                .ForMember(d => d.SpecificSymbol, o => o.MapFrom(s => s.SpecificSymbol))
                .ForMember(d => d.TransactionExecutive, o => o.MapFrom(s => s.TransactionExecutive))
                .ForMember(d => d.TransactionId, o => o.MapFrom(s => s.TransactionId))
                .ForMember(d => d.TransactionType, o => o.MapFrom(s => s.TransactionType))
                .ForMember(d => d.UserIdentification, o => o.MapFrom(s => s.UserIdentification))
                .ForMember(d => d.VariableSymbol, o => o.MapFrom(s => s.VariableSymbol))
                .ReverseMap();
        }
    }
}
