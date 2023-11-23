# Análise de Dados sobre a COVID-19

Este é um notebook Jupyter (`.ipynb`) que contém uma análise exploratória de dados sobre a COVID-19 usando a linguagem de programação Python. O código aborda diversas etapas, desde a importação dos dados até a visualização de informações relevantes. O conjunto de dados utilizado está disponível em [https://github.com/neylsoncrepalde/projeto_eda_covid/blob/master/covid_19_data.csv](https://github.com/neylsoncrepalde/projeto_eda_covid/blob/master/covid_19_data.csv?raw=true).

## Pré-requisitos

- Certifique-se de ter as bibliotecas necessárias instaladas. Você pode instalá-las executando os seguintes comandos:

```bash
pip install pandas numpy plotly statsmodels pmdarima
pip install plotly_express==0.4.0
pip install prophet

```

### Importação de Bibliotecas e Dados

- Importação das bibliotecas necessárias.

- Leitura dos dados de um arquivo CSV disponível no GitHub.

### Exploração Inicial dos Dados

- Verificação dos tipos de dados de cada coluna.

- Correção dos nomes das colunas para um formato padronizado.

### Análise de Casos no Brasil

- Filtragem dos casos confirmados no Brasil.

- Visualização da evolução dos casos confirmados ao longo do tempo.

### Análise de Mortes no Brasil

- Visualização do número de mortes por COVID-19 no Brasil.

### Taxa de Crescimento

- Cálculo da taxa média de crescimento dos casos confirmados no Brasil.

- Visualização da taxa de crescimento diária.

### Decomposição de Séries Temporais

- Utilização da biblioteca statsmodels para decompor séries temporais de casos confirmados e novos casos.

### Previsões com ARIMA

- Utilização da biblioteca pmdarima para ajustar um modelo ARIMA aos casos confirmados no Brasil.

- Visualização das previsões para os próximos 15 dias.

### Previsões com Prophet

- Utilização da biblioteca prophet para realizar previsões de casos confirmados no Brasil.

### Comparação Internacional de Mortalidade

- Análise comparativa da mortalidade entre o Brasil e os cinco países/territórios com mais mortes.

### Visualização Gráfica

- Gráfico de barras horizontais comparando as mortes no Brasil com os cinco países/territórios com mais mortes.

## Como Executar o Notebook

Este notebook foi originalmente criado no ambiente Colaboratory. Para executá-lo, você pode abrir o [link original do Colab](https://colab.research.google.com/drive/1Q4znUmPJLbMwBJcsgLxTEwvknbhF9yGY?usp=drive_link).

Certifique-se de ter todas as bibliotecas necessárias instaladas (consulte os pré-requisitos).

_Execute cada célula do notebook em sequência para reproduzir a análise_.
