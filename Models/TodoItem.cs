using SQLite;

namespace TodoSQLite.Models
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public bool Done { get; set; }
    }
}