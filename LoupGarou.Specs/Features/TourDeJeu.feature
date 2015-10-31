Fonctionnalité: Tour de jeu
	Dans le but de faire une partie compléte
	En tant que maitre du jeu
	Je veux gérer les différentes phase du jeu

Contexte: 
	Soit le jeu du loup garou
	Et un maitre du jeu
	#Et les habitants suivants:
	#| habitant | role       |
	#| un       | villageois |
	#| deux     | villageois |
	#| trois    | voyante    |
	#| quatre   | loup-garou |
	#| cinq     | villageois |
	#| six      | loup-garou |
	#| sept     | villageois |
	#| huit     | villageois |
#
#
#@Jeu @MaitreDuJeu @LoupGarou
#Scénario: Les loups garous mange une personne
#	Soit le tour des loups garous
#	Quand les loups garous ont choisit leur victime
#	Alors le maitre du jeu rendort les loups garous
#	Et le maitre du jeu réveille le village
#	Et il annonce le joueur mort ainsi que son rôle
#	Et c'est le tour des villageois
#	Et le joueur mort ne fait plus parti des habitants
#	
#@Jeu @MaitreDuJeu @Villageois
#Scénario: Les villageois désigne un coupable
#	Soit le tour des villageois
#	Quand les villageois ont choisi à la majorité leur coupable 
#	Alors le maitre du jeu annonce le joueur mort ainsi que son rôle
#	Et il rendort le village
#	Et c'est le tour de la voyante
#	Et le joueur mort ne fait plus parti des habitants
#
@Jeu @MaitreDuJeu @Voyante
Scénario: La voyante utilise son pouvoir de divination
	Soit le tour de la voyante
	Et il reste comme joueurs:
	| habitant | role       |
	| quatre   | loup-garou |
	| cinq     | villageois |
	| six      | voyante    |
	Quand la voyante utilise son pouvoir sur un habitant 
	Alors le maitre du jeu l'informe du rôle de l'habitant dans le village
	#Et il rendort la voyante
	#Et c'est le tour des loups garous
#	
#@Jeu @MaitreDuJeu @Victoire
#Scénario: Victoire des villageois
#	Soit le tour des villageois
#	Quand les villageois ont choisi à la majorité leur coupable le dernier loup
#	Alors le maitre du jeu annonce le joueur mort ainsi que son rôle
#	Et le joueur mort ne fait plus parti des habitants
#	Et les villageois ont gagné
#		
@Jeu @MaitreDuJeu @Victoire
Scénario: Victoire des loups garous
	Soit une partie en cours
	Et le tour des loups garous
	Et il reste comme joueurs:
	| habitant | role       |
	| quatre   | loup-garou |
	| cinq     | villageois |
	| six      | loup-garou |
	Quand les loups garous ont choisit le dernier villageois
	Alors le maitre du jeu rendort les loups garous
	Et le maitre du jeu réveille le village
	Et il annonce le joueur mort ainsi que son rôle
	Et les loup garous ont gagné
	Et le jeu est fini

@Jeu
Scénario: Description du début de phase d'un rôle
    Soit une partie en cours
	Lorsqu'un rôle devient actif
	Alors je reveille les joueurs correspondant au rôle 
	Et j'attends que les joueurs aient ciblé un autre joueur

@Jeu
Scénario: Description de la fin de phase d'un rôle
    Soit une partie en cours
	Lorsque tous les joueurs du rôle en cours ont désigné un autre joueur
	Alors je rendors les joueurs correspondant au rôle
	Et j'active le rôle suivant