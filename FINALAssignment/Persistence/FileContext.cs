using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace FileData {
public class FileContext {
    public IList<Adult> Adults { get; private set; }

    private readonly string adultsFile = "Adults.json";

    public FileContext() {
        Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
    }

    private IList<Adult> ReadData<Adult>(string s) {
        using (var jsonReader = File.OpenText(s)) {
            return JsonSerializer.Deserialize<List<Adult>>(jsonReader.ReadToEnd());
        }
    }

    public void SaveChanges() {
        // storing persons
        string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions {
            WriteIndented = true
        });

        using (StreamWriter outputFile = new StreamWriter(adultsFile, false)) {
            outputFile.Write(jsonAdults);
        }
    }
}
}