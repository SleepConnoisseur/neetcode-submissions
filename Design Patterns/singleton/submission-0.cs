public class Singleton {

    private static volatile Singleton instance = null;

    private string value = "";

    private Singleton() {
    }

    public static Singleton getInstance() {
        if(instance == null){
            instance = new Singleton();
        }
        return instance;
    }

    public string getValue() {
        return this.value;
    }

    public void setValue(string value){
        this.value = value;
    }
}
