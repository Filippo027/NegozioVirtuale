#  Negozio Virtuale di Occhiali

##  Descrizione dell’app
Un'applicazione realizzata in **Unity** che simula un negozio virtuale di occhiali e accessori.  
Permette di:
- Visualizzare un **catalogo di prodotti** (occhiali e accessori).  
- Visualizzare i **dettagli** di ogni prodotto.  
- **Aggiungere articoli al carrello**, rimuoverli e visualizzarne il totale.  
- Gestire **utenti** con funzioni di login e registrazione.  

---

##  Tecnologie usate
- **Unity** (motore di gioco e interfaccia utente)  
- **C#** (logica applicativa)  
- **TextMeshPro** (gestione avanzata del testo)  
- **UI Canvas / Unity UI** (menu e pannelli interattivi)  
- **Git & GitHub** (versionamento del progetto)  

---

##  Classi principali e loro ruolo

| Classe              | Ruolo principale |
|---------------------|------------------|
| **Prodotto**        | Classe astratta base per prodotti del negozio (nome, prezzo, descrizione). |
| **Occhiale / Accessorio** | Estensioni di `Prodotto`, con attributi specifici (colore, materiale). |
| **IVisualizzabile** | Interfaccia che richiede implementazione del metodo `Visualizza()` o `MostraDettagli()`. |
| **Utente**          | Rappresenta l'utente con username e password, con validazione credenziali. |
| **GestoreUtenti**   | Singleton per registrazione e autenticazione utenti. |
| **GestoreProdotti** | Singleton che mantiene l'inventario, permette ricerca, ordinamento e cronologia. |
| **CatalogoController** | Gestisce la visualizzazione del catalogo, ricerca e ordinamento prodotti. |
| **DettagliController** | Mostra i dettagli del prodotto selezionato e gestisce il click su “Aggiungi al carrello”. |
| **Carrello**        | Mantiene la lista dei prodotti aggiunti e calcola il totale. |
| **CarrelloControllerUI** | Gestisce l’interfaccia del carrello: aggiunta, rimozione, aggiornamento UI. |
| **UIProdottoCarrello** | Script associato al prefab UI per visualizzare nome, prezzo e bottone *rimuovi*. |

---
1. LoginController
   - Fields: username (String), password (String), messageObject (String)

2. GenerateUsers
   - Fields: username (String), password (String)

3. Users
   - Fields: username (String), password (String)

4. GenerateProducts
   - Fields: productName (String), productCost (String)

5. Products
   - Fields: productName (String), productCost (String), description (String), category (String)

6. RealEstate
   - Fields: address (String)

7. Addresses
   - Fields: address (String), productName (String)

8. CartInfo
   - Fields: username (String), productName (String)

9. Checkout
   - Fields: username (String), address (String)

10. CatalogController
    - Fields: username (String), password (String), productName (String), productCost (String), attemptCheckout (String)

11. UIProductsController
    - Fields: username (String), password (String), productName (String), viewRealEstateButton (String)

12. UIProductsControllerUI
    - Fields: usernamePanel (String), passwordPanel (String), productNamePanel (String), productCostPanel (String), categoryPanel (String), productsComboBox (String), viewRealEstateButton (String)

13. CartInfoControllerUI
    - Fields: usernamePanel (String), productNamePanel (String), productsComboBox (String), attemptCheckoutButton (String)
