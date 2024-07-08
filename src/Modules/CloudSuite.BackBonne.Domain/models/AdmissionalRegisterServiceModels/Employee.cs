using CloudSuite.Modules.Commons.Enumerators.AdminssionalRegisterService;
using CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService;
using NetDevPack.Domain;
using Address = CloudSuite.Modules.Commons.ValueObject.AdmissionalRegisterService.Address;

namespace CloudSuite.BackBonne.Domain.models.AdmissionalRegisterService
{
    public class Employee : Entity, IAggregateRoot
    {
        public Employee( GenderEnum genderEnum , string? name, string? taxPayer, DateTime? dtBirth, int? gender, int? deficient, int? race, int? maritalStatus,
                        int? countryBirth, int? ufBirth, int? cityBirth, int? educationLevel, string? institutionEducational, int? course, string? nationalRegistry,
                        Address address, GeneralRegistration genRegister, MilitaryEnlistment certMilitary, PIS pis, WorkPermit workPermit, VotersTitle voteTitle,
                        List<Phone> phones, BankAccount bankAccount, List<Parent> parents, List<Dependent> dependents)
        {
            GenderEnum = genderEnum;
            Name = name;
            TaxPayer = taxPayer;
            DtBirth = dtBirth;
            Gender = gender;
            Deficient = deficient;
            Race = race;
            MaritalStatus = maritalStatus;
            CountryBirth = countryBirth;
            UfBirth = ufBirth;
            CityBirth = cityBirth;
            EducationLevel = educationLevel;
            InstitutionEducational = institutionEducational;
            Course = course;
            NationalRegistry = nationalRegistry;
            Address = address;
            GenRegister = genRegister;
            CertMilitary = certMilitary;
            PIS = pis;
            WorkPermit = workPermit;
            VoteTitle = voteTitle;
            Phones = phones;
            BankAccount = bankAccount;
            Parents = parents;
            Dependents = dependents;
        }

        public Employee() { }

        
        public Enum GenderEnum  { get; set; }
        public string? Name { get; private set; }
        
        public string? TaxPayer { get; private set; } 

        public DateTime? DtBirth { get; private set; }

        public int? Gender { get; private set; }

        public int? Deficient { get; private set; }

        public int? Race { get; private set; }

        public int? MaritalStatus { get; private set; }

        public int? CountryBirth { get; private set; }

        public int? UfBirth { get; private set; }

        public int? CityBirth { get; private set; }

        public int? EducationLevel { get; private set; }

        public string? InstitutionEducational { get; private set; }

        public int? Course { get; private set; }

        public string? NationalRegistry { get; private set; }

        public Address Address { get; private set; }

        public GeneralRegistration GenRegister { get; private set; }

        public MilitaryEnlistment CertMilitary { get; private set; }

        public PIS PIS { get; private set; }

        public WorkPermit WorkPermit { get; private set; }

        public VotersTitle VoteTitle { get; private set; }

        public List<Phone> Phones { get; private set; }

        public BankAccount BankAccount { get; private set; }

        public List<Parent> Parents { get; private set; }

        public List<Dependent> Dependents { get; private set; }
    }
} 
