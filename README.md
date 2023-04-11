# Test technique spotify

Le but de l'application est de pouvoir rechercher des titres de chanson sur Spotify, les ajouter à une bibliothèque puis pouvoir les noter.

L'application est composée de 2 pages, la première (page d'accueil par exemple), contient un champ de recherche des titres sur Spotify (ou autre), puis à coté de chaque résultat, un bouton pour ajouter le titre à notre bibliothèque.  
La deuxième page liste tous les titres que contient notre bibliothèque, et permet, pour chaque titre de le noter (entre 1 et 5).

Côté backend, on utilisera comme base, le code de ce repository qui contient une application Dotnet Core, Entity Framework et une base vierge SQLite.

Pour l'UI, on utilisera TailwindCSS (inclu dans le template).

Pour lancer le projet, on rentre dans le répertoire `./TestTechniqueSpotify` puis on exécuter la commande `dotnet run` ou on ouvre le projet avec VSCode, puis on lance le projet depuis le menu `Debug`.
