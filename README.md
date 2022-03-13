# Scripting_Torres_PMDV
Grupo conformado por : Pietro Villano, Daniel Jaramillo, Manuel Velez, Victor Jimenez y Santiago Londoño.

Dificultades: No sabiamos la funcionalidad del tear down y se nos estaba creando una dependencia entre las pruebas. Tuvimos algunas complicaciones con el gitignore y haciendo commits ya que las carpetas se nos desordenaban.


Instrucciones de uso: 
Existen 2 clases (Jugador y Enemigo) el jugador tiene las siguientes variables: 

-BOOL JuegoGanado, este esta en false y se vuelve true a la hora de ganar el juego

-BOOL Vida, se convierte en false al perder sus 3 vidas

-INT NivelTorre, Este comienza con 3 y cada vez que derrota a todos los enemigos del piso de una torre se le añade un nivel

-DICCIONARIO TorreJugador, es un diccionario con llaves tipo string y valores tipo int en el que se guarda el jugador y los obstaculos en su propia torre (Bonificación)

*Variables clase Enemigo:

Las torres enemigas son un diccionario de tipo string y un arreglo, estas torres se guardan en un stack.

El jugador puede atacar a su propia torre y a las torres enemigas, estas torres enemigas se añaden de la forma mas facil a la mas dificil, y cuando este vence a todos los enemigos de un piso, el piso es removido del diccionario, y cuando vence a todos los pisos la torre es eliminada del stack y pasa a atacar a la siguiente torre, en caso de no quedar mas torres la variable JuegoGanado se vuelve true.

Si en un nivel hay mas de un enemigo el jugador los ataca en orden, necesitando atacar al primero para luego poder con el segundo y lo mismo para el tercero.

Pruebas Unitarias: Consideraciones: Realmente no hay cosideraciones, las pruebas pueden ser ejecutadas normalmente simplemente dando click derecho sobre la clase UnitTest1 y ejecutando las pruebas. En esta clase UnitTest1 de todas formas se encuentra comentada cada prueba.

Comentario: El metodo de la clase enemigo, LlenarStackTorres, genera unas torres iguales al video de referencia pero no es utilizado para las pruebas unitarias.
