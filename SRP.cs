namespace SRP
{

class CustomerA {
    public void Login(string username, string passwd) {}
    public void Register(string username, string passwd, string email) {
        // ...
        this.SendEmail("Kaydınız alınmıştır...");
        // ...
    }
    void SendEmail(string message) {}
}

// CustomerA is not following SRP. Let's refact it and make new classes ->
// CustomerB and EmailSender
class CustomerB {
    public void Login(string username, string passwd) {}
    public void Register(string username, string passwd, string email) {
        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail("Kaydınız alınmıştır...");
    }
}

class EmailSender {
    public void SendEmail(string message) {}
}

}
