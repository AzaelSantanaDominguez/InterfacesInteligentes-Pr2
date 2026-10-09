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

### Situación 2

- El **plano** no es un `objeto físico`.
- El **cubo** es un `objeto físico` y la **esfera** también.
- En este caso, el **plano** sólo tendrán `collider`, mientras que el **cubo** y la **esfera** deben tener `Rigidbody`.

El ejercicio dice que tanto el **cubo** como la **esfera** son objetos físicos, por lo que es necesario añadirles el componente `RigidBody`, mientras que el **plano** no. El **plano** solo tendrá `colliders`.

En este caso, la **esfera** ahora está acoplada al sistema de físicas y el cubo también, además, ambos tienen `colliders` por lo que pueden detectar las colisiones. De hecho, en este caso, al ejecutar la escena a la **esfera** se le aplica una fuerza de gravedad
que hace que caiga sobre el **cubo**, ruede sobre él y termine cayendo al plano, que tambien tiene su `collider`, lo que hace que la **esfera** siga rodando sobre él. Además, el **cubo** se mantiene sobre el **plano**  por la misma situación que comentamos antes.

### Situación 3

- El **plano** no es un `objeto físico`.
- El **cubo** es un `objeto físico` y la **esfera** es `cinemática`.
- En este caso, el **plano** sólo tendrán `collider`, mientras que el **cubo** y la **esfera** deben tener `Rigidbody` esta última cinemático.

El ejercicio es muy parecido al anterior pero en este caso, la **esfera** tendrá un `RigidBody` cinemático.




