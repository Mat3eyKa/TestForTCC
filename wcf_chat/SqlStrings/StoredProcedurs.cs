namespace Wcf.SqlCommnads
{
    internal class Commands
    {
        public static string selectAllCommand = "exec SelectAllPersons";
        public static string SelectByParamsCommand(string name, string surname, string patronymic, string dateOfBirth,
            string phone, string city, string street, string house, string room)=>
            $"exec SelectSerchedPersons @Name = N'{name}', @Surname = N'{surname}', @Patronymic = N'{patronymic}', @DateOfBirth = '{dateOfBirth}', @Phone = '{phone}', @City = N'{city}', @Street = N'{street}', @House = '{house}', @Room= '{room}'";
        public static string DeletePersonCommand(int id) =>
            $"exec DeletePerson @Id = '{id}'";
        public static string UpdatePersonCommand(string id, string name, string surname, string patronymic, string dateOfBirth,
            string phone, string city, string street, string house, string room) => 
            $"exec UpdatePerson @Id = '{id}', @Name = N'{name}', @Surname = N'{surname}', @Patronymic = N'{patronymic}', @DateOfBirth = '{dateOfBirth}', @Phone = '{phone}', @City = N'{city}', @Street = N'{street}', @House = '{house}', @Room= '{room}'";
        public static string CreatePersonCommand(string name, string surname, string patronymic, string dateOfBirth,
            string phone, string city, string street, string house, string room) =>
            $"exec CreatePerson @Name = N'{name}', @Surname = N'{surname}', @Patronymic = N'{patronymic}', @DateOfBirth = '{dateOfBirth}', @Phone = '{phone}', @City = N'{city}', @Street = N'{street}', @House = '{house}', @Room= '{room}'";
    }
}