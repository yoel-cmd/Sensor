# Sensor
Sensor Agent Game (C#)
תיאור
משחק שבו סוכנים בדרגות שונות מפעילים סנסורים. כל סוכן מקבל כמות סנסורים בהתאם לדרגתו, והסנסורים מאותחלים באופן רנדומלי. המשחק מפעיל את כל הסנסורים של הסוכן.
מבנה הקוד
מחלקה Sensor
מייצגת סנסור בודד.

שדות:
Name (string): שם הסנסור.


מתודות:
Activate(): מפעילה את הסנסור ומדפיסה הודעה על הפעלתו.



מחלקה Agent
מייצגת סוכן עם דרגה וכמות סנסורים מוקצית.

שדות:
Rank (string): דרגת הסוכן (למשל, "זוטר", "בכיר").
Sensors (List): רשימה של אובייקטים מסוג Sensor, מאותחלת אוטומטית בהתאם לדרגה.
מילון קבוע RankSensorCount:private static readonly Dictionary<string, int> RankSensorCount = new Dictionary<string, int>
{
    { "זוטר", 2 },
    { "בכיר", 3 },
    { "מנהל", 5 }
};




מתודות:
Agent(string rank): מאתחלת את הסוכן עם דרגה וממלאת את רשימת הסנסורים באופן רנדומלי.
ActivateSensors(): מפעילה את כל הסנסורים של הסוכן.



מחלקה Game
מייצגת את המשחק עצמו.

שדות:
Agents (List): רשימה של סוכנים במשחק.


מתודות:
AddAgent(Agent agent): מוסיפה סוכן למשחק.
Start(): מפעילה את כל הסנסורים של כל הסוכנים במשחק.



דוגמת שימוש
using System;

class Program
{
    static void Main(string[] args)
    {
        // יצירת משחק
        Game game = new Game();

        // יצירת סוכנים
        Agent juniorAgent = new Agent("זוטר");
        Agent seniorAgent = new Agent("בכיר");

        // הוספת סוכנים למשחק
        game.AddAgent(juniorAgent);
        game.AddAgent(seniorAgent);

        // הפעלת המשחק
        game.Start();
    }
}

דרישות

.NET Core או .NET Framework
סביבת פיתוח תומכת C# (כגון Visual Studio)

התקנה

ודא ש-.NET SDK מותקן במערכת.
צור פרויקט C# חדש:dotnet new console -o SensorAgentGame


שמור את הקוד בקובץ (למשל, Program.cs).
הרץ את הפרויקט:dotnet run



הערות

שמות הסנסורים נוצרים באופן רנדומלי (למשל, "Sensor_1", "Sensor_2").
ניתן להוסיף דרגות נוספות למילון RankSensorCount במחלקה Agent.
המשחק מדפיס הודעות על הפעלת הסנסורים של כל סוכן.

הרחבות אפשריות

הוספת סוגי סנסורים שונים עם התנהגויות מגוונות.
הוספת ממשק משתמש גרפי (למשל, עם Windows Forms או WPF).
שמירת מצב המשחק בקובץ.

מחבר
[השם שלך]
