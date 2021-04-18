public class Person{

    public Person(){}
    public int stuID;
    public string na;
    public int birth;
    public float Score;
    public int Age(int currentYear){
        return currentYear - birth;
    }
    public Person(int ID, string Na, int Birth, float TScore){
        stuID = ID;
        na = Na;
        birth = Birth;
        Score = TScore;
    }
    public override string ToString()
    {
        return "Student " + stuID + ", " + na + ", last test score " + Score;
    }
}