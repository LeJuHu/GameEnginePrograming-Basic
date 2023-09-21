using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Student
{
    public string First { get; set; }
    public string Last { get; set; }
    public int ID { get; set; }
    public List<int> Scores;
}

public class TestLINQClass2 : MonoBehaviour
{
    // Create a data source by using a collection initializer.
    static List<Student> students = new List<Student>
    {
        new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
        new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
        new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
        new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
        new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
        new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
        new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
        new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
        new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
        new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
        new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
        new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}}
    };

    // Start is called before the first frame update
    void Start()
    {
        TestLINQ();
        TestLINQ02();
        TestLINQ03();
        TestLINQ04();
        TestLINQ05();
        TestLINQ06();
        TestLINQ07();
        TestLINQ08();
        TestLINQ09();
        TestLINQ10();
    }
    
    void TestLINQ()
    {
        // Create the query.
        // The first line could also be written as "var studentQuery ="
        IEnumerable<Student> studentQuery =
            from student in students
            where student.Scores[0] > 90
            select student;

        foreach (Student student in studentQuery)
        {
            Debug.Log($"{student.Last}, {student.First}");
        }
    }

    /// <summary>
    /// 다른 필터 조건을 추가
    /// </summary>
    void TestLINQ02()
    {
        // Create the query.
        // The first line could also be written as "var studentQuery ="
        IEnumerable<Student> studentQuery =
            from student in students
            where student.Scores[0] > 90 && student.Scores[3] < 80
            select student;

        foreach (Student student in studentQuery)
        {
            Debug.Log($"{student.Last}, {student.First}");
        }
    }

    /// <summary>
    /// 결과를 정렬
    /// </summary>
    void TestLINQ03()
    {
        // Create the query.
        // The first line could also be written as "var studentQuery ="
        IEnumerable<Student> studentQuery =
            from student in students
            where student.Scores[0] > 90 && student.Scores[3] < 80
            orderby student.Last ascending
            //orderby student.Scores[0] descending
            select student;

        foreach (Student student in studentQuery)
        {            
            Debug.Log($"{student.Last}, {student.First} {student.Scores[0]}");
        }
    }

    /// <summary>
    /// 결과를 그룹화
    /// </summary>
    void TestLINQ04()
    {
        // studentQuery2 is an IEnumerable<IGrouping<char, Student>>
        var studentQuery2 =
            from student in students
            group student by student.Last[0];

        foreach (var studentGroup in studentQuery2)
        {
            Debug.Log(studentGroup.Key);
            foreach (Student student in studentGroup)
            {
                Debug.Log($"   {student.Last}, {student.First}");
            }
        }
    }

    /// <summary>
    /// 변수를 암시적으로 형식화하려면
    /// </summary>
    void TestLINQ05()
    {
        var studentQuery3 =
            from student in students
            group student by student.Last[0];

        foreach (var groupOfStudents in studentQuery3)
        {
            Debug.Log(groupOfStudents.Key);
            foreach (var student in groupOfStudents)
            {
                Debug.Log($"   {student.Last}, {student.First}");
            }
        }
    }

    /// <summary>
    /// 키 값을 기준으로 그룹을 정렬하려면
    /// </summary>
    void TestLINQ06()
    {
        var studentQuery4 =
            from student in students
            group student by student.Last[0] into studentGroup
            orderby studentGroup.Key
            select studentGroup;

        foreach (var groupOfStudents in studentQuery4)
        {
            Debug.Log(groupOfStudents.Key);
            foreach (var student in groupOfStudents)
            {
                Debug.Log($"   {student.Last}, {student.First}");
            }
        }
    }

    /// <summary>
    /// let을 사용하여 식별자를 소개하려면
    /// </summary>
    void TestLINQ07()
    {
        var studentQuery5 =
            from student in students
            let totalScore = student.Scores[0] + student.Scores[1] +
                student.Scores[2] + student.Scores[3]
            where totalScore / 4 < student.Scores[0]
            select student.Last + " " + student.First;

        foreach (string s in studentQuery5)
        {
            Debug.Log(s);
        }
    }

    /// <summary>
    /// 쿼리 식에서 메서드 구문을 사용하려면
    /// </summary>
    double averageScore;
    void TestLINQ08()
    {
        var studentQuery6 =
            from student in students
            let totalScore = student.Scores[0] + student.Scores[1] +
                student.Scores[2] + student.Scores[3]
            select totalScore;

        averageScore = studentQuery6.Average();
        Debug.Log($"Class average score = {averageScore}");
    }

    /// <summary>
    /// select 절에서 변환 또는 프로젝션하려면
    /// </summary>
    void TestLINQ09()
    {
        IEnumerable<string> studentQuery7 =
            from student in students
            where student.Last == "Garcia"
            select student.First;

        Debug.Log("The Garcias in the class are:");
        foreach (string s in studentQuery7)
        {
            Debug.Log(s);
        }
    }

    void TestLINQ10()
    {
        var studentQuery8 =
            from student in students
            let x = student.Scores[0] + student.Scores[1] +
                student.Scores[2] + student.Scores[3]
            where x > averageScore
            select new { id = student.ID, score = x };

        foreach (var item in studentQuery8)
        {
            Debug.Log($"Student ID: {item.id}, Score: {item.score}");
        }
    }
}
