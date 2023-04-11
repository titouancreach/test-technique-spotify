# Test technique spotify

***Application dotnet core 7***

Le but de l'application est de pouvoir rechercher des titres de chanson sur Spotify, les ajouter à une bibliothèque puis les noter sur 2 critères, l'originalité (note bleue sur les maquettes) et notre goût (note jaune).

L'application est composée de 2 pages, la première liste tous les titres de notre bibliothèque, et permet de les noter. Les titres sont ordonnés par la moyenne des deux critères. La deuxième page permet de rechercher des titres sur Spotify, et de les ajouter à notre bibliothèque.

Côté backend, on utilisera comme base, le code de ce repository qui contient une application dotnet core, Entity Framework et une base de donnée vierge SQLite.

Pour l'UI, on utilisera TailwindCSS (inclu dans le template).

Pour lancer le projet, on rentre dans le répertoire `./TestTechniqueSpotify` puis on exécute la commande `dotnet run` ou on ouvre le projet avec VSCode, puis on lance le projet depuis le menu `Debug`.

Pour compiler le front, on utilisera: `npm run watch ou npm run build`

On peut utiliser toutes les nouvelles features de C#/dotnet disponibles, installer des plugins aussi bien front que back.  
Soyez créatif.

![image](./mockup.png)
