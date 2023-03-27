
class HotDrinks:Drinks {
    private String name;
    private Integer volume;
    private Integer temperature;


    public override String Name {
        get{ return name;}
        set{name = value;}
    }

    public override Integer Volume {
        get{return volume;}
        set{volume = value;}
    }

    public Integer Temperature {
        get{return temperature;}
        set{if (temperature > 0) this.temperature = temperature;
        else Console.WriteLine("В данном автомате не продается лёд.");}
    }

    public override String ToString() {
        return "HotDrinks{" +
                "name='" + name + '\'' +
                ", volume=" + volume +
                ", temperature=" + temperature +
                '}';
    }
    public HotDrinks(String name, Integer volume, Integer temperature){
        this.name = name;
        this.volume = volume;
        this.temperature = temperature;

    }
}
