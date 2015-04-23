Fonctionnalité: Rôle de la Sorcière
	Dans le but protéger le village
	En tant que sorcière
	Je veux utiliser mes potions pour empoisonner ou sauver une personne qui vient d'être dévorer

@sorcière
Scénario: Présentation de la sorcière
	Soit la joueuse Johanna
	Lorsque le personnage de la sorcière est attribué à Johanna
	Alors Johanna est une villageoise
	Et Johanna est la sorcière

@sorcière
Scénario: Début du tour de la sorcière
	Soit Johanna jouant la sorcière
	Lorsque les loups ont mangé leur victime
	Alors le maître du jeu appelle la sorcière
	Et son tour commence

@sorcière
Scénario: Fin du tour de la sorcière
	Soit Johanna jouant la sorcière
	Et son tour est en cours
	Lorsque qu'elle valide l'utilisation de ses potions
	Alors le maître du jeu rendort la sorcière
	Et son tour se termine
	
@sorcière
Scénario: tour de la sorcière
	Soit Johanna jouant la sorcière
	Et la victime des loups est le joueur Ambroise
	Lorsque son tour est en cours
	Alors elle découvre que la victime est Ambroise

@sorcière
Scénario: utilisation de la potion de vie
	Soit Johanna jouant la sorcière
	Et la victime des loups est le joueur Ambroise
	Lorsque qu'elle utilise sa potion de vie
	Alors Ambroise n'est pas mort au prochain levé du soleil
	Et la sorcière n'a plus de potion de mort

@sorcière
Scénario: utilisation de la potion de mort
	Soit Johanna jouant la sorcière
	Et Ambroise un joueur encore en vie
	Lorsque qu'elle utilise sa potion de mort sur Ambroise
	Alors Ambroise est mort au prochain levé du soleil
	Et la sorcière n'a plus de potion de mort