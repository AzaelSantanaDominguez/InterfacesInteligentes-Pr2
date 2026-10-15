# InterfacesInteligentes-Pr2

## Ejercicio Físicas 3D

El ejercicio consiste en experimentar con diferentes configuraciones de los components Rigidbody y Collider y explicar los resultados obtenidos en base a lo explicado en clase. Para ello vamos a configurar una escena con 3 objetos:

**Plano**, **Cubo** y **Esfera**. El plano, y la cámara se ubican en las posiciones por defecto. El cubo se ubica con y=0.5. La esfera con el Transform en la imagen.

### Situación 1

- El **plano** no es un `objeto físico`.
- El **cubo** es un `objeto físico` y la **esfera** no.
- En este caso, el **plano** y la **esfera** sólo tendrán `collider`, mientras que el **cubo** debe tener `Rigidbody`. 

El ejercicio dice que el **cubo** es un objeto físico, por lo que es necesario añadirle un componente `Rigidbody`, mientras que la **esfera** y el **plano** no. El **plano** y la **esfera** solo tendrán `colliders`. 

Si cambiamos el transform de la **esfera** durante la ejecución para que choque con el **cubo** podemos ver que simplemente lo atraviesa, esto ocurre porque ni la **esfera** ni el **plano** tienen `RigidBody` por lo que no están
integrados en el motor de físicas de Unity y por tanto no pueden colisionar. Por otro lado, se puede ver que el **cubo** se mantiene sobre el **plano** ya que este tiene un `mesh collider` y el motor de físicas hace que el cubo se mantenga sobre él.

<img width="1918" height="1030" alt="St1" src="https://github.com/user-attachments/assets/7c54e26e-f2ac-4aca-a1a0-c16eee0cb530" />

### Situación 2

- El **plano** no es un `objeto físico`.
- El **cubo** es un `objeto físico` y la **esfera** también.
- En este caso, el **plano** sólo tendrán `collider`, mientras que el **cubo** y la **esfera** deben tener `Rigidbody`.

El ejercicio dice que tanto el **cubo** como la **esfera** son objetos físicos, por lo que es necesario añadirles el componente `RigidBody`, mientras que el **plano** no. El **plano** solo tendrá `colliders`.

En este caso, la **esfera** ahora está acoplada al sistema de físicas y el cubo también, además, ambos tienen `colliders` por lo que pueden detectar las colisiones. De hecho, en este caso, al ejecutar la escena a la **esfera** se le aplica una fuerza de gravedad
que hace que caiga sobre el **cubo**, ruede sobre él y termine cayendo al plano, que tambien tiene su `collider`, lo que hace que la **esfera** siga rodando sobre él. Además, el **cubo** se mantiene sobre el **plano**  por la misma situación que comentamos antes.

<img width="1918" height="1030" alt="St2" src="https://github.com/user-attachments/assets/0286b8d7-ac1e-460d-9ce4-4c8d26855eb9" />

### Situación 3

- El **plano** no es un `objeto físico`.
- El **cubo** es un `objeto físico` y la **esfera** es `cinemática`.
- En este caso, el **plano** sólo tendrán `collider`, mientras que el **cubo** y la **esfera** deben tener `Rigidbody` esta última cinemático.

El ejercicio es muy parecido al anterior pero en este caso, la **esfera** tendrá un `RigidBody` cinemático. La única diferencia es que la **esfera** no se moverá ya que es cinemático y hay que moverlo mediante algún script.

<img width="1918" height="1029" alt="St3" src="https://github.com/user-attachments/assets/f09a113c-351b-493f-85b1-ea707404f6b6" />

### Situación 4
- El plano es un objeto físico.
- El cubo es un objeto físico y la esfera es física.
- En este caso, todos los objetos deben tener Rigidbody.

En este caso, todos los componentes de la escena tiene rigidboy dinamico, por lo que se verán afectados por la gravedad y caeran todos fuera del rango visual del componente de nuestra camara.

<img width="1918" height="1028" alt="St4" src="https://github.com/user-attachments/assets/e2372b65-be3d-41c4-a7cc-591705ebac23" />

### Situación 5
- El plano es un objeto cinemático.
- El cubo es un objeto físico y la esfera es física con 10 veces más masa que el cubo.
- En este caso, todos los objetos deben tener Rigidbody.

En esta caso, el plano se mantendrá quieto ya que su rigidbody es cinematico, pero detecta la colision con el cubo y la esfera, por lo que el resultado es el mismo que la situacion 2, el cubo se mantien sobre el plano y la esfera cae sobre el cubo con mas fuerza y rueda por el plano hasta caer fuera de la escena.

<img width="1917" height="1030" alt="St5" src="https://github.com/user-attachments/assets/f8c51ef4-9336-4ad4-830a-65f614a139d2" />

### Situación 6
- El plano es un objeto cinemático.
- El cubo es un objeto físico y la esfera es física con 100 veces más masa que el cubo.
- En este caso, todos los objetos deben tener Rigidbody.

Esta situacion es la misma que el caso anterior pero aumentado la masa de la esfera aun mas, de forma que al caer, empuja al cubo hacia la izquierda y luego rueda lentamente sobre el plano.

<img width="1918" height="1029" alt="St6" src="https://github.com/user-attachments/assets/ecd7d763-17cc-4253-9024-07ededbec989" />

### Situación 7
- El plano es un objeto físico.
- El cubo es un objeto físico y la esfera es física con fricción.
- En este caso, todos los objetos deben tener Rigidbody.

En este caso, hemos añadido un physics material a la esfera añadiendole friccion al collider y haciendo que rebote más. El resultado es basicamente el mismo, la esfera cae sobre el cubo, pero esta vez se puede apreciar que bota un poco más.

<img width="1917" height="1031" alt="St7" src="https://github.com/user-attachments/assets/db501ee9-6914-435d-b745-6accc42570fb" />

### Situación 8
- El plano es un objeto cinemático.
- El cubo es un objeto físico y la esfera no es física y es Trigger.
- En este caso, todos los objetos deben tener Rigidbody.

El plano se mantiene quieto, mientras que el cubo cae y aterriza en sobre el plano. La esfera se mantiene en el aire y actúa como una zona de detección. Si el cubo la atraviesa, no rebotará contra ella ni quedará bloqueado.

<img width="1918" height="1026" alt="St8" src="https://github.com/user-attachments/assets/395adc93-54dc-49fe-858f-f699f5482dce" />

### Situación 9

- El plano es un objeto cinemático.
- El cubo es un objeto físico y la esfera es física y es Trigger.
- En este caso, todos los objetos deben tener Rigidbody.

Como en la mayoría de las situaciones anteriores, el plano permaneve quieto y el cubo reposa sobre el. En este caso la esfera atraviesa ambos ya que tiene IsTrigger activado en su collider, de forma que no produce colisiones físicas sólidas con los objetos que atraviesa, sino que permite detectar cuándo entran en su volumen.

<img width="1918" height="1020" alt="St9" src="https://github.com/user-attachments/assets/83d16e66-5110-4e93-b002-99e2a59f6bb2" />

### Ejercicio 1

Crea un personaje,controla su desplazamiento con las teclas WASD o las flechas, el movimiento debe realizarse usando un Rigidbody, pero manteniendo el control total.

Se ha creado un script asociado a un objeto de la escena que permite controlar su movimiento mediante las teclas **W, A, S y D**.

El funcionamiento es el siguiente:

- Se obtiene la referencia al componente `Rigidbody` del objeto mediante `GetComponent<Rigidbody>()`.
- Se utilizan dos variables para almacenar el movimiento horizontal y vertical.
- En cada frame, las variables de movimiento se inicializan a cero.
- Se comprueba si el usuario pulsa las teclas **W, A, S o D** para establecer la dirección del movimiento.
- Se crea un `Vector3` con los valores del movimiento horizontal y vertical, manteniendo el eje Y a cero.
- En `FixedUpdate()`, se utiliza `Rigidbody.MovePosition()` para desplazar el objeto según la dirección indicada y la velocidad establecida.
- La velocidad de movimiento se puede modificar desde el **Inspector de Unity** mediante la variable `speed`, cuyo valor inicial es de **5**.

### Conceptos utilizados

- `Rigidbody`
- `GetComponent<Rigidbody>()`
- `Vector3`
- `Input.GetKey()`
- `KeyCode.W`, `KeyCode.A`, `KeyCode.S` y `KeyCode.D`
- `Update()`
- `FixedUpdate()`
- `Rigidbody.MovePosition()`
- `Time.fixedDeltaTime`
- Variables públicas y privadas
- Inspector de Unity

### Prueba de ejecución

<img width="1916" height="1034" alt="Ej1" src="https://github.com/user-attachments/assets/04acb215-3c8d-489c-a5e4-1746a831625c" />

[Ver script de Ejercicio1](Scripts/ChangeColor.cs)

### Ejercicio 2

Crea varios cubos o esferas con Rigidbody dinámico. Muestra por consola el nombre del objeto con el que colisiona, y cámbiale su color al colisionar.

Se ha creado un script asociado a un objeto de la escena que permite cambiar aleatoriamente el color de otro objeto cuando entra en contacto con su zona de detección (*Trigger*).

El funcionamiento es el siguiente:

- Se utiliza el método `OnTriggerEnter()` para detectar cuándo otro objeto entra en el área de detección del objeto que contiene el script.
- Se obtiene el componente `Renderer` del objeto que ha entrado en el *Trigger* mediante `GetComponent<Renderer>()`.
- Se comprueba que el objeto tenga un componente `Renderer` para evitar errores.
- Si dispone de dicho componente, se modifica el color de su material.
- Se utiliza `Random.value` para generar valores aleatorios para los componentes **R, G y B**, obteniendo así un color aleatorio cada vez que se detecta la entrada de un objeto.

### Conceptos utilizados

- `OnTriggerEnter()`
- `Collider`
- `Renderer`
- `GetComponent<Renderer>()`
- `material.color`
- `Color`
- `Random.value`
- Condicional `if`
- Detección de colisiones mediante *Triggers*

### Prueba de ejecución

<img width="1917" height="1033" alt="Ej2" src="https://github.com/user-attachments/assets/f109e7af-06a5-4b87-b571-55968429f7d5" />

[Ver script de Ejercicio2](Scripts/ChangeColor.cs)

### Ejercicio 3

Crea una zona (por ejemplo, un cubo grande con Is Trigger = true). Al entrar, cambia el color del personaje o activa un efecto que cambie la luz. Al salir, revierte el cambio. Añade otra zona que aumente una variable daño.

Se han creado dos scripts para gestionar la interacción entre objetos mediante *Triggers*: uno permite cambiar temporalmente el color de un objeto al entrar en una zona de detección y restaurarlo al salir, mientras que el otro incrementa el daño de un objeto al entrar en contacto con dicha zona.

El funcionamiento es el siguiente:

- Se utiliza `OnTriggerEnter()` para detectar cuándo un objeto entra en el área de detección.
- Se obtiene el color original del objeto mediante su componente `Renderer` y se almacena en la variable `colorOriginal`.
- Se define el color verde mediante `Color.green` como color que se aplicará durante la interacción.
- Cuando el objeto entra en el *Trigger*, su material cambia al color verde.
- Se utiliza `OnTriggerExit()` para detectar cuándo el objeto sale del área de detección.
- Al salir, se restaura el color original que se había almacenado previamente.

### Conceptos utilizados

- `OnTriggerEnter()`
- `OnTriggerExit()`
- `Collider`
- `Renderer`
- `GetComponent<Renderer>()`
- `material.color`
- `Color`
- `Color.green`
- Variables privadas
- Detección de entrada y salida mediante *Triggers*

Se ha creado un segundo script que permite incrementar el valor del daño de un objeto al entrar en contacto con una zona de detección.

El funcionamiento es el siguiente:

- Se utiliza `OnTriggerEnter()` para detectar cuándo un objeto entra en el área de detección.
- Se obtiene el componente `Ej1` del objeto que ha entrado mediante `GetComponent<Ej1>()`.
- Se comprueba que el objeto tenga dicho componente para evitar errores.
- Si dispone de él, se incrementa su variable `daño` en **10 unidades**.
- Se utiliza `Debug.Log()` para mostrar en la consola de Unity el nuevo valor del daño.

### Conceptos utilizados

- `OnTriggerEnter()`
- `Collider`
- `GetComponent<Ej1>()`
- Condicional `if`
- Variables públicas
- Incremento de variables (`+=`)
- `Debug.Log()`
- Consola de Unity
- Detección de colisiones mediante *Triggers*

### Prueba de ejecución

<img width="1918" height="1029" alt="Ej3" src="https://github.com/user-attachments/assets/44959d80-06a2-42fe-b5ff-8ece273ba64b" />

[Ver script de Ejercicio3Color](Scripts/ChangeColor.cs)

[Ver script de Ejercicio3Daño](Scripts/ChangeColor.cs)

### Ejercicio 4

Crea tres tipos de objetos en capas distintas: jugador, enemigos, recolectables. Configura la Layer Collision Matrix (Project Settings > Physics). Haz que los enemigos solo colisionen con el jugador, y que los recolectables solo sean detectados por triggers.

Se ha realizado una configuración de las propiedades físicas de los objetos de la escena mediante el componente `Rigidbody` y los materiales físicos (*Physic Materials*).

El funcionamiento es el siguiente:

- Se han creado varios objetos con sus respectivos `Collider` para detectar las colisiones.
- Se ha añadido el componente `Rigidbody` a los objetos que necesitan participar en la simulación física.
- Se han configurado distintos materiales físicos para modificar el comportamiento de los objetos durante las colisiones.
- Se han ajustado propiedades como la fricción y el rebote para obtener diferentes reacciones.
- Se ha comprobado cómo estas propiedades afectan al movimiento y al comportamiento de los objetos al entrar en contacto con otras superficies.

### Conceptos utilizados

- `Rigidbody`
- `Collider`
- `Physic Material`
- Fricción estática (*Static Friction*)
- Fricción dinámica (*Dynamic Friction*)
- Rebote (*Bounciness*)
- Detección de colisiones
- Inspector de Unity

<img width="446" height="529" alt="ej4-1" src="https://github.com/user-attachments/assets/aa220026-af23-4666-a7c5-f81d70a97f3f" />

<img width="408" height="444" alt="ej4-2" src="https://github.com/user-attachments/assets/a1d55a3e-9f64-464e-9552-a91663ffb7d0" />

### Ejercicio 5

Crea una escena con distintos materiales físicos (resbaladizo, rugoso, rebote alto). Aplica distintos Physic Materials a objetos. Lanza los objetos con AddForce() al pulsar la tecla X y observa cómo cambian las reacciones.

Se ha creado un script asociado a un objeto con `Rigidbody` que permite lanzarlo en una dirección aleatoria al pulsar la tecla **X**, aplicando una variación en los tres ejes del espacio.

El funcionamiento es el siguiente:

- Se obtiene la referencia al componente `Rigidbody` del objeto mediante `GetComponent<Rigidbody>()`.
- Se utiliza la variable `speed`, cuyo valor inicial es de **100**, para controlar la intensidad del movimiento.
- Se comprueba en `Update()` si se está pulsando la tecla **X**. Si es así, se activa la variable `move`.
- En `FixedUpdate()`, se comprueba si la variable `move` está activada.
- Se genera un vector de movimiento aleatorio utilizando `Random.Range()` para los ejes X, Y y Z, con valores comprendidos entre **-10 y 10**.
- Se utiliza `Rigidbody.AddForce()` con `ForceMode.VelocityChange` para modificar la velocidad del objeto en la dirección generada.
- Se utiliza `Time.fixedDeltaTime` en el cálculo del vector aplicado.
- Después de aplicar el movimiento, la variable `move` vuelve a `false` para evitar que se repita continuamente mientras no se vuelva a pulsar la tecla.

### Conceptos utilizados

- `Rigidbody`
- `GetComponent<Rigidbody>()`
- `Vector3`
- `Input.GetKey()`
- `KeyCode.X`
- `Random.Range()`
- `Update()`
- `FixedUpdate()`
- `Rigidbody.AddForce()`
- `ForceMode.VelocityChange`
- `Time.fixedDeltaTime`
- Variables públicas y privadas
- Inspector de Unity

### Prueba de ejecución

<img width="1918" height="1032" alt="Ej5" src="https://github.com/user-attachments/assets/b7de5cac-dffa-4d11-9ced-d65c9a4750f1" />

[Ver script de Ejercicio5](Scripts/ChangeColor.cs)

### Ejercicio 6

En la escena debe haber 3 objetos que tengan Collider pero no Rigidbody. Un cubo, una esfera y un cilindro que deben estar alineados. Marcar el cilindro como objetivo a alcanzar por la esfera. El cubo debe hacer de obstáculo entre ambos. Implementar un script que haga que la esfera se dirija al cilindro, cuando la esfera alcance el cubo, este debe cambiar su material.

Se han creado dos scripts para implementar un sistema de movimiento y detección de contacto entre objetos sin utilizar `Rigidbody`.

Se ha creado un script asociado a la esfera que permite desplazarla automáticamente hacia un cilindro que actúa como objetivo.

El funcionamiento es el siguiente:

- Se obtiene la referencia al objeto objetivo mediante `GameObject.FindWithTag("endPos")`, utilizando la etiqueta `endPos`.
- Se establece una velocidad de movimiento de **5 unidades por segundo** mediante la variable `speed`.
- En `Update()`, se comprueba que el objetivo exista.
- Se utiliza `Vector3.MoveTowards()` para mover la esfera desde su posición actual hasta la posición del objetivo.
- Se utiliza `Time.deltaTime` para que el movimiento sea independiente de la tasa de frames.

### Conceptos utilizados

- `Transform`
- `GameObject.FindWithTag()`
- `Vector3.MoveTowards()`
- `Time.deltaTime`
- `Start()`
- `Update()`
- Movimiento mediante `Transform`
- Etiquetas (*Tags*)

Se ha creado un segundo script asociado al cubo que permite detectar cuándo la esfera entra en contacto con él y cambiar aleatoriamente su color.

El funcionamiento es el siguiente:

- Se obtiene la referencia a la esfera mediante `GameObject.FindWithTag("startPos")`, utilizando la etiqueta `startPos`.
- Se obtienen los componentes `Collider` del cubo y de la esfera mediante `GetComponent<Collider>()`.
- Se utiliza `Physics.ComputePenetration()` para comprobar si los colliders se solapan, sin necesidad de utilizar `Rigidbody`.
- Se utiliza la variable `tocando` para controlar si ya se estaba produciendo el contacto y evitar repetir el cambio de color mientras continúa el solapamiento.
- Cuando se detecta un nuevo contacto, se obtiene el componente `Renderer` de la esfera.
- Se modifica el color de la esfera utilizando `Random.value` para generar valores aleatorios para los componentes **R, G y B**.
- Finalmente, se actualiza la variable `tocando` para registrar el estado del contacto.

### Conceptos utilizados

- `Collider`
- `GetComponent<Collider>()`
- `Renderer`
- `GetComponent<Renderer>()`
- `Physics.ComputePenetration()`
- `Random.value`
- `Color`
- `GameObject.FindWithTag()`
- Condicionales `if`
- Variables booleanas
- Detección de solapamiento entre colliders

### Prueba de ejecución

<img width="1916" height="1036" alt="Ej6" src="https://github.com/user-attachments/assets/1231d6ed-922c-4f52-907d-323ba4dfe63c" />

[Ver script de Ejercicio6Esfera](Scripts/ChangeColor.cs)

[Ver script de Ejercicio6Cubo](Scripts/ChangeColor.cs)
