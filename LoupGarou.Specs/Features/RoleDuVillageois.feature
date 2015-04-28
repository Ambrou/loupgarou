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
	Et le tour des villageois commence
	Lorsque Maria vote contre Ambroise et Ambroise vote contre Ambroise
	Alors Ambroise est le prochain mort

@villageois
Scénario: les villageois sont indécis
	Soit Maria est un villageois
	Et Ambroise est un villageois
	Et le tour des villageois commence
	Lorsque Maria vote contre Ambroise et Ambroise vote contre Maria
	Alors il n'y a pas de mort

@villageois
Scénario: les villageois n'ont pas tous voté
	Soit Maria est un villageois
	Et Ambroise est un villageois
	Et le tour des villageois commence
	Lorsque Maria vote contre Ambroise
	Alors il n'y a pas de mort

@villageois
Scénario: liste des joueurs villageois devant voter le jour
	Soit Blondin un loup
	Et Johanna un loup
	Et Ambroise est un villageois
	Et Maria est la voyante 
	Lorsque le tour des villageois commence
	Alors les joueurs qui peuvent voter sont
	  | joueur   |
	  | Blondin  |
	  | Johanna  |
	  | Ambroise |
	  | Maria    |