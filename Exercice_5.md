# Exercice 5 - Un peu de POO
#### Dessinez un diagramme de dépendances des projets (vous pouvez utiliser un diagramme de packages)
![Alt text](/img/diagrammeDependance.bmp)

#### Qu'est-ce qui vous parait être la source du fouilli de dépendances que vous voyez ?
* Le seul interface qui est utilisé dans le code est celui pour la côté DAL et donc le code depend plus de l'implantation qu'aux abstractions. 
* On utilise un switch pour determiner si le dépot est un XML ou un Jsons. Ce n'est pas une bonne pratique car si on veux ajouter d'autre type de depot on devra modifier le code ce qui entre en conflit avec le 'O' de 'SOLID' (OCP)

#### Comment pourriez-vous le résoudre ? Si vous ne voyez pas, essayez d'abstraire et d'appliquer le principe d'inversion de dépendances en ajoutant un nouveau projet qui lui connait les différents types de dépôts.
Si on voulais reduire les dependances, on pourait ajouter un interface pour le côté graphique ce qui permettrait de rendre le code plus modulable en simplifiant le changement d'application pour faire le côté graphique. 

Le côté Batch pourait aussi avoir un interface afin d'ajouter des nouvelles fonctionalités sans risquer d'affecter le reste du code.

Bref, d'ajouter plus d'interface spécifique permetrait être fidèle au 'D' de 'SOLID' Dependency Inversion et d'éviter de dépendre de l'imprementation en privilégiant plutot la dependance aux abstractions.