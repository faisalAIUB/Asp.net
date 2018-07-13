using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRepository
{
     public class RentRepository
    {
        ProjectDbContext context = new ProjectDbContext();
        public int Insert(RentAd rent)
        {
            context.RentAds.Add(rent);
            return context.SaveChanges();

        }
        public int Edit(RentAd rent)
        {
            RentAd re = context.RentAds.SingleOrDefault(r => r.RentId == rent.RentId);
            re.FlatNo = rent.FlatNo;
            re.HouseNo = rent.HouseNo;
            re.RoadNo = rent.RoadNo;
            re.Area = rent.Area;
            re.Description = rent.Description;
            re.RentAmount = rent.RentAmount;
            return context.SaveChanges();

        }

        public List<RentAd> GetById(int Id)
        {
            return context.RentAds.Where(r => r.UserId == Id).ToList();
        }
        public List<RentAd> GetAll()
        {
            return context.RentAds.ToList();
        }
        public RentAd Get(int id)
        {
            return context.RentAds.SingleOrDefault(r => r.RentId == id);
        }
        public List<District> GetDistrict()
        {

            return context.Districts.ToList();
        }
        public List<Thana> GetThana()
        {

            return context.Thanas.ToList();
        }
        public int Delete(int id)
        {
           RentAd RentToDelete = context.RentAds.SingleOrDefault(e => e.RentId == id);
            context.RentAds.Remove(RentToDelete);
            return context.SaveChanges();
        }
        public string GetThana(int id)
        {
            RentAd rent = context.RentAds.SingleOrDefault(r => r.RentId == id);
            Thana th = context.Thanas.SingleOrDefault(t => t.ThanaId == rent.ThanaId);
            return th.ThanaName;
        }
        public string GetDistrict(int id)
        {
            RentAd rent = context.RentAds.SingleOrDefault(r => r.RentId == id);
            District di = context.Districts.SingleOrDefault(d => d.DistrictId == rent.DistrictId);
            return di.DistrictName;
        }


    }
}
