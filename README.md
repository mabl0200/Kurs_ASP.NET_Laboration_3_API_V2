# Kurs_ASP.NET_Laboration_3_API_V2

Testning av API genom Postman:

- Hämta alla personer i systemet
  -	GET https://localhost:44370/api/persons
-	Hämta alla intressen som är kopplade till en specifik person
  - GET https://localhost:44370/api/persons/hobbies/1
-	Hämta alla länkar som är kopplade till en specifik person
  - GET https://localhost:44370/api/persons/links/1
-	Koppla en person till ett nytt intresse
  - POST https://localhost:44370/api/personhobbies 
   	{
      	"personId": 5,
         "person": null,
          "hobbyId": 2,
          "hobby": null
       	}
-	Lägga in nya länkar för en specifik person och ett specifikt intresse
  - POST https://localhost:44370/api/links 
  { 
          "url": "schack.se/",
          "personId": 2,
          "person": null,
          "hobbyId": 1,
          "hobby": null
      }
