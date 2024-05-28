# Introduzione
## Questi progetti sono stati creati per imparare le basi del pattern software MVVM utilizzando il lunguaggio c#.

## MVVM
MVVM è un protocollo che viene utilizzato per separare la parte logica dall'interfaccia utente, in particolare si suddivide in tre parti principali:

-**Model:** In questa cartella troveremo tutta la parte di inizializzazione delle variabili, situate in particolare nella classe denominata UserData.cs

-**VModel:** In questa cartella troveremo la classe UserViewModel, la quale ha il compito di separare la parte logica, con quella di visualizzazione

-**Views:** Rappresenta l'interfaccia che l'utente visualizzerà, in particolare sarà il file UserView.cs

### Progetto1
***descrizione:*** In questo progetto troveremo una prima pagina (MainWindows.xaml), nella quale è situato un bottone che una volta premuto ci reinderizzerà in un altra pagina.
La pagina aperta una volta cliccato il bottone, corrisponde al file nominato UserView.xaml,nella quale sarà possibile andare a modificare i dati del nome utente, ma non quelli del Profilo, perchè ci troveremo il nome del utente del computer.

***Obbiettivi***

Gli obbiettivi di questo progetto sono:

- Non permettere di modificare la parte del Profile

- Verficare che la parte dello User non sia vuota, nel caso segnalarlo



***struttura:***

-**Model:** Si è inizializzato la stringa Profile e quella User

-**VModel:** In particolare la classe UserViewModel permette di far visualizzare le varie variabili inizializzate nella parte sopra, al Views

-**Views:** La classe denominata Userview.xaml.cs si occupa di fare un collegamento utilizzando la proprietà Datacontext e inoltre di controllare se le specifiche richieste si verificano 

## Installazione


Se non installato, installare git dal seguente link:

[Git WebSite](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git)

**Clona Repository:**
Apri il terminale e clona il repository GitHub con al suo interno i progetti:

```git clone https://github.com/AgoTech99/PageProject.git -b federico-branch ```
  
**Navigare nella directory del progetto:** 
Dopo aver clonato puoi spostarti nella directory del progetto, lo potrai fare attraverso il comando ```cd```: 

```cd percorso/del/tuo/progetto```

**Utilizzando Visual Studio:**

1- Una volta aperto visual studio dovrai cliccare su "Clona la Repository"

2- Successivamente dovrai inserire la repository e inserire la path, ovvero il percorso nel quale si vorrà salvare il progetto

3- Infine dovrai Premere su "Apri una cartella" e selezionare quella indicata precedentemente nel punto 2



### Progetto2
***descrizione:***
In questo progetto troveremo una prima pagina con un bottone che se premuto ci porterà in un altra finestra. Questa finestra conterra 4 titoli e le loro 4 rispettive combobox, le quali conterranno dei numeri che potranno essere selezionati

***Obbiettivi***

Gli obbiettivi di questo progetto sono:

- Non permettere che tra i titoli M e R rispettivamente verticali tra di loro, ci siano due combo box con un numero diverso da 0

- Molto simile a quello precendente, ma con la differenza che se prima ci si riferiva alle combobox in verticale, adesso ci si riferisce anche a quelle in diagonale. Nel caso si verificasse avvisare con un immagine 

- Imparare ad utilizzare gli eventi

- Imparare ad utilizzare il binding



***struttura:***

-**Model:** Abbiamo una classe che servirà per inizializzare una classe di tipo enum. La seconda classe serve per inizializzare la varie variabili e per gestire le loro proprietà che serviranno poi al VModel

-**VModel:** Si occupa di istanziare le varie classi di tipologia enum. Inoltre esegue i vari controlli per le regole della parte diagonale

-**Views:** Permette di visualizzare la parte grafica del progetto, e di richiamare la funzione di controllo 

## Installazione


Se non installato, installare git dal seguente link:

[Git WebSite](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git)

**Clona Repository:**
Apri il terminale e clona il repository GitHub con al suo interno i progetti:

```git clone https://github.com/AgoTech99/PageProject.git -b federico-branch2 ```
  
**Navigare nella directory del progetto:** 
Dopo aver clonato puoi spostarti nella directory del progetto, lo potrai fare attraverso il comando ```cd```: 

```cd percorso/del/tuo/progetto```

**Utilizzando Visual Studio:**

1- Una volta aperto visual studio dovrai cliccare su "Clona la Repository"

2- Successivamente dovrai inserire la repository e inserire la path, ovvero il percorso nel quale si vorrà salvare il progetto

3- Infine dovrai Premere su "Apri una cartella" e selezionare quella indicata precedentemente nel punto 2