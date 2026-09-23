# Desarrollo-de-Aplicaciones-Moviles-II

Repositorio de proyectos y trabajos prácticos realizados durante la materia Desarrollo de Aplicaciones Móviles II



#### **# Proyecto 2 - Navegación**

\# Descripción: Proyecto .NET MAUI para practicar navegación con Shell, pestañas, menú lateral y rutas entre páginas. Esta versión corresponde a la estructura inicial que luego será refactorizada aplicando MVVM y navegación centralizada desde los ViewModels.



Proyecto desarrollado en .NET MAUI para practicar diferentes

formas de navegación mediante Shell.



\## Versión inicial



La primera versión utiliza:



\- Shell

\- Menú lateral

\- Pestañas

\- InicioPage

\- PerfilPage

\- AjustesPage

\- DetallePage



Esta versión funciona como punto de partida para una posterior

refactorización aplicando el patrón MVVM, navegación mediante

Shell.Current.GoToAsync(), paso de parámetros, validaciones y

notificaciones visuales.



#### **# Proyecto 2 - Refactorización**



Para realizar esta actividad se tomó como base la aplicación desarrollada anteriormente en la actividad de navegación. La versión original se conservó sin modificaciones y se creó una copia independiente llamada `Proyecto2Refactorizado`, permitiendo mantener ambas versiones y comparar la evolución del proyecto.



La versión original contaba con navegación mediante Shell, un menú lateral, pestañas para Inicio, Perfil y Ajustes, y una página secundaria `DetallePage` accesible mediante una ruta y un parámetro enviado por URI.



En la nueva versión se incorporó el patrón MVVM para reorganizar la navegación. Se creó la carpeta `ViewModels` y dentro de ella `InicioViewModel.cs`. La lógica que originalmente se encontraba en `InicioPage.xaml.cs` fue trasladada al ViewModel. El botón "Ver detalle" dejó de utilizar el evento `Clicked` y pasó a utilizar un `Command` mediante `Command="{Binding VerDetalleCommand}"`. De esta manera, la interfaz queda separada de la lógica de navegación.



La navegación se realiza mediante `Shell.Current.GoToAsync()` y continúa utilizando parámetros enviados mediante URI. El parámetro `id` se valida antes de realizar la navegación. En `DetallePage` se implementó `IQueryAttributable` para recibir el parámetro mediante `ApplyQueryAttributes()`, comprobar que exista y que sea válido antes de mostrarlo.



El flujo de navegación quedó organizado de la siguiente manera: el usuario presiona el botón de detalle, el comando del `InicioViewModel` procesa la acción, valida el identificador y utiliza `Shell.Current.GoToAsync()` para navegar hacia `DetallePage`. La página recibe el parámetro y lo muestra en la interfaz.



También se realizó un rediseño visual completo de la aplicación. Se reemplazó la apariencia predeterminada de .NET MAUI por una identidad basada en negro, blanco y rojo. Se utilizaron fondos blancos para el contenido, bloques negros para destacar información y rojo como color de acento para botones, numeraciones, indicadores y elementos de navegación. Las páginas de Inicio, Perfil y Ajustes fueron adaptadas para utilizar el mismo lenguaje visual, incorporando encabezados, tarjetas y bloques de información con mayor jerarquía y contraste. También se personalizó `AppShell.xaml` para utilizar una barra superior oscura y pestañas rojas, manteniendo coherencia visual en toda la aplicación.



Durante el proceso surgieron varios problemas técnicos. Al crear la copia del proyecto, algunas referencias continuaban utilizando el namespace `Proyecto2Navegacion`, lo que provocó errores de compilación e incompatibilidades entre los archivos XAML y sus respectivos archivos `.cs`. También aparecieron errores relacionados con `InitializeComponent()` y con la aplicación de Windows debido a diferencias entre los namespaces `Proyecto2Navegacion.WinUI` y `Proyecto2Refactorizado.WinUI`. Estos problemas se solucionaron actualizando los namespaces y las referencias correspondientes y regenerando los archivos de compilación.



Durante la implementación de la nueva navegación apareció además un conflicto relacionado con la propiedad `Id` y *`\[QueryProperty]`*, que provocaba una excepción de coincidencia ambigua. Para resolverlo se reemplazó ese mecanismo por *`IQueryAttributable*`, permitiendo recibir y validar los parámetros de navegación de forma más controlada.



En la etapa de diseño también surgieron errores relacionados con la utilización de recursos globales mediante `StaticResource` y `DynamicResource`, principalmente al intentar aplicar los nuevos colores desde `Colors.xaml` y `Styles.xaml`. Para evitar que estos cambios visuales afectaran el funcionamiento de la aplicación, se optó por definir los colores directamente en las interfaces principales y mantener la lógica de navegación independiente del diseño.



Finalmente, durante la personalización de `AppShell.xaml` se produjo un error de sintaxis XAML al colocar comentarios dentro de la declaración de la etiqueta `<Shell>`. Esto generó errores de compilación que fueron solucionados reorganizando los comentarios fuera de los atributos de la etiqueta.



Como resultado, se obtuvo una segunda versión funcional de la aplicación que conserva las características principales de la versión original, pero mejora la separación entre interfaz y lógica mediante **MVVM**, centraliza la navegación en el ViewModel, incorpora validación de parámetros y presenta una identidad visual propia. La versión original se mantiene como referencia dentro del mismo repositorio para permitir comparar el estado inicial con el resultado de la refactorización.



