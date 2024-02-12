﻿using Intro.DataAccess.Abstracts;
using Intro.Entities;

namespace Intro.DataAccess.Concretes;

public class EfCourseDal:ICourseDal
{
    List<Course> courses;

    public EfCourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "Javascript";
        course1.Description = ".net 8";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "java";
        course2.Description = "java 17";
        course2.Price = 10;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "pyton";
        course3.Description = "3.12";
        course3.Price = 0;

        courses = new List<Course> { course1, course2, course3 };
    }
    public List<Course> GetAll()
    {
        // burada db işlemleri yapılır
        return courses;

    }
    public void Add(Course course)
    {
        courses.Add(course);
    }
}