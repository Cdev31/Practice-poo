
using c_.Services;

public class Program {
    public static void Main(string[] args){
        DoctorService doctorService = new DoctorService();

        foreach (var item in doctorService.getAllDoctors())
        {
            Console.WriteLine("Nombre:" +  item._name);
            Console.WriteLine("Carnet:" +  item._license);
            Console.WriteLine("Especializacion:" +  item._specialization);
        }
    }
}