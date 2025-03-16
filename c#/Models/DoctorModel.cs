
namespace c_.Models;

public class DoctorModel: PersonModel {
    public string _license { get; set;}
    public string _specialization { get; set;}
    public HospitalAreaModel _workArea { get; set;}

}