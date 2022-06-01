

//SRP — Single Responsibility Principle (Tek Sorumluluk Prensibi)

class Customer
{
    public void Login(string username, string passwd) { }
    public void Register(string username, string passwd, string email)
    {
        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail("Kaydınız alınmıştır...");
    }
}

class EmailSender
{
    public void SendEmail(string message) { }
}


