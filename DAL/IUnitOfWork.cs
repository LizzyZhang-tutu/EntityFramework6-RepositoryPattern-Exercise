using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.DAL
{
    public interface IUnitOfWork: IDisposable
    {
        IStudentRepository Students { get; }
        ICourseRepository Courses { get; }

        int Complete();
    }
}
