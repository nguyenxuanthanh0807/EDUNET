using School.Areas.Subject.Models;
using School.Models;
using School.Repositories;

namespace School.Services
{
    public class SubjectServiceImp : ISubjectRepository
    {
        private DatabaseContext _databaseContext;
        public SubjectServiceImp(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public void AddSubject(Subject subject)
        {
            _databaseContext.Subjects.Add(subject);
            _databaseContext.SaveChanges();
        }

        public void DeleteSubject(int id)
        {
            var subject = _databaseContext.Subjects.Find(id);
            if (subject != null)
            {
                _databaseContext.Subjects.Remove(subject);
                _databaseContext.SaveChanges();
            }
        }

        public Subject GetSubjectById(int id)
        {
            var subject = _databaseContext.Subjects.Find(id);
            if (subject != null)
            {
                return subject;
            }
            return null;
        }

        public List<Subject> GetSubjects()
        {
           var subject = _databaseContext.Subjects.ToList();
            return subject;
        }

        public void UpdateSubject(Subject subject)
        {
           var sub = _databaseContext.Subjects.Find(subject.SubjectId);
            if (sub != null)
            {
                sub.NameSubject = subject.NameSubject;
                sub.LearnTime = subject.LearnTime;
                sub.PhotoSubject = subject.PhotoSubject;
                _databaseContext.SaveChanges();
            }
        }
    }
}
