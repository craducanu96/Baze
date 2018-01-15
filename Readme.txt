Readme-LinkedIN

Cristian Raducanu:
Am facut partea de interfata grafica, tot ce tine de legare intre formuri, salvarea continutului tastat/bifat in variabile sugestive
pentru a putea fi gasite mai usor de catre colegi.
Am scris toate variantele de alegere de la Skills, Data nasterii, Status, Nationality atat la client cat si la companie
Am facut partea cu export to .pdf, to .xlsx si to .csv.
Am intampinat probleme la denumirile butoanelor, labelurilor si formurilor din motive de intelegere pentru colegi, acestea trebuiau sa
fie cat mai sugestive si usor de gasit


Denisa Voica:
Am facut partea de Inregistrare a unui utilizator(client sau companie), introducand datele in baza de date in functie de ceea ce a
ales utilizatorul, fara a putea alege un username/email deja utilizat. Am verificat existenta unui username/email cu ajutorul functie 
"bool IfExistsUsername(..)"/"bool IfExistsEmail(string mail)". In cazul in care acesta deja exista in baza de date, vom avea un mesaj de eroare. 
Parola este salvata in baza de date intr-o forma criptata folosindu-ma de algoritmul din clasa "SecuraPasswordHasher". Daca parolele nu 
coincid sau daca utilizatorul nu completeaza toate campurile, apare un mesaj de eroare. De asemenea, parola trebuie sa indeplineasca anumite conditii: sa contina cel putin o litera mica, o litera mare si un caracter special, iar lungimea acesteia sa fie de minim 6 caractere.
Acestea sunt implementate in functia "bool Conditions(string password)". Se va afisa un mesaj de eroare daca acestea nu sunt indeplinite.
In cazul adresei de email, am verificat validitatea ei cu ajutorul functiei "bool ValidEmailAddress(..)". In caz contrar, apare un mesaj de
eroare pana cand introducem un format corect.
Numarul de telefon trebuie sa corespunda standardelor implementate in functia "bool IsPhoneNumber(string number)" cu ajutorul expresiilor regex.
Am intampinat probleme la adaugarea "Skill-urilor" in baza de date si am fost nevoita sa fac o cheie primara prin concatenarea a doua chei,
astfel incat un utilizator sa poata avea mai multe aptitudini(un id de client poate avea mai multe id-uri de aptitudini).
Am convertit data din formatul in care era salvata la inregistrare in DataTime pentru a o putea introduce in baza de date. Imaginea a fost 
convertita in binar la introducerea in baza de date.
Am realizat partea de Log in a utilizatorilor in functie de tipul lor (client sau companie) si afisarea pe ecran a datelor acestora pe care
le-am extras din baza de date. In cazul imaginii am convertit-o dintr-o insiruire de biti in image cu ajutorul functiei "Image ConvertByteToImage(byte[] photo)". Pentru recuperarea parolei, datele introduse de utilizator trebuie sa coincida cu cele din baza de date pentru
a o putea schimba.
Am realizat verificarea username-ului si a parolei la logare, afisand mesaj de eroare in cazul in care acestea erau incorecte sau inexistente,
folosindu-ma de functiile bool IfCompany(string user, string pass) si bool IfClient(string user, string pass).
Baza de date a fost realizata si completata de mine si colega mea Mihaela Cioanca.


Mihaela Cioanca:
Am realizat cautarea in baza de date a clientilor in functie de numele acestora afisand datele despre acestia intr-un DataGridView atunci cand
este apasat butonul Search. Compania poate cauta numai clienti, iar clientii pot cauta atat companii cat si alti clienti.
In cazul in care un client cauta un alt client, acesta poate sa ii trimita "Add friend" sau "Block" apasand butonul SendRelation,Rating, avand 
de ales o nota intre 1-5, apasand butonul SendRating si/sau un mesaj, apasand butonul SendMessage. Id-ul clientului care a realizat eventimentul, 
cel al clientului implicat, precum si tipul cererii, ratingul si mesajul sunt salvate in baza de date, in tabelele corespunzatoare. 
In cazul in care un client cauta o companie, acesta ii poate trimite un mesaj companiei.
La logare, clientului ii va aparea pe ecran Ratingul pe care il are (media aritmetica a notelor pe care le-a primit; daca nu a primit nici o nota,
Ratingul este 0).
Atunci cand un utilizator se logheaza, am realizat cautarea acestuia in baza de date si i-am salvat id-ul intr-o variabila,aceasta fiindu-mi utila 
pentru trimiterea cererilor de prietenie, a ratingului si a mesajelor in baza de date.
In cazul in care o companie cauta un client, aceasta poate sa ii trimita un mesaj clientului si sa vada cat % din aptitudinile pe care le 
cauta, se regasesc la client. Match-ul este realizat comparand stringurile cu aptitudinile companiei si ale clientului(aptitudini comune/aptitudini
cautate de companie). 
Am intampinat erori la introducerea ratingului, a cererilor si a mesajelor in baza de date deoarece acestea nu aveau setata o cheie primara,
de aceea am adaugat cate un id-cheie primara in cele trei tabele.
Dat fiind faptul ca atat un client cat si o companie pot cauta un client, iar actiunile pe care le pot realiza sunt diferite si unele butoane 
ascunse, am afisat formul corespunzator in functie de tipul utilizatorului logat.


Iulian Calinciuc:
Am realizat partea de mesagerie dintre Client-Companie, Companie-Client, Client-Client. Am mai realizat afisarea cererilor de
prietenie intr un datagridview la logarea unui client la apasarea iconitet pentru notificari si am introdus mecanismul cu exceptii.
Pentru trimiterea mesajelor m am folosit de proceduri stocate care ma ajutau sa identific ID-ul dupa nume(sau user) si invers.
Am intampinat dificultati la scrierea datelor din baza de date in datagridview si la trimiterea mesajelor deoarece mesajele de la clienti
si de la companii sunt afisate in acelasi form si trebuiau tratati diferit.
