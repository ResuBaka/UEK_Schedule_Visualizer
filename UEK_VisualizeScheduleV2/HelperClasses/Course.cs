using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEK_VisualizeScheduleV2
{
    class Course : IComparable
    {
        //Date;Start;End;Eng Subject;Location;Teacher;Eng Class Type
        private DateTime start;
        private DateTime end;
        private string subject;
        private string teacher;
        private string location;
        private string coursetype;

        #region Properties

        public DateTime Date
        {
            get
            {
                return new DateTime(this.start.Year, this.start.Month, this.start.Day);
            }
        }

        public DateTime Start
        {
            get
            {
                return this.start;
            }
        }

        public DateTime End
        {
            get
            {
                return this.end;
            }
        }

        public string Subject
        {
            get
            {
                return this.subject;
            }
        }

        public string Teacher
        {
            get
            {
                return this.teacher;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
        }

        public string CourseType
        {
            get
            {
                return this.coursetype;
            }
        }

        #endregion

        public Course(string dataLoad)
        {
            if(dataLoad == null || dataLoad == "")
            {
                throw new ArgumentNullException($"'dataLoad' has to contain valid data! ({dataLoad})");
            }

            string[] dataComponets = dataLoad.Split(new char[] { ';' });
            if(dataComponets.Length != 7)
            {
                throw new ArgumentException($"The data provided is not complete or not formatted correctly! ({dataLoad})");
            }

            try
            {
                this.start = DateTime.Parse($"{dataComponets[0].Trim()} {dataComponets[1].Trim()}");
                this.end = DateTime.Parse($"{dataComponets[0].Trim()} {dataComponets[2].Trim()}");
                this.subject = dataComponets[3].Trim();
                this.location = dataComponets[4].Trim();
                this.teacher = dataComponets[5].Trim();
                this.coursetype = dataComponets[6].Trim();
            }catch(Exception e)
            {
                throw new ArgumentException($"The data provided is invalid or not formatted correctly! ({dataLoad})", e);
            }
        }

        public int CompareTo(object obj)
        {
            if(obj.GetType() == this.GetType())
            {
                Course c = (Course)obj;
                if(c.Date < this.Date)
                {
                    return 1;
                }else if(c.Date > this.Date)
                {
                    return -1;
                }
                else
                {
                    if(c.Start < this.Start)
                    {
                        return 1;
                    }else if(c.Start > this.Start)
                    {
                        return -1;
                    }
                    else
                    {
                        if(c.End < this.End)
                        {
                            return 1;
                        }else if(c.End > this.End)
                        {
                            return -1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            return 1;
        }

        public bool ValueEqual(Course c)
        {
            return
                this != c &&
                this.Start == c.Start &&
                this.End == c.End &&
                this.Subject == c.Subject &&
                this.Location == c.Location &&
                this.Teacher == c.Teacher &&
                this.CourseType == c.CourseType;
        }

    }
}
