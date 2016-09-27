using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTwoCombos
{
    class MockRepository
    {
        private List<Framleidandi> _framl;
        private List<Tegund> _teg;

        public MockRepository()
        {
            _framl = new List<Framleidandi>();
            _teg = new List<Tegund>();
            CreateMockDb();
        }

        public List<Framleidandi> GetFramleidendur()
        {
            return _framl;
        }

        public List<Tegund> GetTegundirByFramlId(int id)
        {
            List<Tegund> selTeg = new List<Tegund>();
            foreach(Tegund t in _teg)
            {
                if (t.FramleidandiId == id)
                {
                    selTeg.Add(t);
                }
            }

            return selTeg;
        }

        private void CreateMockDb()
        {
            _framl.Add(new Framleidandi() { Id = 1, Nafn = "Toyota" });
            _framl.Add(new Framleidandi() { Id = 2, Nafn = "Honda" });
            _framl.Add(new Framleidandi() { Id = 3, Nafn = "Scania" });
            _framl.Add(new Framleidandi() { Id = 4, Nafn = "Suzuki" });

            _teg.Add(new Tegund() { Id = 1, Nafn = "RAV4", FramleidandiId = 1 });
            _teg.Add(new Tegund() { Id = 2, Nafn = "Auris", FramleidandiId = 1 });
            _teg.Add(new Tegund() { Id = 3, Nafn = "Civic", FramleidandiId = 2 });
            _teg.Add(new Tegund() { Id = 4, Nafn = "Vitara", FramleidandiId = 4 });
            _teg.Add(new Tegund() { Id = 5, Nafn = "Jimmy", FramleidandiId = 4 });
            _teg.Add(new Tegund() { Id = 6, Nafn = "Accord", FramleidandiId = 2 });
            _teg.Add(new Tegund() { Id = 7, Nafn = "Yaris", FramleidandiId = 1 });
            _teg.Add(new Tegund() { Id = 8, Nafn = "Land Cruiser", FramleidandiId = 1 });
        }

    }
}
