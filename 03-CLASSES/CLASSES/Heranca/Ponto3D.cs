namespace Classes.Herança
{
    public class Ponto3D : Ponto
    {
        public int z;
        // -> Já instancio os valores diretamente
        public Ponto3D(int x, int y, int z) : base(x, y) 
        {
            this.z = z;
            calculateDistance();
            
        }

        public static void calculate() // Para acessar esse metodo não preciso necessariamente instanciar o obj
        {

        }

        public override void calculateDistance3()
        {
            // base é minha classe base que eu herdei
            base.calculateDistance3();
        }
    }
}