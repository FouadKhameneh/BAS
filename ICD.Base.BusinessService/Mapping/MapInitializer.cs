using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
using ICD.Framework.AppMapper;
using ICD.Framework.Model;

namespace ICD.Base.BusinessService.Mapping
{
    public class MapInitializer : IMapperInitializer
    {
        public void Initialize(IMapperConfiguration config)
        {
            #region Person
            config.CreateMap<InsertPersonRequest, PersonEntity>();
            config.CreateMap<UpdatePersonRequest, PersonEntity>();
            config.CreateMap<UpdatePersonRequest, PersonLanguageEntity>();

            config.CreateMap<PersonView, InsertPersonModel>();

            config.CreateMap<PersonView, GetPeopleByspecificationModel>();
            config.CreateMap<ListQueryResult<PersonView>, GetPeopleByspecificationResult>();

            config.CreateMap<PersonView, GetPeopleByKeyModel>();
            #endregion

            #region PersonTest
            config.CreateMap<InsertPersonTestRequest, PersonTestEntity>();
            config.CreateMap<UpdatePersonTestRequest, PersonTestEntity>();

            config.CreateMap<PersonTestEntity, GetAllPersonTestsModel>()
                .ForMember(x => x.FirstName, y => y.FName);
            config.CreateMap<ListQueryResult<PersonTestEntity>, GetAllPersonTestsResult>();

            config.CreateMap<PersonTestEntity, GetPersonTestsByFirstNameModel>()
                .ForMember(x => x.FirstName, y => y.FName);
            config.CreateMap<ListQueryResult<PersonTestEntity>, GetPersonTestsByFirstNameResult>();
            #endregion

            #region PersonTitle
            config.CreateMap<InsertPersonTitleRequest, PersonTitleEntity>();
            config.CreateMap<UpdatePersonTitleRequest, PersonTitleEntity>();
            config.CreateMap<UpdatePersonTitleRequest, PersonTitleLanguageEntity>();

            config.CreateMap<PersonTitleView, GetPersonTitlesModel>();
            config.CreateMap<ListQueryResult<PersonTitleView>, GetPersonTitlesResult>();
            #endregion

            #region ItemGroup
            config.CreateMap<InsertItemGroupRequest, ItemGroupEntity>();
            config.CreateMap<UpdateItemGroupRequest, ItemGroupEntity>();
            config.CreateMap<UpdateItemGroupRequest, ItemGroupLanguageEntity>();

            config.CreateMap<ItemGroupView, GetItemGroupsByKeyModel>();

            config.CreateMap<ItemGroupView, GetItemGroupsModel>();
            config.CreateMap<ListQueryResult<ItemGroupView>, GetItemGroupsResult>();
            #endregion

            #region ItemRow
            config.CreateMap<InsertItemRowRequest, ItemRowEntity>();
            config.CreateMap<InsertItemRowRequest, ItemRowLanguageEntity>();

            config.CreateMap<ItemRowView, GetItemRowsModel>();
            config.CreateMap<ListQueryResult<ItemRowView>, GetItemRowsResult>();
            #endregion

            #region BaseType
            config.CreateMap<InsertBaseTypeRequest, BaseTypeEntity>();
            config.CreateMap<InsertPersonBaseTypeRequest, PersonBaseTypeEntity>();
            #endregion

            #region PersonIdentity
            config.CreateMap<InsertPersonIdentityRequest, PersonIdentityEntity>();
            config.CreateMap<UpdatePersonIdentityRequest, PersonIdentityEntity>();

            config.CreateMap<PersonIdentityEntity, GetPersonIdentityModel>();
            #endregion

            #region LocationEntity
            config.CreateMap<InsertLocationRequest, LocationEntity>();
            config.CreateMap<UpdateLocationRequest, LocationEntity>();
            config.CreateMap<UpdateLocationRequest, LocationLanguageEntity>();

            config.CreateMap<LocationView, GetLocationModel>();
            config.CreateMap<ListQueryResult<LocationView>, GetLocationResult>();
            #endregion

            #region ExpenseCenter
            config.CreateMap<InsertExpenseCenterRequest, ExpenseCenterEntity>();
            config.CreateMap<InsertExpenseCenterRequest, ExpenseCenterLanguageEntity>();
            config.CreateMap<UpdateExpenseCenterRequest, ExpenseCenterEntity>();

            config.CreateMap<ExpenseCenterView, GetExpenseCenterModel>();
            config.CreateMap<ListQueryResult<ExpenseCenterView>, GetExpenseCentersResult>();

            config.CreateMap<ExpenseCenterView, GetExpenseCenterByKeyModel>();
            #endregion

            #region Country
            config.CreateMap<InsertCountryRequest, CountryEntity>();
            config.CreateMap<UpdateCountryRequest, CountryEntity>();
            config.CreateMap<InsertCountryRequest, CountryLanguageEntity>();
            config.CreateMap<UpdateCountryRequest, CountryLanguageEntity>();

            config.CreateMap<CountryView, GetCountryModel>();
            config.CreateMap<ListQueryResult<CountryView>, GetCountryResult>();

            config.CreateMap<CountryView, GetCountryByKeyModel>();
            #endregion

            #region CostType
            config.CreateMap<InsertCostTypeRequest, CostTypeEntity>();
            config.CreateMap<UpdateCostTypeRequest, CostTypeEntity>();
            config.CreateMap<UpdateCostTypeRequest, CostTypeLanguageEntity>();


            config.CreateMap<CostTypeView, GetCostTypeModel>();
            #endregion

            #region CostTypeTax
            config.CreateMap<CostTypeTaxView, GetCostTypeTaxModel>();
            config.CreateMap<ListQueryResult<CostTypeTaxView>, GetCostTypeTaxResult>();
            #endregion

            #region City
            config.CreateMap<InsertCityRequest, CityEntity>();
            config.CreateMap<UpdateCityRequest, CityEntity>();
            config.CreateMap<UpdateCityRequest, CityLanguageEntity>();

            config.CreateMap<ListQueryResult<CityView>, GetCityResult>();
            config.CreateMap<CityView, GetCityModel>();
            #endregion
            #region Currency
            config.CreateMap<InsertCurrencyRequest, CurrencyEntity>();
            config.CreateMap<UpdateCurrencyRequest, CurrencyEntity>();
            config.CreateMap<InsertCurrencyRequest, CurrencyLanguageEntity>();
            config.CreateMap<UpdateCurrencyRequest, CurrencyLanguageEntity>();

            config.CreateMap<CurrencyView, GetCurrencyModel>();
            config.CreateMap<ListQueryResult<CurrencyView>, GetCurrencyResult>();
            #endregion

            #region Tax
            config.CreateMap<InsertTaxRequest, TaxEntity>();
            config.CreateMap<InsertTaxByTableNameRequest, TaxEntity>();
            config.CreateMap<UpdateTaxRequest, TaxEntity>();
            config.CreateMap<UpdateTaxRequest, TaxLanguageEntity>();

            config.CreateMap<TaxView, GetTaxModel>();
            config.CreateMap<ListQueryResult<TaxView>, GetTaxResult>();
            #endregion

            #region ContactType
            config.CreateMap<InsertContactTypeRequest, ContactTypeEntity>();
            config.CreateMap<UpdateContactTypeRequest, ContactTypeEntity>();
            config.CreateMap<UpdateContactTypeRequest, ContactTypeLanguageEntity>();

            config.CreateMap<ContactTypeView, GetContactTypeModel>();
            config.CreateMap<ListQueryResult<ContactTypeView>, GetContactTypeResult>();

            config.CreateMap<ContactTypeView, GetContactTypeByKeyModel>();
            #endregion

            #region PersonContact
            config.CreateMap<InsertPersonContactRequest, PersonContactEntity>();
            config.CreateMap<UpdatePersonContactRequest, PersonContactEntity>();

            config.CreateMap<PersonContactView, GetPersonContactModel>();
            config.CreateMap<ListQueryResult<PersonContactView>, GetPersonContactResult>();
            #endregion

            #region GLN
            config.CreateMap<InsertGLNRequest, GLNEntity>();
            config.CreateMap<UpdateGLNRequest, GLNEntity>();
            config.CreateMap<UpdateGLNRequest, GLNLanguageEntity>();

            config.CreateMap<GLNView, GetGLNModel>();
            config.CreateMap<ListQueryResult<GLNView>, GetGLNResult>();

            config.CreateMap<GLNCoView, GetGLNByCompanyModel>();
            config.CreateMap<ListQueryResult<GLNCoView>, GetGLNByCompanyResult>();

            config.CreateMap<GLNView, GetGLNByKeyModel>();
            config.CreateMap<GLNView, InsertGLNModel>();
            #endregion

            #region Logo
            config.CreateMap<LogoEntity, GetLogoModel>();
            #endregion

            #region SanaSupportInfo
            config.CreateMap<InsertSanaSupportInfoRequest, SanaSupportInfoEntity>();
            config.CreateMap<UpdateSanaSupportInfoRequest, SanaSupportInfoEntity>();

            config.CreateMap<SanaSupportInfoView, GetSanaSupportInfoModel>();
            config.CreateMap<ListQueryResult<SanaSupportInfoView>, GetSanaSupportInfoResult>();
            #endregion

            #region TeacherTest

            config.CreateMap<InsertTeacherTestRequest, TeacherTestEntity>();
            config.CreateMap<UpdateTeacherTestRequest, TeacherTestEntity>();

            config.CreateMap<TeacherTestEntity, GetAllTeacherTestsModel>();
                
            config.CreateMap<ListQueryResult<TeacherTestEntity>, GetAllTeacherTestsResult>();

            #endregion
        }
    }
}
