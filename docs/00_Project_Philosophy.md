# Projekt filozófia
A Gateway program egy moduláris felépítésű integrációs platform, ami egységes rádió- és vezérlőplatform független összeköttetést nyújt a rádiók, szükség szerint további állomáskomponensek (pl. antenna kapcsoló, rotor stb.) és külső vezérlő-, megjelenítő eszközök között.
A vezérelni kívánt rádióállomás adott felépítése is moduláris, amiben minden komponens csak egy műveletcsoportért felel.
A belős busz eseményvezérelt kommunikációt biztosítá a Gateway komponensei között.
A különböző állapotváltozások és kéréseket a gateway egy egységes belső rádióvezérlési nyelvre fordítja.
A gateway ezeket a rádióvezérlési műveleteket egy vagy több rádió driveren keresztül adja tovább az adott közvetlen rádiókezelő rétegnek.
A Gateway nem csak vezérlési parancsokat fogad, fenntartja és publikálja a rádióállomás aktuális állapotának belső reprezentációját, melyet minden kliens egységesen elérhet.
A Gateway egyetlen komponense sem kommunikál közvetlenül más komponensekkel, hanem minden kommunikáció a Gateway által definiáli interfészeken és eseményeken történik.
A Gateway-nek nem célja a működő rétegek kiválsása, hanem azok integrálása egy egységes architektúrába.
