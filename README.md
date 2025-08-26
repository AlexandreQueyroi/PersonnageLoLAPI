# PersonnageLoL API
Projet effectué dans le but d'apprendre le C#

---
## Personnage League of Legends API

API REST développée en **ASP.NET Core 9** suivant le modèle MVC.
Elle permet de gérer des personnages de League of Legends via des opérations CRUD (Create, Read, Update, Delete).
---
## Fonctionnalités

- Récupérer la liste des personnages LoL
- Obtenir un personnage spécifique par son identifiant
- Créer un nouveau personnage
- Mettre à jour un personnage existant
- Supprimer un personnage
---
## Technologies utilisées

- [.NET 9](https://dotnet.microsoft.com/)
- ASP.NET Core Web API
- Entity Framework Core + SQLite
  - Swagger

---
## Structure du projet
```
PersonnageLoLAPI/
│
├── Controllers/
│   └── PersonnageLoLController.cs   # Contrôleur de l’API
│
├── Models/
│   └── PersonnageLoL.cs             # Classe représentant un personnage
│
├── Data/
│   └── ApplicationDbContext.cs      # Contexte EF Core
│
├── Migrations/                      # Historique des migrations EF Core
├── appsettings.json                 # Config (BDD, logs, etc.)
├── Program.cs                       # Point d’entrée
└── README.md
```
---
## Installation et Lancement
1. Cloner le projet ``git clone https://github.com/AlexandreQueyroi/PersonnageLoLAPI.git``
2. Aller dans le dossier du projet ``cd PersonnageLoLAPI``
3. Initialiser le projet ``bash setup.sh``
4. Lancer le projet ``dot run``
5. Se rendre sur http://localhost:5066/api/PersonnageLoL et http://localhost:5066/swagger/

## Endpoints disponibles

| Méthode | Route                   | Description                                |
|---------|-------------------------|--------------------------------------------|
| GET     | `/api/PersonnageLoL`    | Récupérer la liste de tout les personnages |
| GET     | `/api/PersonnageLoL/{id}` | Récupérer un personnage via son ID         |
|    POST     | `/api/PersonnageLoL`    | Ajouter un personnage                      |
|   PUT      | `/api/PersonnageLoL/{id` | Modifier un personnage existant            |
|    DELETE     | `/api/PersonnageLoL/{id}`                        | Supprimer un personnage                    |

---
## Exemples de requêtes JSON

### POST – Ajouter un personnage
```
{
"nom": "Ashe",
"role": "ADC",
"pv": 600,
"attaque": 75
}
```

### PUT – Modifier un personnage
```
{
"id": 1,
"nom": "Ashe",
"role": "ADC",
"pv": 650,
"attaque": 80
}
```

---

Projet libre de droit, réalisé dans le seul but d'apprendre le C# dans le cadre de mes recherches personnelles