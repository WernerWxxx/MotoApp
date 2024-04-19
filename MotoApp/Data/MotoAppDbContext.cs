namespace MotoApp.Data;

using Microsoft.EntityFrameworkCore;    // Opis Zobacz nr 1  z LEKCJI 16
using MotoApp.Entities;     // Opis Zobacz nr 2  z LEKCJI 16
using MotoApp.Repositories;

// KODY w Pliku z LEKCJI 21

public class MotoAppDbContext : DbContext   // Opis Zobacz nr 1  z LEKCJI 16
{
    public DbSet<Employee> Employees => Set<Employee>(); // Opis Zobacz nr 2 z LEKCJI 16
    
    // - DbSet - użycie polecenia   Opis Zobacz nr 2 z LEKCJI 16  2:45 min
    // - " DbSet " Informacja do <Employee> że Employees jest Zasobem Danych

    public DbSet<BusinessPartner> BusinessPartners => Set<BusinessPartner>(); // Opis Zobacz nr 3
                                                                              // z LEKCJI 16
    // - DbSet - użycie polecenia   Opis Zobacz nr 2 z LEKCJI 16  2:45 min
    // - " DbSet " Informacja do <Employee> że Employees jest Zasobem Danych
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseInMemoryDatabase("StorageMotoAppDb");
    }

}


// INFORMACJE

// KODY w Plikach z LEKCJI 16

// Opisy Lini Kodów w Programie

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 1

///// Opis Działania Kodu Lini w Pliku w GRUPA 2 Lekcja 16
//
// Nowy Wpis w Kodzie Prog
// DbContext  -
//

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 2

//  Działanie Kodu w GRUPA 2 Lekcja 16
// 2:50 min
// DbSet<Employee> Employees
//  - mówi EntityFrameworkowiCore że Employees jest  zasobem
//    i jest ustawiony Metodą Set() która też znajduje się w tym Kontekście

//  Set<Employee>();
// using MotoApp.Entities; - samo się wpisało po wpisaniu Lini Kodu z DbSet<Employee>

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr - 3

///// Opis Działania Kodu Lini w Pliku w GRUPA 2 Lekcja 16

//  public DbSet<BusinessPartner> BusinessPartners => Set<BusinessPartner>();
//  
//  - Kod Prog tak jak Wyżej w nr 2 Obsługująca 2 Zasób czyli BusinessPartner-a

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 2 -n
//  Działanie Kodu w GRUPA 2 Lekcja 11

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 1 -n
///// Opis Działania Kodu Lini w Pliku w GRUPA 2 Lekcja 15
///

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 2 -n
//  Działanie Kodu w GRUPA 2 Lekcja 11