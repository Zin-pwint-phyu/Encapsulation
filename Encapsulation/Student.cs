public class Student
{
    private string stuname;
    private string rollNo;
    private string email;
    private int age;
    
    public void SetStudentInfo(string rNum,int stuAge,string stuEmail)
    {
        rollNo = rNum;
        age = stuAge;
        email = stuEmail;
        
    }
    public void SetRollNo(string rno)
    {
        if (string.IsNullOrEmpty(rno))
        {
            throw new ArgumentNullException("require rollNo");
        }
          rollNo=rno;
    }
    public void SetStuName(string name)
    {
        if (string.IsNullOrEmpty(name)) {
        throw new ArgumentNullException("name is required ");
        }
         stuname = name;
    }
    public void SetAge(int stuAge)
    {
        if (age < 0 || age > 100) {
            throw new ArgumentOutOfRangeException("Invalid Age");
        }
        age = stuAge;
    }
    public void SetEmail(string stuEmail)
    {
        if (string.IsNullOrEmpty(stuEmail) || !stuEmail.Contains("@")) {
            throw new ArgumentException("require Email Or Invalid Email");
        }
        email = stuEmail;
    }
    public override string ToString()
    {
        return stuname+" "+rollNo+ " "+age+" "+email;
    }
    
}