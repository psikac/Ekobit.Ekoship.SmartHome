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

## Arhitektura kako/zašto:
### Ekobit.Ekoship.SmartHome.Data
**Data access sloj** - sadrži context, migracije i modele potrebne za rad sa Entity Frameworkom, te repozitorije za upravljanje podacima

### Ekobit.Ekoship.SmartHome.Desktop
**UI sloj** - WinForms aplikacija, koristi servise iz business sloja i modele iz data access sloja

### Ekobit.Ekoship.SmartHome.Desktop.Web
**UI sloj** - WinForms aplikacija, koristi HTTP klijent da dohvati podatke koje pruža API. Alternativa za običnu (offline) desktop aplikaciju.

### Ekobit.Ekoship.SmartHome.Model
**UI sloj** - Sadrži modele za komunikaciju preko HTTPa, te pravila za mapiranje između tih modela i onih koje koristi Entity Framework. Izdvojeno u poseban projekt jer se koristi i u **WebAPI** i **Desktop.Web** projektima, da se izbjegne dupliciranje koda.

### Ekobit.Ekoship.SmartHome.Services
**Business sloj** - Sadrži servise sa poslovnom logikom koji komuniciraju sa repozitorijima u nižem (data access) sloju, te ih nakon obrade predaju višem (UI sloju).

### Ekobit.Ekoship.SmartHome.WebAPI
**UI sloj** - Ponekad izdvojen u poseban 'API' sloj. Koristi se kao 'access point' za podatke kojima baratamo, a koje dobiva iz business sloja (servisa). Može ih koristiti bilo koja aplikacija preko HTTP zahtjeva (ovdje ih koristi **Desktop.Web** aplikacija).
