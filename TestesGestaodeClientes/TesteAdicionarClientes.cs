namespace TestesGestaodeClientes

{

    [TestClass]
    public class TesteAdicionarClientes
    {
        [TestMethod]
        public void TesteQuantidadeDeNumerosSucesso()
        {
            string CPF = "12345678912";
            bool resultado = GestaodeCliente.AdicionarClientes.validaCPF(CPF);
            Assert.AreEqual(true, resultado);

        }

        [TestMethod]
        public void TesteQuantidadeDeNumerosFaltandoCaracter()
        {
            string CPF = "12344444";
            bool resultado = GestaodeCliente.AdicionarClientes.validaCPF(CPF);
            Assert.AreEqual(false, resultado);

        }
    }

}