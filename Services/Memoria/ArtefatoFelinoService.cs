using CatShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CatShop.Services.Memoria;

public class ArtefatoFelinoService : IArtefatoFelinoService
{
    public ArtefatoFelinoService()
        => CarregarListaInicial();

    private IList<ArtefatoFelino> _ArtefatoFelinos;

    private void CarregarListaInicial()
    {
        _ArtefatoFelinos = new List<ArtefatoFelino>()
        {
            new ArtefatoFelino
            {
                ArtefatoFelinoId = 1,
                Nome = "Playground",
                Descricao ="Nosso playground interativo é uma academia de diversão, oferecendo desafios mentais e físicos que mantêm seu felino engajado e ativo. Dê a eles um playground que satisfaz sua curiosidade e mantém a felicidade constante!" ,
                Imagem = "/imagens/b1.jpg",
                Preco = 99.00,
                Disponibilidade = true,
                DataCadastro = DateTime.Now
            },

            new ArtefatoFelino
            {
                ArtefatoFelinoId = 2,
                Nome = "Kit Filhote",
                Descricao ="Inclui 1 * túnel de tenda de arco-íris, 2 * bola de sino, 2 * bola transparente, 2 * bola de pelúcia, 2 * tambor pequeno, 2 * molas, 2 * brinquedo de rato, 1 * brinquedo de lagarta, 1 * varinha teaser de pena interativa. Brinquedos de gato de pacote de valor para gatos e gatinhos de interior em todas as idades. Nota: cor dos acessórios aleatoriamente." ,
                Imagem = "/imagens/b2.jpg",
                Preco = 79.00,
                Disponibilidade = true,
                DataCadastro = DateTime.Now
            },
            new ArtefatoFelino
            {
                ArtefatoFelinoId = 3,
                Nome = "Relax",
                Descricao ="O Cat Relax Furacão Pet vem com brinquedo para adestração do seu gato, para descansar e brincar sem sair do lugar, um anti-stress para seu gatinho; possui no centro um papelão com texturas onduladas para os gatos afiarem suas unhas, servindo de arranhador e deixando o local mais atrativo" ,
                Imagem = "/imagens/b3.jpg",
                Preco = 49.00,
                Disponibilidade = true,
                DataCadastro = DateTime.Now
            },
            new ArtefatoFelino
            {
                ArtefatoFelinoId = 4,
                Nome = "Tunel",
                Descricao ="Túnel Interativo Para Gatos Os gatinhos são animais curiosos por instinto, e precisam de muitos estímulos para se manterem sempre saudáveis e ativos. Pensando nisso, o Túnel Para Gatos é a opção ideal, desenvolvido com material de excelente qualidade, o brinquedo estimula a curiosidade do gato, enquanto ele passeia pelo circuito" ,
                Imagem = "/imagens/b4.jpg",
                Preco = 59.00,
                Disponibilidade = true,
                DataCadastro = DateTime.Now
            },
            new ArtefatoFelino
            {
                ArtefatoFelinoId = 5,
                Nome = "Casinha com rede",
                Descricao ="A casinha para gatos mais vendida na internet e uma das maiores desse modelo no mercado, projetada para acompanhar o seu felino desde filhote até a vida adulta. Realizamos testes com gatos grandes, que pesavam entre 6 e 8 kg, e notamos que eles utilizam o espaço com tranquilidade." ,
                Imagem = "/imagens/a1.jpg",
                Preco = 200.00,
                Disponibilidade = true,
                DataCadastro = DateTime.Now
            },
            new ArtefatoFelino
            {
                ArtefatoFelinoId = 6,
                Nome = "Arranhador",
                Descricao ="O Arranhador Para Gato 2 Bases Com Brinquedo Duplo da ld Pet é uma excelente opção de brinquedo por oferecer ao seu gatinho uma diversão que é ideal para afiar e lixar suas unhas, além de um cantinho para subir!" ,
                Imagem = "/imagens/a2.jpg",
                Preco = 99.00,
                Disponibilidade = true,
                DataCadastro = DateTime.Now
            }
        };
    }

    public IList<ArtefatoFelino> BuscarTodos() => _ArtefatoFelinos;

    public ArtefatoFelino BuscarPorId(int id) => BuscarTodos().SingleOrDefault(item => item.ArtefatoFelinoId == id);

    public void Incluir(ArtefatoFelino ArtefatoFelino)
    {
        var proximoId = _ArtefatoFelinos.Max(item => item.ArtefatoFelinoId) + 1;
        ArtefatoFelino.ArtefatoFelinoId = proximoId;
        _ArtefatoFelinos.Add(ArtefatoFelino);
    }

    public void Alterar(ArtefatoFelino ArtefatoFelino)
    {
        var ArtefatoFelinoEncontrado = _ArtefatoFelinos.SingleOrDefault(item => item.ArtefatoFelinoId == ArtefatoFelino.ArtefatoFelinoId);

        if (ArtefatoFelinoEncontrado != null)
        {
            ArtefatoFelinoEncontrado.Nome = ArtefatoFelino.Nome;
            ArtefatoFelinoEncontrado.Descricao = ArtefatoFelino.Descricao;
            ArtefatoFelinoEncontrado.Preco = ArtefatoFelino.Preco;
            ArtefatoFelinoEncontrado.Disponibilidade = ArtefatoFelino.Disponibilidade;
            ArtefatoFelinoEncontrado.DataCadastro = ArtefatoFelino.DataCadastro;
            ArtefatoFelinoEncontrado.Imagem = ArtefatoFelino.Imagem;
        }

    }

    public void Excluir(int id)
    {
        var ArtefatoFelinoEncontrado = BuscarPorId(id);
        _ArtefatoFelinos.Remove(ArtefatoFelinoEncontrado);
    }

    public IList<Marca> ConsultarMarcas()
    {
        return new List<Marca>();
    }
    public Marca ObterMarca(int id)
    {
        return new Marca();
    }
}
