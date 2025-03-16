
using c_.Models;
using c_.Utils;

namespace c_.Services;

public class DoctorService {
    private List<DoctorModel> _doctors = new List<DoctorModel>(); 

    public DoctorService(){
        List<HospitalAreaModel> loadArea = new LoaderData().initAreas();

        DoctorModel doctor = new DoctorModel{
            _id = 1,
            _name = "Juan",
            _surname = "Chavez",
            _dateOfBirth = new DateTime(),
            _dui= "12324567-0",
            _license = "989as2q#",
            _workArea = loadArea[0],
            _specialization = "Pediatra"
        };
        DoctorModel doctor2 = new DoctorModel{
            _id = 2,
            _name = "Julio",
            _surname = "Chavez",
            _dateOfBirth = new DateTime(),
            _dui= "12324567-3",
            _license = "989ws2q#",
            _workArea = loadArea[0],
            _specialization = "Pediatra"
        };
        DoctorModel doctor3 = new DoctorModel{
            _id = 3,
            _name = "Carlos",
            _surname = "Chavez",
            _dateOfBirth = new DateTime(),
            _dui= "12324967-2",
            _license = "989ks2q#",
            _workArea = loadArea[0],
            _specialization = "Pediatra"
        };

        _doctors.Add(doctor);
        _doctors.Add(doctor2);
        _doctors.Add(doctor3);
    }   

    public List<DoctorModel> getAllDoctors(){
        return _doctors;
    }
}
