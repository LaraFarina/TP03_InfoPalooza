class Tiquetera{
    public int UltimoID {get; set;}

    public int DevolverUltimoID(){
        Random r = new Random();
        int devolver;
        devolver = r.Next(1,1000);
        return devolver;
    }
}