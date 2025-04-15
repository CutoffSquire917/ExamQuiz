using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamQuiz;
using Newtonsoft.Json;
using GlobalsData;
using System.Diagnostics;

public class Question
{
    public string question { get; set; }
    public Dictionary<string, bool> answers { get; private set; }

    public Question(string _question)
    {
        if (string.IsNullOrWhiteSpace(_question))
        {
            throw new ArgumentNullException("Question can`t be null");
        }
        question = _question;
        answers = new Dictionary<string, bool>();
        answers.Add("Option 1", false);
        answers.Add("Option 2", false);
    }
    [JsonConstructor]
    public Question(string question, Dictionary<string, bool> answers = null)
    {
        this.question = question ?? throw new ArgumentNullException("Question can`t be null");
        this.answers = answers ?? new Dictionary<string, bool>();
    }
    public void AddAnswer(string answer, bool value = false)
    {
        if (string.IsNullOrWhiteSpace(answer))
        {
            throw new ArgumentNullException("Answer can`t be null");
        }
        if (answers.Count >= 6)
        {
            return;
        }
        answers.Add(answer, value);
    }
    public void RemoveAnswer(int index)
    {
        if (index < 0 || index >= answers.Count)
        {
            throw new IndexOutOfRangeException("Index out of the range");
        }
        if (answers.Count <= 2)
        {
            return;
        }
        answers.Remove(answers.ElementAt(index).Key);
    }
    public void SetTrueAnswer(int index)
    {
        if (index < 0 || index >= answers.Count)
        {
            throw new IndexOutOfRangeException("Index out of the range");
        }
        answers[answers.ElementAt(index).Key] = true;
    }
    public void RemoveTrueAnswer(int index)
    {
        if (index < 0 || index >= answers.Count)
        {
            throw new IndexOutOfRangeException("Index out of the range");
        }
        answers[answers.ElementAt(index).Key] = false;
    }

    public override string ToString()
    {
        return $"{question}\n{string.Join("\n", answers.Select(a => $"{a.Key} - {a.Value}"))}";
    }
}
public class Quiz
{
    public string Name { get; set; }
    public string Author { get; set; }
    public string Image { get; set; }
    public List<Question> Questions { get; private set; }
    public List<(User, double)> TopHistory { get; private set; }

    public Quiz(string name, string author, string image = "default_image.png")
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException("Name can`t be null");
        }
        if (string.IsNullOrWhiteSpace(author))
        {
            throw new ArgumentNullException("Author can`t be null");
        }
        if (!(File.Exists(image))) { image = "default_image.png"; }
        Name = name;
        Author = author;
        Image = image;
        Questions = new List<Question>();
        TopHistory = new List<(User, double)>();
        Questions.Add(new Question("First question"));
    }
    [JsonConstructor]
    public Quiz(string name, string author, List<Question> questions, List<(User, double)> topHistory)
    {
        this.Name = name ?? throw new ArgumentNullException("Name can`t be null");
        this.Author = author ?? throw new ArgumentNullException("Author can`t be null");
        this.Questions = questions ?? new List<Question>();
        this.TopHistory = topHistory ?? new List<(User, double)>();
    }
    public void AddQuestion(Question question)
    {
        if (question == null)
        {
            throw new ArgumentNullException("Question is damaged");
        }
        if (Questions.Count >= 30)
        {
            return;
        }
        Questions.Add(question);
    }
    public void RemoveQuestion(int index)
    {
        if (index < 0 || index >= Questions.Count)
        {
            throw new IndexOutOfRangeException("Index out of the range");
        }
        if (Questions.Count <= 1)
        {
            return;
        }
        Questions.RemoveAt(index);
    }
    public void AddToTop(User user, double results)
    {
        if (TopHistory.Count == 0)
        {
            TopHistory.Add((user, results));
            return;
        }
        for (int i = 0; i < TopHistory.Count; i++)
        {
            if (results > TopHistory[i].Item2)
            {
                TopHistory.Insert(i, (user, results));
                if (TopHistory.Count > 10)
                {
                    TopHistory.RemoveAt(TopHistory.Count - 1);
                }
            }
        }
    }
}

public class User
{
    public string Login { get; private set; }
    public string Password { get; private set; } = string.Empty;
    public DateTime BithdayDate { get; set; }
    public List<(string, double, DateTime)> UserHistory { get; private set; }

    public User(string login, string password, DateTime bithdayDate)
    {
        if (string.IsNullOrWhiteSpace(login)) { throw new ArgumentNullException("Login can`t be null"); }
        Login = login;
        SetPassword(password);
        BithdayDate = bithdayDate;
        UserHistory = new List<(string, double, DateTime)>();
    }
    [JsonConstructor]
    public User(string login, string password, DateTime bithdayDate, List<(string, double, DateTime)> userHistory)
    {
        this.Login = login ?? throw new ArgumentNullException("Login can`t be null");
        this.Password = password ?? throw new ArgumentNullException("Password can`t be null");
        this.BithdayDate = bithdayDate;
        this.UserHistory = userHistory ?? new List<(string, double, DateTime)>();
    }
    public void SetPassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password)) { throw new ArgumentNullException("Password can`t be null"); }
        if (password.Length < 8) { throw new ArgumentException("Password cannot be less than 8 characters"); }
        if (!(password.Any(char.IsLetter) && password.Any(char.IsDigit))) { throw new ArgumentException("The password must consist of numbers and letters"); }
        Password = password;
    }
}



public abstract class JsonStorage<T>
{
    public List<T> Items { get; protected set; } = new List<T>();
    protected abstract string FilePath { get; }

    public bool Initialization()
    {
        if (!File.Exists(FilePath)) { return false; }
        string data = File.ReadAllText(FilePath);
        if (string.IsNullOrWhiteSpace(data)) { throw new FileLoadException("File is empty"); }

        try
        {
            Items = JsonConvert.DeserializeObject<List<T>>(data);
        }
        catch
        {
            throw new FileLoadException("File damaged");
        }
        return true;
    }

    public bool Preservation()
    {
        if (Items.Count <= 0) { return false; }

        string json = JsonConvert.SerializeObject(Items, Formatting.Indented);
        File.WriteAllText(FilePath, json);

        return true;
    }
}
public class UsersData : JsonStorage<User>
{
    protected override string FilePath => "users_data.json";
}
public class QuizzesData : JsonStorage<Quiz>
{
    protected override string FilePath => "quizzes_data.json";
}

namespace GlobalsData
{
    public static class GlobalData
    {
        public static QuizzesData quizzesData = new QuizzesData();
        public static UsersData usersData = new UsersData();
    }
    public static class Account
    {
        public static User user;
    }
}

internal static class Program
{

    [STAThread]
    static void Main()
    {
        //GlobalData.quizzesData.Initialization();
        //MessageBox.Show(GlobalData.quizzesData.Items.Count.ToString());
        //Quiz quiz = new Quiz("New Quiz", "Me");
        //Question question = new Question("What?");
        //question.answers.Add("Penis", false);
        //question.answers[question.answers.ElementAt(1).Key] = true;
        //quiz.Questions.Add(question);

        //GlobalData.quizzesData.Items.Add(quiz);
        //MessageBox.Show(GlobalData.quizzesData.Items.Count.ToString());

        //User user = new User("Admin", "123456abc", DateTime.Today);
        //GlobalData.usersData.Items.Add(user);
        //GlobalData.usersData.Preservation();

        //var temp = new Question("Second Quistion");
        //temp.AddAnswer("option 3");
        //temp.AddAnswer("option 4");
        //GlobalData.quizzesData.Items[0].Questions.Add(temp);

        GlobalData.usersData.Initialization();
        GlobalData.quizzesData.Initialization();
        Account.user = GlobalData.usersData.Items[0];

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());

        //GlobalData.usersData.Preservation();
        //GlobalData.quizzesData.Preservation();

    }
}
