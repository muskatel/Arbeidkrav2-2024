# Arbeidskrav 2 Example Solution

This is a sample sopltuion for the Arbeidskrav 2 (Emne 4 - 2024)

## Specifications

Your system must do the following:
### Spec-1
Given a JSON file (such as `items.json`), the system must read the data into memory as an appropriate object.

>Note: `items.json` will valid json. There is a sample provided but the final submission will be tested on unknown data.
### Spec-2
For each item the system must calculate the best **packing** option (based on raw weight and dimensions)
### Spec-3
For each item the system must calculate the best **postage** option using the new weight and dimension after packing.
### Spec-4
The system must create a summarised shopping list of items to purchase.

This must be displayed to the user, but also saved to a file that is easy to print.

(Output format is your choice, but I MUST be able to open it (pdf/word/txt/etc.))
### Spec-5
The system must have documented usage instructions (such as in README.md)

## Installation

Open the project in Rider.
Build and run it from there.

## Usage

The program will attempt to open `items.json` and will produce a shopping lsit called `shoppingList.txt`.

## Contributors

 - [Craig Marais](https://github.com/muskatel)

## License

[MIT](https://choosealicense.com/licenses/mit/)