# PageProject
**PageProject** è un progetto nato per imparare il linguaggio **C#** applicato alle interfacce grafiche utilizzando il framework **WPF** e seguendo l'architettura **_MVVM_**.

**PageProject** è strutturato in due livelli di **difficoltà**, che abbiamo superato creando due interfacce diverse.

---
---


## Requisiti:
Per poter comprendere i seguenti programmi bisogna aver compreso i fondamentali del pattern **_MVVM_**.

MVVM sta per **_Model-View-ViewModel_**, è un modello che prevede la divisione di un programma dotato di interfaccia grafica in 3 elementi:
- **_Model_** : implementa la **_logica_** del programma, quindi definisce come vengono modellati gli **_input_** per ottenere gli **_output_**.
- **_ViewModel_** : collega il **_Model_** alla **_View_**, senza farli interfacciare direttamente, gestisce inoltre gli **_eventi_** che avvengono nella **_View_**.
- **_View_** : contiene i **_componenti grafici_** che l'utente finale può vedere e con i quali può interagire, non deve in nessun modo vedere i cambiamenti nel **_;Model_**, ma può solo esserci legata attraverso la **_ViewModel_**.


---
---

# Interfaccia Semplice
### Obiettivo:
Principalmente si vuole imparare ad utilizzare la tecnica del **_Binding_** tra 
variabili del **_Model_** e componenti grafici della **_View_**, seguendo il pattern **_MVVM_** (Model-View-ViewModel).

### Richiesta:
Creare un'interfaccia simile a un **_Log-In_**, composta da due zone:
- Zona **_UserName_**, nella quale il relativo textBox non è modificabile e accessibile, ma viene automaticamente popolato con il vero nome dell'utente corrente del sistema operativo.
- Zona **_Profile_**, con un textBox dedicato che rappresenta il nome di profilo scelto dall'utente durante l'esecuzione.

### Risultati:

Abbiamo capito le differenze tra i componenti del pattern MVVM e come effettuare il **_Binding_**

---
---

# Interfaccia Avanzata
### Obiettivo:
Si vuole imparare a **_replicare_** elementi grafici con riutilizzo del codice e **_ObservableCollection_**, inoltre si vuole implementare una logica di controllo che governi le selezioni dei componenti grafici.

### Richiesta:
Creare una finestra di **_introduzione_** che contenga un pulsante, tale pulsante se premuto deve generare e rendere visibile una nuova finestra.

Nella seconda finestra si gestiscono 4 ComboBox che contengono numeri da 0 a 9 compresi.



### Limitazioni:

Una ComboBox si ritiene **_Attiva_** se seleziona un numero diverso da **0**.

Le selezioni delle ComboBox devono rispettare la seguente logica:
- Le ComboBox in senso **_orizzontale_** sono indipendenti tra loro (Nessun Limite).
- ComboBox in senso **_verticale_** non possono essere entrambe attive.
- ComboBox in senso **_diagonale_** non possono essere entrambe attive.

Se si vuole attivare una ComboBox in verticale, con la corrispondente già attiva, bisogna prima disattivare quest'ultima ponendola a 0, altrimenti verrà disattivata in automatico.

Invece se si vuole attivare una ComboBox in diagonale, con la corrispondente già attiva, si otterrà una notifica di errore sulla colonna destra, ma non verranno modificate le selezioni.

Nel caso in cui si torni a rispettare la limitazione diagonale, deve essere disattivata la notifica di errore.

### Esempio:
| **Microwave-1** | **Microwave-2** |
| :------: | :------: |
| **Resistor-1** | **Resistor-2** |


In questo esempio **Microwave-1** e **Microwave-2** sono disposte in orizzontale, quindi non si influenzano reciprocamente e possono quindi essere entrambe attive, entrambe non attive oppure una attiva e l'altra non attiva.

**Microwave-1** e **Resistor-1** sono disposte in verticale, quindi se **Microwave-1** è attiva e seleziono un numero diverso da 0 in **Resistor-1**, **Microwave-1** tornerà a 0 e viceversa.

Se **Microwave-1** è attiva e attivo **Resistor-2**, o il contrario, non ci saranno cambiamenti di selezione, ma apparirà sulla colonna destra (**Resistor-2**) un errore. Ugualmente per **Microwave-2** e **Resistor-1**.

### Risultati:
Abbiamo ampliato la comprensione del concetto di **_Binding_**, ampliato le conoscenze in campo grafico (**_XAML_**) e l'utilizzo di **_ItemControl_** e **_DataTemplate_** per replicare i componenti grafici senza la **_riscrittura_** del codice.

Inoltre abbiamo imparato a gestire gli **_eventi_** generati nella **_View_**.

---
---

# Visualizzazione:

Se si vuole solamente dare un'occhiata al codice, ci si reca attraverso un **_browser_** a questo **_URL_**: 

```
https://github.com/AgoTech99/PageProject.git
```
In seguito attraverso l'interfaccia grafica si può accedere al progetto base o a quello avanzando, spostandosi rispettivamente in **_alessio-branch_** o **_alessio-branch2_**

# Installazione:

Per utilizzare questa **_repository_** bisogna avere installato **_GIT_**, e per fare ciò si può digitare nel **_prompt dei comandi_** o nel **_PowerShell_** il seguente comando:

``` js
winget install --id Git.Git -e --source winget
```

Completata l'installazione di **_GIT_** bisogna recarsi nella **_directory_** nella quale si vuole scaricare il codice, poi eseguire da linea di comando il seguente comando.

``` js
git clone "https://github.com/AgoTech99/PageProject.git" -b <branch>
```

Sostituendo **_branch_** con:
-  **_alessio-branch_** se si vuole il programma base.
- **_alessio-branch2_** se si vuole il programma avanzato.

In seguito si può utilizzare un editor di codice come **_Visual Studio_**, per eseguire questi programmi.


