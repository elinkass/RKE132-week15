string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Console.WriteLine("Temp array");
    ReadDataFromArray(tempArray);
}

static string[] GetDataFromMyFile()
{
    string filePath = @":data\movies.txt";
//string[] dataFromFile = File.ReadAllLines(filePath);
 return File.ReadAllLines(filePath);

}

static void ReadDataFromArray(string[] someArray)
{
foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}


class Movie
{
    string title;
    string year;


    public string Title
    {

        get { return title; }

    }

    public string Year
    {

        get { return year; }
    
    }
    public Movie(string _title,string _year)
    {
        title = _title;
        year = _year;

    }

}