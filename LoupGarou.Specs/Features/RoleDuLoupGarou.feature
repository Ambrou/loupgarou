Fonctionnalité: Role du loup garou
	Dans le but de ne pas mourir de faim
	En tant que loup garou
	Je veux manger un villageois avec mes potes loups

Contexte: 
	Soit le jeu du loup garou

@loup_garou
Scénario: le loup garou agit
	Soit Blondin un loup
	Et Ambroise est un villageois
	Lorsque Blondin mange Ambroise
	Alors Ambroise est le prochain mort

@loup_garou
Scénario: les loups garous sont indécis
	Soit Blondin un loup
	Et Johanna un loup
	Et Ambroise est un villageois
	Et Maria est un villageois
	Lorsque Blondin mange Ambroise et Johanna mange Maria
	Alors il n'y a pas de mort

@loup_garou
Scénario: les loups garous sont presque indécis
	Soit Blondin un loup
	Et Johanna un loup
	Et Blondina un loup
	Et Ambroise est un villageois
	Et Maria est un villageois
	Lorsque Blondin mange Ambroise et Johanna mange Maria et Blondina mange Ambroise
	Alors Ambroise est le prochain mort