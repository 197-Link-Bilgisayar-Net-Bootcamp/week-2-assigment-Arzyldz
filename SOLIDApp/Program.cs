

//SRP — Single Responsibility Principle (Tek Sorumluluk Prensibi)
class Customer
{
    public void Login(string username, string passwd) { }
    public void Register(string username, string passwd, string email)
    {
        this.SendEmail("Kaydınız alınmıştır...");
    }
    void SendEmail(string message) {
        Console.WriteLine(message);
    }
}

