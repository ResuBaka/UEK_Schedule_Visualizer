using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEK_VisualizeScheduleV2
{
    class CourseJSON
    {
        public string dataZajec { get; set; }
        public string godzinaOd { get; set; }
        public string godzinaDo { get; set; }
        public string przedmiot { get; set; }
        public string dydaktyk { get; set; }
        public string nazwaSali { get; set; }
        public string lokalizacja { get; set; }

        public string GetDate()
        {
            return this.dataZajec;
        }
        public string GetStart()
        {
            return this.godzinaOd;
        }
        public string GetEnd()
        {
            return this.godzinaDo;
        }
        public string GetSubject()
        {
            return this.przedmiot;
        }
        public string GetTeacher()
        {
            return this.dydaktyk;
        }
        public string GetRoom()
        {
            return this.nazwaSali;
        }
        public string GetBuilding()
        {
            return this.lokalizacja;
        }
    }
}
