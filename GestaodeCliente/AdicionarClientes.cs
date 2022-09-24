namespace GestaodeCliente
{
    public class AdicionarClientes
    {
        
        public static bool validaCPF(string numero){
            int contator = 1;

            for(int i = 1; i < numero.Length; i++ ){
                
                if (char.IsNumber(numero[i]))
                {
                    contator++;
                }
            }

            if ( contator == 11){

                return true;

            } 
            else
            {
                return false;
            } 
        }
    
    }
}