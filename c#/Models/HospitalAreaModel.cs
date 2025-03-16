
namespace c_.Models;

public class HospitalAreaModel {
    public int _id { get; set; }
    public string _areaName { get; set; }
    public string _description { get; set; }

    public HospitalAreaModel( int id, string area, string description ){
        _id = id;
        _areaName = area;
        _description = description;
    }
}