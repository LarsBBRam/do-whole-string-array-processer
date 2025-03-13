namespace do_whole_string_array_processer;

class Program
{
    static void Main(string[] args)
    {
        string[] myStrings = new string[2] { "I like Pizza. I like roast chicken. I like salad", "I like all three of the menu choice" };

        int stringsCount = myStrings.Length;

        string myString = "";
        int periodLocation = 0;

        for (int i = 0; i < stringsCount; i++)
        {
            myString = myStrings[i];
            periodLocation = myString.IndexOf(".");

            string mySentence;

            while (periodLocation != -1)
            {

                mySentence = myString.Remove(periodLocation);

                myString = myString.Substring(periodLocation + 1).TrimStart();

                // myString = myString.TrimStart();

                periodLocation = myString.IndexOf(".");

                Console.WriteLine(mySentence);

            }
            mySentence = myString.Trim();
            Console.WriteLine(mySentence);
        }
    }
}
