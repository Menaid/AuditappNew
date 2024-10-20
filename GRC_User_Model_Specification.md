# GRC User Model Specification

## Syfte
Att ut�ka den befintliga anv�ndarmodellen f�r att b�ttre m�ta behoven i v�rt GRC-system (Governance, Risk, and Compliance). 
Denna uppdatering syftar till att f�rb�ttra anv�ndarhantering, �tkomstkontroll och sp�rbarhet i systemet.

## Nya f�lt i anv�ndarmodellen
1. Company (string): Anv�ndarens tillh�rande f�retag
2. Role (enum): Anv�ndarens roll i systemet
3. AccessLevel (enum): Anv�ndarens beh�righetsniv�
4. LastLoginDate (DateTime): Datum och tid f�r senaste inloggning
5. IsActive (bool): Om anv�ndarkontot �r aktivt

## Use cases f�r olika anv�ndartyper
1. Kund:
   - Kan se och uppdatera sin egen f�retagsprofil
   - Har tillg�ng till GRC-moduler relevanta f�r deras f�retag
   - Kan se rapporter och rekommendationer

2. Konsult:
   - Kan skapa och hantera kundkonton
   - Har tillg�ng till alla GRC-moduler
   - Kan generera rapporter och rekommendationer f�r kunder

3. Administrat�r:
   - Har full �tkomst till alla systemfunktioner
   - Kan hantera alla anv�ndarkonton och roller
   - Kan konfigurera system�vergripande inst�llningar

## S�kerhetskrav
1. L�senord m�ste uppfylla starka s�kerhetskrav (minst 12 tecken, blandade teckentyper)
2. Tv�faktorsautentisering ska vara tillg�nglig f�r alla anv�ndare
3. Alla anv�ndar�tg�rder ska loggas f�r revisionssyften
4. Automatisk utloggning efter en period av inaktivitet
5. Kryptering av k�nslig anv�ndardata i databasen

## Integrationer med andra delar av systemet
1. Anv�ndarmodellen ska integreras med GRC-modulerna f�r att styra �tkomst och synlighet
2. Anv�ndaraktivitet ska kopplas till revisionsloggar i compliance-modulen
3. Anv�ndarroller ska p�verka dashboards och rapportgenerering
4. Integrering med e-postnotifieringssystem f�r anv�ndarrelaterade h�ndelser

## Framtida �verv�ganden
1. Single Sign-On (SSO) integration
2. API f�r extern anv�ndarhantering
3. St�d f�r flera f�retag per anv�ndare (f�r konsulter som arbetar med flera kunder)