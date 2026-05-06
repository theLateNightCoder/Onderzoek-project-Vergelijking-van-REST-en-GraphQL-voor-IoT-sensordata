Moderne IoT systemen sturen continu sensordata naar een backend. Voor deze
communicatie worden API architecturen zoals REST en GraphQL gebruikt. Uit
de resultaten blijkt dat de keuze van een API invloed kan hebben op prestaties
zoals netwerkgebruik en serverbelasting, vooral bij grote hoeveelheden data en
veel gelijktijdige sensoren.

Het doel van dit onderzoek is om te vergelijken hoe REST en GraphQL
presteren in een IoT backend. Hiervoor zijn twee prototypes gebouwd die
dezelfde sensordata verwerken, elk met een andere API architectuur. Met be
hulp van tools zoals Grafana k6 en Docker zijn metingen uitgevoerd op het
gebied van netwerkgebruik en serverbelasting
