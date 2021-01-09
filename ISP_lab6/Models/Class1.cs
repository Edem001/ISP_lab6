using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DB_lab4;

namespace ISP_lab6.Models
{
    public class mDbInitializer: DropCreateDatabaseAlways<mContext>
    {
        protected override void Seed(mContext context)
        {
            Institutes ikni = new Institutes
            {
                Name = "IKNI",
                Location = "5th building"
            };

            Departments SAP = new Departments
            {
                Name = "SAP",
                Institute = ikni
            };

            Groups kn305 = new Groups
            {
                Name = "KN-305",
                Number = 305
            };

            Lecturers lect1 = new Lecturers
            {
                Name = "test",
                Surname = "testSurname",
                FathersName = "testFathersName",
                Department = SAP
            };
            Lecturers lect2 = new Lecturers
            {
                Name = "test2",
                Surname = "testSurname2",
                FathersName = "testFathersName",
                Department = SAP
            };


            context.Institute.Add(ikni);
            context.Institute.Add(new Institutes
            {
                Name = "IKTA",
                Location = "5th building"
            });

            context.Department.Add(SAP);
            context.Department.Add(new Departments
            {
                Name = "PZ",
                Institute = ikni
            });

            context.Subject.Add(new Subjects
            {
                Name = "TEST1",
                Credits = 1
            });
            context.Subject.Add(new Subjects
            {
                Name = "TEST2",
                Credits = 2
            });

            context.Student.Add(new Students
            {
                Name = "Timofiy",
                Surname = "PIPIDASTR",
                Age = 19,
                Group = kn305
            });
            context.Student.Add(new Students
            {
                Name = "Timofiy2",
                Surname = "PIPIDASTR",
                Age = 19,
                Group = kn305
            });

            context.Group.Add(kn305);
            context.Group.Add(new Groups
            {
                Name = "KN-306",
                Number = 306
            });

            context.mUnion.Add(new Union
            {
                Group = kn305,
                Lecturer = lect1,
                Subject = new Subjects
                {
                    Name = "Algorhytms",
                    Credits = 3
                }

            });
            context.mUnion.Add(new Union
            {
                Group = kn305,
                Lecturer = lect2,
                Subject = new Subjects
                {
                    Name = "Programming",
                    Credits = 3
                }

            });

            context.Lecturer.Add(lect1);
            context.Lecturer.Add(lect2);
            base.Seed(context);
        }
    }
}