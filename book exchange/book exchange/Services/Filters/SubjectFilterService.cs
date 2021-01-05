using System;
using System.Collections.Generic;
using System.Text;
using book_exchange.Models;

namespace book_exchange.Services.Filters
{
    public class SubjectFilterService
    {
        public List<Subject> GetAllSubjects()
        {
            List<Subject> subjects = new List<Subject>
            {
                new Subject
                {
                    Name = "Computer Science"
                },
                new Subject
                {
                    Name = "Mathematics"
                },
                new Subject
                {
                    Name = "Electrical Engineering"
                },
                new Subject
                {
                    Name = "Computer Engineering"
                },
                new Subject
                {
                    Name = "Economics"
                },
                new Subject
                {
                    Name = "Chinese"
                },
                new Subject
                {
                    Name = "Environmental Science"
                },
                new Subject
                {
                    Name = "Biology"
                },
            };
             

            return subjects;
        }
    }
}
