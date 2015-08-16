﻿Fonctionnalité: Peupler Le Village
	Dans le but de jouer avec des copains
	En tant que joueur
	Je veux créer un village

Contexte: 
	Soit le jeu du loup garou
	Et un maitre du jeu

@Village
Scénario: Création du village
	Soit 8 habitants sont attendus
	Et Il y a déjà 7 habitants dans le village
	Lorsque le 8em habitant arrive
	#Alors le village est crée
	Alors le maitre du jeu pose le decor

@Village
Scénario: Un habitant emménage dans le village
	Soit le migrant Ambroise
	Lorsqu'il emmenage dans le village
	Alors Ambroise est un habitant du village
	Et le maitre du jeu salut Ambroise

@Village
Scénario: Attribution des rôles aux habitants du village
	Soit un village simplifiée
	Et il est peuplé de 8 habitants
	Lorsque le village est crée
	Alors il y a dans le village:
	    | role       | quantité |
	    | voyante    | 1        |
	    | loup garou | 2        |
	    | villageois | 5        |