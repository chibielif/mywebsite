namespace My_Website.Models
{
    public class Message
    {
        public Message(int idNumber, string subjectName, string mailAddress, string text, 
            string phone, string writerName, DateTime Time)
        {
            id = idNumber;
            subject = subjectName;
            email = mailAddress;
            phoneNumber = phone;
            messageText = text;
            name = writerName;
            createTime = Time;
        }
        public int id { get; set; }
        public string subject { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string messageText { get; set; }
        public string name { get; set; }
        public DateTime createTime { get; set; }
    }
}
