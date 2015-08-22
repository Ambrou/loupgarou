Fonctionnalité: Tour de jeu
	Dans le but de faire une partie compléte
	En tant que maitre du jeu
	Je veux gérer les différentes phase du jeu

Contexte: 
	Soit le jeu du loup garou
	Et un maitre du jeu
	Et les habitants suivants:
	| habitant | role       |
	| un       | villageois |
	| deux     | villageois |
	| trois    | voyante    |
	| quatre   | loup-garou |
	| cinq     | villageois |
	| six      | loup-garou |
	| sept     | villageois |
	| huit     | villageois |


#@Jeu @MaitreDuJeu @Voyante
#Scénario: Réveil de la voyante
#	Soit la voyante est encore vivante
#	Quand la nuit tombe
#	Alors le maitre du jeu réveille la voyante
#	Et trois peut 

#@Jeu @MaitreDuJeu @LoupGarou
#Scénario: Réveil des loups garous
#	Soit le tour de la voyante
#	Quand la voyante a utilisé son pouvoir
#	Alors le maitre du jeu rendors la voyante
#	Et il réveille les loups garous

@Jeu @MaitreDuJeu @LoupGarou
Scénario: Les loups garous mange une personne
	Soit le tour des loups garous
	Quand les loups garous ont choisit leur victime
	Alors le maitre du jeu rendort les loups garous
	Et le maitre du jeu réveille le village
	Et il annonce le joueur mort ainsi que son rôle
	Et c'est le tour des villageois