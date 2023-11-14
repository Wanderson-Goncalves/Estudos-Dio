import random

def generate_numbers(min, max, qty_of_numbers ):
    
    """
    Generates a list of random numbers within aspecified range.
    
    Args:
        min (int): The minimun value of the range.
        max (int): The maximum value of the range.
        qy_of_number (int): The quantity of numbers to be generated.

    Returns:
        list_of_numbers: A list of random numbers within the specified range.
    """
    list_of_numbers = random.sample(range(min, max), k=qty_of_numbers)
    return list_of_numbers



def generate_words(word_list, word_count):
    """
    Generates a list of random words from a provided list.

    Args:
        word_list (list): The list of words to be selected.
        word_count (int): The number of words to be generated.

    Returns:
        list_of_words: A list of randomly selected words from the provided list.
    """
    list_of_words = random.sample(word_list, word_count)
    return list_of_words

