### README.md Quiz-ohjelmalle

---

#### Yleiskatsaus
Tämä C# Windows Forms -sovellus on visailuohjelma, joka tarjoaa interaktiivisen tavan testata tietämystä eri kategorioissa. Ohjelma käyttää JSON-tiedostoa kysymysten lataamiseen ja tarjoaa monivalintavastauksia. Kysymysten vaikeusaste kasvaa ohjelman edetessä, alkaen helposta ja etenee keskivaikean kautta vaikeisiin kysymyksiin.

#### Ominaisuudet
- **Kategorian Valinta**: Käyttäjät voivat valita visailun kategorian räätälöidäkseen visailun omien kiinnostuksen kohteidensa mukaan.
- **Kysymysten Vaikeusaste**: Kysymysten vaikeusaste kasvaa 10 kysymyksen välein, alkaen "helposta", edeten "keskivaikeaan" ja lopulta "vaikeaan".
- **Kysymysten Selailu**: Käyttäjät voivat navigoida eri kysymysten läpi visailun aikana.
- **Pisteiden Seuranta**: Sovellus seuraa käyttäjän pisteitä ja näyttää ne visailun lopussa.

#### Vaatimukset
- Windows-käyttöjärjestelmä
- .NET Framework (yhteensopiva kehityksessä käytetyn version kanssa)
- Newtonsoft.Json (JSON-tiedostojen käsittelyyn)

#### Asennus
1. Kloonaa tai lataa repositorio paikalliselle koneellesi.
2. Avaa ratkaisutiedosto (.sln) Visual Studiolla.
3. Palauta tarvittaessa NuGet-paketit.
4. Käynnistä sovellus.

#### Käyttö
- **Visailun Aloitus**: Suorita sovellus ja klikkaa "Aloita" painiketta pääformissa.
- **Kategorian Valinta**: Valitse haluamasi visailukategoria kategorianvalinta formissa.
- **Kysymyksiin Vastaaminen**: Valitse vastauksesi monivalintavaihtoehdoista jokaiseen kysymykseen.
- **Pisteiden Katsominen**: Visailun lopussa, katso pisteesi pistetauluformissa.

#### Tiedostorakenne
- `Form1.cs`: Sovelluksen pääformi, toimii sisääntulopisteenä.
- `PeliForm.cs`: Käsittelee visailupelin logiikan.
- `KategoriaValintaForm.cs`: Mahdollistaa käyttäjien valita visailun kategorian.
- `PistetauluForm.cs`: Hallinnoi pistetaulukkoa tai tuloksia.
- `Program.cs`: Sovelluksen pääsisääntulopiste.
- `QuestionRoot.cs`: Määrittelee kysymysobjektin ja käsittelee JSON-tietojen prosessointia.
- `kysymykset.json`: Sisältää visailukysymykset JSON-muodossa.

#### Tekijät
Tämä projekti on toteutettu ryhmätyönä seuraavien henkilöiden toimesta:

- Anssi Peltola [https://github.com/AnssiPeltola](https://github.com/AnssiPeltola)
- Annemari Humaloja-Mäkinen [https://github.com/AnnemariHM](https://github.com/AnnemariHM)
- Toni Lehtonen [https://github.com/ToniSasky](https://github.com/ToniSasky)

---
