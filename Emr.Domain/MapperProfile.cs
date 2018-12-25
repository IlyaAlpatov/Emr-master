using AutoMapper;
using Emr.Database.Models;
using Emr.Domain.Accounts.Models;
using Emr.Domain.BloodTypes.Models;
using Emr.Domain.Common;
using Emr.Domain.Diagnos.Models;
using Emr.Domain.Drags.Models;
using Emr.Domain.Epmrs.Models;
using Emr.Domain.HealGroups.Models;
using Emr.Domain.Medics.Models;
using Emr.Domain.PatientRecords.Models;
using Emr.Domain.Patients.Models;
using Emr.Domain.Researchs.Models;
using Emr.Domain.RhesusFactors.Models;
using Emr.Domain.TypeOfDisability.Models;
using Emr.Domain.Vaccinations.Models;
using DiagnosInfo = Emr.Domain.Diagnos.Models.DiagnosInfo;

namespace Emr.Domain
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //TODO тут подклчючается мапеер
            CreateMap<UserRegInfo, User>()
                .ForMember(dest => dest.UserGuid, opt => opt.Ignore())
                .ForMember(dest => dest.Role, opt => opt.Ignore());

            CreateMap<PatientInfo, Patient>();
            CreateMap<Patient, PatientModel>();

            CreateMap<PatientRecordInfo, PatientRecord>();
            CreateMap<PatientRecord, PatientRecordModel>();

            CreateMap<DragInfo,Drag>();
            CreateMap<Drag, DragModel>();

            CreateMap<HealthInfo, HealthGroup>();
            CreateMap<HealthGroup, HealthModel>();

            CreateMap<BloodTypeInfo, BloodType>();
            CreateMap<BloodType, BloodTypeModel>();

            CreateMap<RhesusFactorInfo, RhesusFactor>();
            CreateMap<RhesusFactor, RhesusFactorModel>();

            CreateMap<ClientInfo, Client>();
            CreateMap<Client, ClientModel>();

            CreateMap<MedicInfo, Medic>();
            CreateMap<Medic, MedicModel>();

            CreateMap<TypeDisabilityInfo, Database.Models.TypeOfDisability>();
            CreateMap<Database.Models.TypeOfDisability, TypeDisabilityModel>();

            CreateMap<ResearchInfo, Research>();
            CreateMap<Research, ResearchModel>();

            CreateMap<ResearchResultInfo, ResearchResult>();
            CreateMap<ResearchResult, ResearchResultModel>();

            CreateMap<VaccinationInfo, Vaccination>();
            CreateMap<Vaccination, VaccinationModel>();

            CreateMap<VaccinationResultInfo, VaccinationResult>();
            CreateMap<VaccinationResult, VaccinationResultModel>();

            CreateMap<DiagnosInfo, Database.Models.Diagnos>();
            CreateMap<Database.Models.Diagnos, DiagnosModel>();

            CreateMap<EpmrInfo, ElectronicPersonalMedicalRecord>();
            CreateMap<ElectronicPersonalMedicalRecord, EpmrModel>();
        }
    }
}
