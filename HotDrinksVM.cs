public  class HotDrinksVM:VendingMachine{

    List<HotDrinks> hotDrinks = new ArrayList<>();

    void initDrinks(List<HotDrinks> drinks) {
        this.hotDrinks = drinks;
    }
    
    override String getProduct(String name, Integer volume) {
        foreach (HotDrinks hd in hotDrinks) {
            if (hd.Name().Contains(name) && hd.Volume().Equals(volume))
                return hd.Name() + " " + hd.Volume() + " " + hd.Temperature();
        }
        return new HotDrinks("Не найдено!", 0, 0).ToString();

    }
    String getProduct(String name, int volume, int temperature) {
        List <HotDrinks> bottleOfWaterList = new ArrayList<>();
        foreach (HotDrinks hd in hotDrinks) {
            if (hd.Name().Contains(name) && hd.Volume().Equals(volume) && hd.Temperature().Equals(temperature) ){
                bottleOfWaterList.Add(hd);
            }
        }
        return bottleOfWaterList.ToString();
}
}
