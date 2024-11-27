namespace My_Website.Infrastructure
{
    public class MessageRepository
    {
        private readonly Database _context;

        public MessageRepository(Database context)
        {
            _context = context;
        }
    }
}
