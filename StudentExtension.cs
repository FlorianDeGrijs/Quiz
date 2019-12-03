namespace Quiz
{

    delegate bool FindStudent(Student std);

    class StudentExtension
    {
        public static Student[] where(Student[] studentArray, FindStudent del)
        {
            int i = 0;
            Student[] result = new Student[studentArray.Length];
            foreach (Student std in studentArray)
            {
                if (del(std))
                {
                    result[i] = std;
                    i++;
                }
            }
            return result;
        }
    }
}
