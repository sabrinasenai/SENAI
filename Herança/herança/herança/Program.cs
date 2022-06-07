using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herança
{

    public class Pessoa
    {
        public string nome { get; set; }
        protected string CPF { get; set; }
        public string RG { get; set; }
        public string nascimento { get; set; }
        public string e_mail { get; set; }

        public void Exibir()
        {
            Console.WriteLine("CPF é " + CPF);
        }
        public void Get_CPF()
        {
            Console.WriteLine("O CPF é " + CPF);
        }

    }
    public class aluno : Pessoa
    {
        string curso { get; set; }
        string turno { get; set; }

        public aluno(string nome, string CPF, string RG, string nascimento, string e_mail, string curso, string turno)
        {
            this.nome = nome;
            this.CPF = CPF;
            this.RG = RG;
            this.nascimento = nascimento;
            this.e_mail = e_mail;
            this.curso = curso;
            this.turno = turno;
        }

        public void Get_CPF()
        {
            Console.WriteLine("O CPF do aluno é " + this.CPF);
        }



    }
    public class professor : Pessoa
    {
        string matéria { get; set; }
        string turma { get; set; }
        public professor(string nome, string CPF, string RG, string nascimento, string e_mail, string matéria, string turma)
        {
            this.nome = nome;
            this.CPF = CPF;
            this.RG = RG;
            this.nascimento = nascimento;
            this.e_mail = e_mail;
            this.matéria = matéria;
            this.turma = turma;
        }
        public void Get_CPF()
        {
            Console.WriteLine("O CPF do professor é " + this.CPF);
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            aluno aluno = new aluno("teste aluno", "333.555.777-78", "22.333.437-50", "10/06/1990", "testealuno@gmail.com", "Desenvolvimento de " +
                "Sistemas", "noite");
            aluno.Exibir();
            aluno.Get_CPF();

            professor professor = new professor("teste professor", "444.111.222-78", "xx.987.123-50", "06/01/1990", "testeprofessor@gmail.com", "Banco de Dados", "T. I.");
            professor.Exibir();
            professor.Get_CPF();


        }


    }




}
