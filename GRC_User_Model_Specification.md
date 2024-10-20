# GRC User Model Specification

## Syfte
Att utöka den befintliga användarmodellen för att bättre möta behoven i vårt GRC-system (Governance, Risk, and Compliance). 
Denna uppdatering syftar till att förbättra användarhantering, åtkomstkontroll och spårbarhet i systemet.

## Nya fält i användarmodellen
1. Company (string): Användarens tillhörande företag
2. Role (enum): Användarens roll i systemet
3. AccessLevel (enum): Användarens behörighetsnivå
4. LastLoginDate (DateTime): Datum och tid för senaste inloggning
5. IsActive (bool): Om användarkontot är aktivt

## Use cases för olika användartyper
1. Kund:
   - Kan se och uppdatera sin egen företagsprofil
   - Har tillgång till GRC-moduler relevanta för deras företag
   - Kan se rapporter och rekommendationer

2. Konsult:
   - Kan skapa och hantera kundkonton
   - Har tillgång till alla GRC-moduler
   - Kan generera rapporter och rekommendationer för kunder

3. Administratör:
   - Har full åtkomst till alla systemfunktioner
   - Kan hantera alla användarkonton och roller
   - Kan konfigurera systemövergripande inställningar

## Säkerhetskrav
1. Lösenord måste uppfylla starka säkerhetskrav (minst 12 tecken, blandade teckentyper)
2. Tvåfaktorsautentisering ska vara tillgänglig för alla användare
3. Alla användaråtgärder ska loggas för revisionssyften
4. Automatisk utloggning efter en period av inaktivitet
5. Kryptering av känslig användardata i databasen

## Integrationer med andra delar av systemet
1. Användarmodellen ska integreras med GRC-modulerna för att styra åtkomst och synlighet
2. Användaraktivitet ska kopplas till revisionsloggar i compliance-modulen
3. Användarroller ska påverka dashboards och rapportgenerering
4. Integrering med e-postnotifieringssystem för användarrelaterade händelser

## Framtida överväganden
1. Single Sign-On (SSO) integration
2. API för extern användarhantering
3. Stöd för flera företag per användare (för konsulter som arbetar med flera kunder)