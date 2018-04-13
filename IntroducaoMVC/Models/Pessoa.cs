namespace IntroducaoMVC.Models {

    public class Pessoa {
        public int id { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }

        public Pessoa(int id,string nome,string tipo) {
            this.id = id;
            this.nome = nome;
            this.tipo = tipo;
        }

        public Pessoa() {

        }
    }
}