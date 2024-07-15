import os

def say_hello():
    return "Hello World! I'm a PYTHON SCRIPTTTT!"

def test(message):
    directory = os.getcwd()
    return message + ": " + directory