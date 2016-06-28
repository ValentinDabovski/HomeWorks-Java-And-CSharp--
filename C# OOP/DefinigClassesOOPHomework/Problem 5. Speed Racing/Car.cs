
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using Problem_5.Speed_Racing;

public class Car
{
    private string model;
    private decimal fuelAmount;
    private decimal fuelConsumedForKm;
    private decimal distanceTraveled;

    public Car(string model, decimal fuelAmount, decimal fuelConsumedForkm)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumedForKm = fuelConsumedForkm;
    }

    public string Model => model;
    public decimal FuelAmount => fuelAmount;
    public decimal FuelConsumedForKm => fuelConsumedForKm;
    public decimal DistanceTraveled => distanceTraveled;


    
    public void Drive(decimal kilometers)
    {
        if (FuelConsumedForKm * kilometers > fuelAmount)
        {
            throw new NotEnoughFuelException("Insufficient fuel for the drive");
        }

        distanceTraveled += kilometers;
        fuelAmount -= fuelConsumedForKm*kilometers;
    }


}




