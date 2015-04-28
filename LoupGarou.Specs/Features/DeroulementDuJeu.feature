Fonctionnalité: Déroulement du jeu
	Dans le but de maintenir le bon déroulement d'une partie
	En tant que maitre du jeu robotisé
	Je veux gérer les organiser l'ordre des tours de jeu

@sorcière
Scénario: Déroulement du premier tour de jeu
Soit tous les personnages sont présents dans le jeu
Quand la partie se lance
Alors le premier tour de jeu se déroule dans cet ordre:
| ordre      |
| Voleur     |
| Cupidon    |
| Voyante    |
| Amoureux   |
| Loup Garou |
| Sorcière   |
| Villageois |

Scénario: Déroulement des autres tours de jeu
Soit tous les personnages sont présents dans le jeu
Quand le premier tour de jeu est fini
Alors les autres tours de jeu se déroule dans cet ordre:
| ordre      |
| Voyante    |
| Loup Garou |
| Sorcière   |
| Villageois |

Scénario: Déroulement d'un tour de jeu avec personnage mort ou absent du jeu
Soit le tour de jeu est le suivant:
| Personnage |
| Voyante    |
| Loup Garou |
| Sorcière   |
| Villageois |
Quand la Voyante meurt
Alors les autres tours de jeu se déroule dans cet ordre:
| ordre      |
| Loup Garou |
| Sorcière   |
| Villageois |

