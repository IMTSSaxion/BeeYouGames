EXTERNAL BossDamage(pDamage)

-> main

=== main ===
I am the boss and you will listen to me! #speaker:B #emotion:neutral
* Be nice bitch #speaker:A #emotion:neutral
    ->Damage
* You're a cunt #speaker:A #emotion:neutral
    ->Damage
    
=== Damage ===
I'm doing damage to you #speaker:A #emotion:neutral #xp:30
~BossDamage(20)
->END