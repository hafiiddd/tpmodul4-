// See https://aka.ms/new-console-template for more information

using System;
public class KodePos 
{
    //membuat variabel enum berisi nama daerah beserta kosepos
    public enum Area {
        Batununggal = 40266,
        Kujangsari = 40287,
        Mengger = 40267,
        wates = 40256,
        cijaura = 40287,
        Jatisari = 40286,
        Margasari = 40286,
        Sekejati = 40286,
        KebonWaru = 40272,
        Maleer = 40274,
        Samoja = 40273,
    }
    //fungsi yang akan mengembalikan kodepos sesuai dengan data yang di input di var area
    public static int getKodepos(Area Area)
    {
        
        return ((int) Area);
    }
    //menampilkan nilai atau value kodepos dengan memanggil method
    //getkodepos dengan parameter nama daerah tertentu
    public static void Main(string[] args)
    {
        Area kodePos= Area.Batununggal;
        Console.WriteLine($" {kodePos} = {getKodepos(kodePos)}");
    }
}

/*public class DoorMachine
{
    //deklarasi enum doorstate
    public enum DoorState { TERKUNCI, TERBUKA };
    //deklarasi enum trigger
    public enum Trigger { BUKA_PINTU, KUNCI_PINTU };
    //deklasi nilai awal dari doorstate
    public DoorState currentDoorState = DoorMachine.DoorState.TERKUNCI;
    // membuat class transis untuk menganti status state
    public class Transition
    {
        public DoorState stateAwal;
        public Trigger trigger;
        public DoorState stateAkhir;

        public Transition(DoorState stateAwal, DoorState stateAkhir, Trigger trigger)
        {
            this.stateAwal = stateAwal;
            this.trigger = trigger;
            this.stateAkhir = stateAkhir;
        }
    }
    //membuat kondisi atau skenario perpindahan doorstate
    Transition[] Transisi =
    {
        new Transition(DoorState.TERBUKA,DoorState.TERKUNCI,Trigger.KUNCI_PINTU),
        new Transition(DoorState.TERKUNCI,DoorState.TERBUKA,Trigger.BUKA_PINTU),
        new Transition(DoorState.TERBUKA,DoorState.TERBUKA,Trigger.BUKA_PINTU),
        new Transition(DoorState.TERKUNCI,DoorState.TERKUNCI,Trigger.KUNCI_PINTU),
    };
    //fungsi untuk mengembalikan state akhir berdasarkan skenario state yang telah di atur sebelumnya
    public DoorState getNextState(DoorState stateAwal,Trigger trigger)
    {
        DoorState stateAkhir = stateAwal;
        for(int i = 0;i<Transisi.Length;i++)
        {
            Transition ubah = Transisi[i];
            if(stateAwal == ubah.stateAwal && trigger == ubah.trigger)
            {
                stateAkhir = ubah.stateAkhir;
            }
        }
        return stateAkhir;
    }
    public static void Main(string[] args)
    {
        //membuat varstate untuk memanggil class door machine
        DoorMachine state = new DoorMachine();
        Console.WriteLine(state.currentDoorState);
        //memanggil fungsi getstate untuk menampilkan perpindahan jika state awal terkunci dan akan berubah menjadi terbuka dengan trigger
        Console.WriteLine($"state pintu sekarang adalah : {state.getNextState(state.currentDoorState,DoorMachine.Trigger.BUKA_PINTU)}");
        //memanggil fungsi getstate untuk menampilkan perpindahan jika state awal terbuka dan akan berubah menjadi terkunci dengan trigger
        Console.WriteLine($"state pintu sekarang adalah : {state.getNextState(state.currentDoorState, DoorMachine.Trigger.KUNCI_PINTU)}");
    }
}
*/