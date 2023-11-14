from setuptools import setup, find_packages

with open("README.md", "r") as f:
    page_description = f.read()
    
with open("requirements.txt") as f:
    requirements = f.read().splitlines()
    
setup(
    name= "random_generator",
    version= "0.1.0",
    author= "Wanderson Gonçalves Moreira",
    author_email= "wgmbusinessintelligence@gmail.com",
    description="This package provides functions to generate random numbe",
    long_description=page_description,
    long_description_content_type="text/markdown",
    url="https://github.com/Wanderson-Goncalves/random_generator_package",
    packages= find_packages(),
    install_requires= requirements,
   
    python_requires = ">=3.11.4",
)