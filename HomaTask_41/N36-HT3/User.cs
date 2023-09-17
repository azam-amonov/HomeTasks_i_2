namespace HomaTask_41.N36_HT3;

// - ExamScore modelidan foydalaning ( id, userId, score )
// - User modelidan foydalaning ( id, firstname, lastname ) 
// - 2 alasi uchun o'zining crud entity servisini yarating
// - ExamAnalytics servisidan foydalaning, bu service tepadagi 2 ala service uchun composition service bo'ladi
// - unda GetScores methodi bo'lsin, bu method ( fullName, score ) tipidagi IEnumerable ma'lumot qaytarsin, bunda har bitta user va uning examdagi balli qaytsin


public class User
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public User(long id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
}