# S

Game Flow Description
The game follows a flow where:

There are various types of agents and sensors, all defined abstractly.
The user creates an agent type and enters its name. A random list of sensor weaknesses is automatically generated for that agent. The user does not know the exact combination of weaknesses but is aware of the total number of weaknesses, as each agent has a different amount.
Next, the user creates a room where the agent "awaits" with its list of weaknesses. The user has a list of sensors available to try and attach to the room.
The user selects a location and attaches a sensor, then receives feedback on how many weaknesses were hit.
Notes for future addition:

Support for sensors that respond differently will be added.
Agents that respond differently to interrogation will also be implemented (currently exist only as implementation).
Project Content Overview
Sensors Folder: Contains a base sensor class, all sensor types, and a sensor generator for creating a random list.
Agent Folder: Includes a main agent class and various agent classes that inherit from the base.
Room and Game: Features a room class managing the agent and its weaknesses, and a game class handling the game logic.
Program: The main file where the user creates an agent, room, and game, and starts the execution.
Installation Instructions
Ensure you have Visual Studio 2022 or a newer version with C# support.
Clone or copy the entire project folder to your computer.
Open the Sensor.sln file in Visual Studio.
Use "Rebuild Solution" (right-click the project > Rebuild) to ensure everything is set up correctly.
Click "Start" (F5) to run the game.
Usage
Run the program through Visual Studio.
Follow the on-screen instructions to select a location and sensor.
The game ends when all weaknesses are neutralized.
Update Date
This file was last updated on June 18, 2025, at 06:05 PM Israel Daylight Time (IDT).


----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

תיאור זרימת המשחק
המשחק מתבסס על זרימה שבה:

קיימים סוגים שונים של סוכנים וסנסורים, כאשר הכל מוגדר בצורה אבסטרקטית.
המשתמש יוצר סוג סוכן ומזין את שמו. אוטומטית נוצרת רשימת חולשות לסנסורים בצורה רנדומלית עבור הסוכן הזה. המשתמש אינו יודע את התמהיל המדויק של החולשות, אך יודע את כמות החולשות, שכן לכל סוכן יש מספר חולשות שונה.
לאחר מכן, המשתמש יוצר חדר שבו "מחכה" הסוכן עם רשימת החולשות שלו. למשתמש יש רשימה של סנסורים זמינים לנסות ולהצמיד לחדר.
המשתמש בוחר מיקום ומצמיד סנסור, ולאחר מכן מקבל תשובה המציינת כמה מתוך החולשות הוא פגע.
הערות להוספה:

בעתיד, תתווסף תמיכה בסנסורים שמגיבים בצורות שונות.
כמו כן, יתווספו סוכנים שמגיבים בצורות שונות לחקירה (כרגע קיימים רק כמימוש).
פירוט תוכן הפרויקט
תיקיית סנסורים: מכילה מחלקת אב לסנסורים וכל סוגי הסנסורים השונים, וכן מחולל סנסורים ליצירת רשימה רנדומלית.
תיקיית סוכן: כוללת קלאס סוכן ראשי ומחלקות סוכנים שונים שיורשים מהאב.
חדר ומשחק: קיימת מחלקת חדר שמנהלת את הסוכן ורשימת החולשות, ומחלקת משחק שמפעילה את הלוגיקה.
Program: קובץ הראשי שבו המשתמש יוצר סוכן, חדר ומשחק, ומתחיל את הריצה.
הוראות התקנה
ודא שיש לך את Visual Studio 2022 או גרסה חדשה יותר עם תמיכה ב-C#.
העתק את כל תיקיית הפרויקט למחשב שלך.
פתח את הקובץ Sensor.sln ב-Visual Studio.
השתמש בפקודה "Rebuild Solution" (לחיצה ימנית על הפרויקט > Rebuild) כדי לוודא שהכל מתקין כראוי.
לחץ על "Start" (F5) כדי להריץ את המשחק.
שימוש
הרץ את התוכנית דרך Visual Studio.
עקוב אחר ההוראות במסך לבחירת מיקום וסנסור.
המשחק יסתיים כאשר כל החולשות נוטרלו.
תאריך עדכון
קובץ זה עודכן ב-18 ביוני 2025, 18:05 שעון ישראל (IDT).
