using Jessica;

public class initmodule : JessModule {
    public initmodule () {
        Get("/", r => "Hello JESSICA");
    }
}