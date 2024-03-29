﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filas {
    class Clientes {
        public String nome;             // nome do cliente.
        public DateTime horarioChegada; // data e hora de chegada do cliente.
        public Clientes proximo;         // referência ao próximo cliente na fila.

        // Construtor que inicializa os atributos nome e horarioChegada com os valores passados através dos parâmetros nomeCliente e chegada desse método, respectivamente; e o atributo que indica o próximo cliente da fila com null.
        public Clientes(String nomeCliente, DateTime chegada) {
            nome = nomeCliente;
            horarioChegada = chegada;
            proximo = null;
        }
    }
}
