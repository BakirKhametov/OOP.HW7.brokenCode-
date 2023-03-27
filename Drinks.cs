class Drinks {
    private String name;
    private Integer volume;

    public String Name {
        get{ return name;}
        set{name = value;}
    }

    public Integer Volume {
        get{return volume;}
        set{if ((volume) > 0) this.volume = volume;
        else Console.WriteLine("Не существует такого объема.");}
    }

}