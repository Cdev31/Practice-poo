
using c_.Models;

namespace c_.Utils
{
    public class LoaderData
    {
        public List<HospitalAreaModel> initAreas(){
            List<HospitalAreaModel> areas = new List<HospitalAreaModel>();

            areas.Add(new HospitalAreaModel(1, "Pediatria", "Area de pediatria"));
            areas.Add(new HospitalAreaModel(2, "Oncologia", "Area de oncologia"));
            areas.Add(new HospitalAreaModel(3, "Emergencia", "Area de emergencia"));
            return areas;
        }
    }
}