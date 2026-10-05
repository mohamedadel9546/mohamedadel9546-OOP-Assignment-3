# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?
- Vilote (OCP) I have more than one case.
- What did you change?
Apply The Stratgey Pattern 
---

## OrderProcessor

- What was the problem?
- Violate (SRP)
- What did you change?
I worked evry class one reason and source to change    
---

## Notifications

- What was the problem?
- the Problem in the inhertiance this is lead to many of classes and tight coupling 
- [the solution] use the compostion over the inhertiance 
- What did you change?
implement the compostion and solution the problem of the inhertiance 
add the intrface : the Email and Sms class implement this interface and later add new channel class
implement this intrface lead to follow the (SRP,OCP).
---

## Proof

- New carrier file(s):
- add the Talapat carrier apply interface without mogdifcation on class
- New notification channel file(s):
- add the Telegram Channel withuot modifcation the class 
- Existing classes left unchanged? (yes/no):
- no
