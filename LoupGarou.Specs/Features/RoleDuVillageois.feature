Fonctionnalité: Role du villageois
	Dans le but d'éradiquer les loups garous
	En tant que villeagois
	Je veux voter contre un autre joueur

Contexte: 
	Soit le jeu du loup garou

@villageois
Scénario: les villageois votent
	Soit Maria est un villageois
	Et Ambroise est un villageois
	Lorsque Maria vote contre Ambroise
	Alors Ambroise est le prochain mort

@villageois
Scénario: les villageois sont indécis
	Soit Maria est un villageois
	Et Ambroise est un villageois
	Lorsque Maria vote contre Ambroise et Ambroise vote contre Maria
	Alors il n'y a pas de mort
