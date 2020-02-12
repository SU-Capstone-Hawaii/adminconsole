using adminconsole.Models;


namespace adminconsole.Backend
{
    public class DatabaseHelper
    {

        private MaphawksContext _context;

        public DatabaseHelper(MaphawksContext c)
        {
            _context = c;
        }
    }
}