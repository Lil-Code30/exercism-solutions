class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutes){
        int ExpectedMinutesInOven = this.ExpectedMinutesInOven();
        return ExpectedMinutesInOven - minutes;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers){
        return layers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method

    public int ElapsedTimeInMinutes(int layers, int minutes){
        int PreparationTimeInMinutes = this.PreparationTimeInMinutes(layers);
        return  PreparationTimeInMinutes + minutes;
    }
}
