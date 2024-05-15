using CourseWorkLibrary.Model;
using Microsoft.EntityFrameworkCore;

namespace CourseWorkLibrary.Repo
{
    public class WorkRepository
    {
        private readonly WorkContext _context;

        public WorkRepository(WorkContext context)
        {
            _context = context;
        }

        public void AddWork(Work work)
        {
            _context.Works.Add(work);
            _context.SaveChanges();
        }
        public void EditWork(Work work)
        {
            var existingWork = _context.Works.Find(work.Id);
            if (existingWork != null)
            {
                _context.Entry(existingWork).CurrentValues.SetValues(work);
            }
            else
            {
                _context.Works.Attach(work);
                _context.Entry(work).State = EntityState.Modified;
            }
            _context.SaveChanges();
        }
        public void DeleteWork(int id)
        {
            _context.Works.Remove(_context.Works.Find(id));
            _context.SaveChanges();
        }
        public Work GetWork(int id)
        {
            return _context.Works.Find(id);
        }
        public List<Work> GetAllWorks()
        {
            return _context.Works.ToList();
        }
        public List<int> GetUniqueYearsOfDefense()
        {
            return _context.Works
                .Select(w => w.YearOfDefense)
                .Distinct()
                .OrderBy(y => y)
                .ToList();
        }
        public List<String> GetUniqueSurname()
        {
            return _context.Works
                .Select(w => w.StudentName)
                .Distinct()
                .OrderBy(s => s)
                .ToList();
        }
        public List<String> GetUniqueSupervisor()
        {
            return _context.Works
                .Select(w => w.SupervisorName)
                .Distinct()
                .OrderBy(s => s)
                .ToList();
        }
        public List<Work> GetWorksByYear(int year)
        {
            return _context.Works.Where(w => w.YearOfDefense == year).ToList();
        }
        public List<Work> GetWorksByStudentLastName(string lastName)
        {
            return _context.Works.Where(w => w.StudentName == lastName).ToList();
        }
        public List<Work> GetWorksBySupervisor(string supervisorName)
        {
            return _context.Works.Where(w => w.SupervisorName == supervisorName).ToList();
        }
    }
}
