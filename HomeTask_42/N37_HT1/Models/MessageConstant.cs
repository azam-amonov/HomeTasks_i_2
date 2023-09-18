namespace HomeTask_42.N37_HT1.Models;

public class MessageConstant
{
    public static class Message
    {
        public static readonly string RegisteredBody = "Hi {{FullName}}";
        public static readonly string RegisteredSubject = "Welcome to our system";

        public static readonly string DeletedBody = "Dear {{FullName}}";

        public static readonly string DeletedSubject =
                        "We are sorry to inform you that your account has been deleted from our system. " +
                        "This action was taken because [reason for account deletion]";
    }
}