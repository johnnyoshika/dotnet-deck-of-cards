# .Net Developer Interview Exercises

## Setup
* Clone this repo

## C# Exercise
* Open `Deck_Should` unit tests
* Run all tests -> they should all fail
* Make tests pass one after the other, starting with the first test: `Generate_Cards_With_Numbers`

## JavaScript Exercise
* Run `Cards.Web` project
* Enter `16` into the `Number of Cards` textbox.
* Click `Load` and `Cut`. Notice that nothing changes. We'll fix this later.
* Request these GET URLS. You will use these URLs to fetch a list of cards later.
  ```
  https://localhost:44387/load
  https://localhost:44387/cut
  ```
* Open `Index.cshtml`
* Fix the submit event handler to fetch from `/load` and `/cut` and populate `[data-outlet]` with the newly fetched list of cards.