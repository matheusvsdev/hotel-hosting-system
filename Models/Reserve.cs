using System;
using System.Collections.Generic;
using SistemaHospedagemHotel.Models;

namespace SistemaHospedagemHotel.Models
{
    public class Reserve
    {
        public List<User> Guests { get; set; } = new List<User>();
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Reserve() {}

        public Reserve(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        // Registrar lista de hóspedes, verificando a capacidade da suíte
        public void RegisterGuests(List<User> guests)
        {
            if (guests.Count <= Suite.Capacity)
            {
                Guests = guests;
            }
            else
            {
                throw new Exception("Capacidade da suíte é menor que o número de hóspedes.");
            }
        }

        // Registrar uma suíte
        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        // Retorna a quantidade de hóspedes
        public int GetQuantityGuests()
        {
            return Guests.Count;
        }

        // Calcula o valor total da reserva, aplicando desconto se necessário
        public decimal CalculateDailyValue()
        {
            decimal value = ReservedDays * Suite.DailyValue;

            if (ReservedDays >= 10)
            {
                value *= 0.9m; // Desconto de 10%
            }

            return value;
        }
    }
}