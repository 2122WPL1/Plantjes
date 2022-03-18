using System.Diagnostics;
using System.Windows;
using Newtonsoft.Json;

namespace Plantjes; 

public class Util {
    
}

public static class UtilExtensions {
    
    public static JsonSerializerSettings jss = new JsonSerializerSettings() {
        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
    };
    public static void PrintDebug(this object myObj) {
        Debug.WriteLine(JsonConvert.SerializeObject(myObj, jss));
    }

    public static Visibility AsVisibility(this bool visibility) {
        return visibility ? Visibility.Visible : Visibility.Collapsed;
    }
}