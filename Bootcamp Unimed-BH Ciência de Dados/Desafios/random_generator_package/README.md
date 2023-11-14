# Random Generator Package

This package provides functions to generate random numbers and words.

## Installation

You can install the package using the following command:

```bash
pip install random_generator
```

---

## Usage

### Generate Random Numbers

```bash
import random_generator.raffle as raffle

# Specify the range and quantity of numbers
min_value = 1
max_value = 100
quantity = 5

# Generate a list of random numbers
numbers = raffle.generate_numbers(min_value, max_value, quantity)

print("Generated Numbers:", numbers)
```

### Genearate Random Words

```bash
import random_generator.raffle as raffle

# Specify the list of words and the number of words to generate
word_list = ["apple", "banana", "orange", "grape", "kiwi"]
word_count = 3

# Generate a list of random words
words = raffle.generate_words(word_list, word_count)

print("Generated Words:", words)
```

### Author

Wanderson Gonçalves Moreira

### License

**MIT**
