using CodeFirstData.DBInteractions;
using CodeFirstEntities;

namespace CodeFirstData.EntityRepositories
{
    public class StudentRepository : EntityRepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(IDBFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }

}