# Ekobit.Ekoship.SmartHome
Repozitorij za pozvano predavanje Ekobit/FOI, svibanj 2023., backend dio

## Upute za pokretanje:
Kreiranje baze:
  1. Otvoriti SQL Server Management Studio i kreirati novu bazu
  2. Pronaći connection string novokreirane baze\
    a) Otvoriti Visual Studio\
    b) Alatna traka -> View -> Server Explorer -> ikonica 'Connect to Database' -> Koristiti Wizard za dodavanje veze na bazu\
    c) Kad je baza dodana, desni klik na nju -> Properties -> Connection String
3. Preuzeti repozitorij sa 'master' grane u Visual Studio i buildati projekt
4. Otvoriti datoteku appsettings.Development.json i zamijeniti postojeći connection string sa svojim (iz koraka 2)
5. Otvoriti konzolu u Visual Studio:\
  a) Alatna traka -> Tools -> NuGet Package Manager -> Package Manager Console\
  b) Iznad otvorene konzole, pod 'Default project' iz dropdown-a odabrati 'Ekobit.Ekoship.SmartHome.Data'\
  c) U konzoli izvršiti sljedeću komandu: update-database
6. Pokrenuti aplikaciju
