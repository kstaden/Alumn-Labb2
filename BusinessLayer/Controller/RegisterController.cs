using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessEntities;
using DataLayer;
using DataLayer.Interfaces;
using DataLayer.Repositories;

namespace BusinessLayer.Controller
{
    public class RegisterController
    {
        private IProgramRepository programRepo = new ProgramRepository();
        private IClassYearRepository classYearRepo = new ClassYearRepository();
        private IOccupationRepository occupationRepo = new OccupationRepository();
        private IUserRepository userRepo = new UserRepository();
        private IAlumniRepository alumniRepo = new AlumniRepository();
        private IAlumniAddressRepository alumniAddressRepo = new AlumniAddressRepository();

        public List<ProgramModel> GetPrograms()
        {
            List<ProgramModel> programs = new List<ProgramModel>();

            foreach (ProgramSet program in programRepo.GetAll())
                programs.Add(new ProgramModel(program));

            return programs;
        }
        public List<BusinessEntities.ClassYearModel> GetClasses()
        {
            List<BusinessEntities.ClassYearModel> classYears = new List<BusinessEntities.ClassYearModel>();

            foreach (ClassYearSet classYear in classYearRepo.GetAll())
                classYears.Add(new BusinessEntities.ClassYearModel(classYear));

            return classYears;
        }
        public List<BusinessEntities.AlumniModel> GetAlumnis()
        {
            List<BusinessEntities.AlumniModel> alumnis = new List<BusinessEntities.AlumniModel>();

            foreach (UserSet_Alumni alumni in alumniRepo.GetAll())
                alumnis.Add(new BusinessEntities.AlumniModel(alumni));

            return alumnis;
        }

        public List<BusinessEntities.OccupationModel> GetOccupations()
        {
            List<BusinessEntities.OccupationModel> occupations = new List<BusinessEntities.OccupationModel>();

            foreach (OccupationSet occupation in occupationRepo.GetAll())
                occupations.Add(new BusinessEntities.OccupationModel(occupation));

            return occupations;
        }
        public void CreateAlumni(string[] alumniData)
        {
            UserSet _alumni = new UserSet
            {
                AdminRights = false,
                FirstName = alumniData[1],
                LastName = alumniData[2],
                SocialSecurityNumber = alumniData[0],
                Email = alumniData[3],
                UserId = alumniData[9],
                Password = alumniData[10],
            };

            userRepo.Create(_alumni);
        }
        public bool ValidUserId(string userId)
        {
            return !alumniRepo.CheckUserId(userId);
        }
    }
}
