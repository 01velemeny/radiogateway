A döntések a Core-ban születnek, a külső eszközök eseményeinek fogadása és az RDL-re fordítás a driver-ben történik, mint ahogy az RDL fogadása és külső eszközre továbbítása is. A busz szerepe a továbbítás, kliensekkel kapcsolattartás.


| Feladat                            | Driver | Bus |     Core     |  Miért  |
| ---------------------------------- | :----: | :-: | :----------: | :------:|
| MIDI esemény fogadása              |    ✓   |     |              ||
| CAT válasz fogadása                |    ✓   |     |              |Driver alakítja RDL-re|
| JSON → RDL                         |    ✓   |     |              ||
| RDL → CAT                          |    ✓   |     |              ||
| Feliratkozás eseményekre           |    ✓   |  ✓  |              ||
| Esemény publikálása                |        |  ✓  | kezdeményezi ||
| Esemény továbbítása                |        |  ✓  |              ||
| Aktív rádió kiválasztása           |        |     |       ✓      |A Core ismeri a teljes állomást|
| Routing cél meghatározása          |        |     |       ✓      ||
| Capabilities lekérdezése           |    ✓   |     |  ✓ használja ||
| Command validálása                 |        |     |       ✓      |Az állapot, konfiguráció és Driver Capabilities alapján a Core dönt|
| State frissítése                   |        |     |       ✓      ||
| Policy alkalmazása                 |        |     |       ✓      ||
| FrequencyStep → Frequency számítás |        |     |       ✓      |Core ismeri a State-e és a szabályokat|
| Band váltási logika                |        |     |       ✓      |Esetleg később állítható a logika, de akkor is core|
| Konfliktuskezelés                  |        |     |       ✓      ||
| Polling időzítése                  |    ✓   |     |              |Driver ismeri a rádió protokollját|
| Driver kapcsolat állapota          |    ✓   |     |  ✓ összesíti |x|
| Külső kliensek kapcsolatai         |        |  ✓  |              ||
| State lekérdezése                  |        |     |   ✓          | A State egyetlen hiteles példánya a Core-ban van. |
| State Snapshot előállítása         |        |     |   ✓          | A teljes State csak a Core-ban ismert. |
| Snapshot továbbítása               |        |  ✓  |              | A Bus továbbítja a kliensnek.          |
| Driver regisztráció induláskor     |        |      |   ✓         | A driver bemutatkozik - Capabilities |  



A Driver csak annyit tud connected, disconnected, error. A CORE tudja; station ready, No Active Radio, Degraded, Fully Operational


Driver -> RDL -> Core -> RDL -> Driver
