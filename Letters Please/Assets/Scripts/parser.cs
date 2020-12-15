using System.Text.Json;

namespace letterConfig {

    class Generator {
        public (Letter letter, Report report, Recon recon) get(int difficulty, int presents, Child child) {
            //TODO: Figure out how I want to generate them
        }
    }

    class Child {
        string name;
        int presentsWanted;
        int lexile;
        bool naughty;

        public child(string Name, int Presents, int Lexile, bool Naughty) {
            name = Name;
            presentsWanted = Presents;
            lexile = Lexile;
            naughty = Naughty;
        }
    }
    class Letter {
        public string content;
        public int goodDeeds;
        public int badDeeds;
        public letter() {
        }
    }

    class Report {
        public string content;
        public int goodDeeds;
        public int badDeeds;
        
        public report() {
        }
    }

    class Recon {
        string cookiePath;
        int numCookies;
        CookieType cookie; //TODO: Come up with cookieType
    }

    // Because I'm supremely lazy it's being generated using a tool online
    // Thank you https://json2csharp.com/ you're a lifesaver for this boilerplate
    // TODO: Really instead of being lazy I should use Generics to make all the 
    // pet/sibling stuff dissapear into a single class, then one line each for decl

    // TODO: Oh my god if this works it's amazing
    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
    // To use this
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

}