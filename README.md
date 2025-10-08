# Salut! 👋

Pentru tema asta, eu și Corina Busuioc ne-am jucat puțin cu Vuforia și am explorat câteva dintre tool-urile oferite.

## Setup-ul inițial

Am început prin a instala Vuforia, urmărind tutorialul din notițele de la laborator. După ce am reușit să-l configurăm, am creat un obiect **ARCamera** ca să înlocuim camera default din Unity.

## Image Targets și trackere

Am creat două obiecte de tip ImageTarget** și le-am asociat trackere diferite direct din Unity. Le-am ajustat și dimensiunile să se potrivească cu trackerele fizice pe care le aveam.

## Obiectele 3D

Pentru scene am folosit:
- Cactusul din suportul de laborator
- Un model 3D cu o pizza

## Animațiile și povestea

Partea de creativitate vine aici - în Animator am configurat cactusul cu tranziții între stările **idle → attack → dead** și invers. Ideea era să creăm impresia că cactusul miroase pizza, mănâncă din ea, și apoi se culcă că e plin. 

Am vrut să adăugăm un pic de creativitate prin storytelling, așa că am folosit un obiect **Text Mesh Pro** pentru a crea un "thought bubble". Povestea e simplă și drăguță:
- La început personajul e super foame
- Când se apropie de pizza, observă că miroase foarte bine
- Începe să mănânce cu poftă
- Pe măsură ce mănâncă, pizza se micșorează (am gestionat scala obiectului prin codul C# din scriptul `SprintRun`)

## Partea tehnică

Toate animațiile și mesajele sunt gestionate prin scripturi atașate camerei și obiectelor din scenă. Totul e automatizat și reacționează la detectarea trackerelor.

---

*Cam asta e tot - un mic proiect cu cactus flămând și pizza magică în realitate augmentată!* 🌵🍕
