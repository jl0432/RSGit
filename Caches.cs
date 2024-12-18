namespace RandomSelection{
    public static class Caches{
        private static Database _database;
        public static Database Database{
            get{
                _database = _database ?? (_database = Operation.LoadFoDb<Database>());
                return _database ?? (_database = new Database());
            }
            set=>_database = value;
        }
    }
}