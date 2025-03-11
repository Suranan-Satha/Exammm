using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
#README

## ข้อมูลผู้พัฒนา
**ชื่อ:** สุรนันท์ สาทา  
**รหัสนักศึกษา:** 673450204-9  

## Class Diagram

```mermaid
typeDiagram
    classDiagram
    class Person {
        +string Name
        +string Major
        +Person(string name, string major)
    }

    class Advisor {
        +List~Student~ Students
        +Advisor(string name, string major)
        +void AddStudent(Student student)
    }

    class Student {
        +string ID
        +double Grade
        +Advisor Advisor
        +Student(string id, string name, string major, double grade, Advisor advisor)
    }

    class Form1 {
        -List~Student~ students
        -List~Advisor~ advisors
        +Form1()
        +void LoadAdvisors()
        +void btn_addStd_Click()
        +void btn_showstd_Click()
        +void UpdateStudentList()
        +void lst_Students_SelectedIndexChanged()
    }

    class Program {
        +static void Main()
    }

    Person <|-- Advisor
    Person <|-- Student
    Advisor "1" o-- "*" Student : advises
    Form1 --> "*" Student
    Form1 --> "*" Advisor
```

## หลักการเขียนโปรแกรมเชิงวัตถุ (OOP) ที่ใช้

1. **Encapsulation (การห่อหุ้มข้อมูล)**  
   - ใช้ **Properties** (`Name`, `Major`, `ID`, `Grade`) ที่กำหนด **getter/setter** เพื่อป้องกันการเข้าถึงข้อมูลโดยตรง
   - ข้อมูลของ `Student` และ `Advisor` ถูกจัดการผ่าน **Constructor** และ **Methods**

2. **Inheritance (การสืบทอดคลาส)**  
   - `Student` และ `Advisor` สืบทอดคุณสมบัติจาก `Person`
   - ลดความซ้ำซ้อนของโค้ดโดยให้คลาสลูกใช้งานคุณสมบัติของคลาสแม่

3. **Polymorphism (พหุนาม)**  
   - คลาสลูก (`Student`, `Advisor`) สามารถขยายคุณสมบัติจากคลาส `Person`

4. **Association (ความสัมพันธ์ระหว่างคลาส)**  
   - `Advisor` มีความสัมพันธ์แบบ **one-to-many** กับ `Student` (ที่ปรึกษาหนึ่งคนมีลูกศิษย์หลายคน)
   - `Student` มีความสัมพันธ์แบบ **one-to-one** กับ `Advisor` (นักศึกษาแต่ละคนมีอาจารย์ที่ปรึกษาเพียงคนเดียว)

โปรแกรมนี้ถูกออกแบบให้เป็นไปตามหลักการเขียนโปรแกรมเชิงวัตถุอย่างครบถ้วน ทำให้โค้ดมีโครงสร้างที่ชัดเจนและสามารถขยายเพิ่มเติมได้ง่าย 🎯

}
