# Proyecto-UF3-Arman-Dariush

## Justificación y motivación del proyecto

Hemos elegido desarrollar una web con información basica sobre los agentes de Valorant y los mapas del juego.
Para ello, hemos utilizado el endpoint de la API pública de Valorant: https://dash.valorant-api.com/, que nos proporciona acceso a los datos necesarios.

El proyecto nos ha parecido bastante interesante, sobre todo porque hemos tenido libertad para enfocarlo como quisiéramos. Está relacionado con un juego que mucha gente conoce, lo cual incrementa el interés y la motivación a la hora de desarrollarlo. También hemos podido probar distintas funcionalidades y juntar conocimientos que ya sabíamos como el uso de las clases, usar
el foreach para  iterar, con la finalidad de hacer la web. 

## Esquema arquitectura
<img src="https://github.com/Dariushzz/Projecte-UF3-Arman-Dariush/blob/main/esquema%20arquitectura.png" width="400"/>

## Explicación del código 
La aplicación sigue el patrón MVC (Modelo-Vista-Controlador).

Controlador: En HomeController, hacemos llamadas a la API de Valorant para obtener los agentes y los mapas. Por ejemplo, en Index() llamamos al endpoint de agentes, convertimos el JSON a un objeto y lo enviamos a la vista.

Modelo: Usamos clases como Root y Root2 para representar los datos que vienen de la API.

Vista: En Index.cshtml y Mapas.cshtml, usamos un foreach para mostrar los datos como el nombre e imagen de los agentes y mapas.


## Propuestas de mejora de la aplicación y nuevas funcionalidades 
Consideramos que la APIs están muy completa pero hay 2 cosas que nos hubiese gustado que estuviesen para poder añadirlas a la web:

### Fecha de lanzamiento de cada agente:
Es una propiedad que realmente si está en la API pero no está bien establecida. Esto sería útil para poder hacer una especie de cronología del orden de lanzamiento de los agentes.
![Image Alt](https://github.com/Dariushzz/Projecte-UF3-Arman-Dariush/blob/1afc8cfd9843b77d951275a5bc4cb627cd3a11c0/Captura1.jpg)

### Nacionalidad del Agente: 
Una propiedad donde únicamente indique el país del agente. Consideramos un error que no este ya que en la mayoría de descripciones de los agentes menciona de qué país proceden,
por ejemplo el personaje “Chamber” y “Skye” :

![Image Alt](https://github.com/Dariushzz/Projecte-UF3-Arman-Dariush/blob/20947e5bd846ed9210f49e861c3b9d3a5a56b300/Captura2.jpg)

### Eventos al hacer click a los Agentes:
Una funcionalidad útil para añadir a la web sería mostrar las habilidades de cada agente al hacer click sobre el.

