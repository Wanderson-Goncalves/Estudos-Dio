

from ast import Not
import textwrap


def menu():
    print("\nMENU")
    print("[d]\tDepositar")
    print("[s]\tSacar")
    print("[e]\tExtrato")
    print("[na]\tNova Conta")
    print("[nu]\tNovo Usuário")
    print("[lc]\tListar Contas")
    print("[q]\tSair")
    return input("=> ")


def cadastrar_usuario(usuarios):
    cpf = input('Informe o Cpf:\t')
    usuario = filtrar_usuario(cpf, usuarios)
    if usuario:
        return print(f"Já existe este usuário.\t {usuario}")

    nome = input('Informe o Nome:\t')
    data_nascimento = input('Informe a data de nascimento (dd-mm-aaaa):\t')
    endereco = input(
        'Informe o enereço (logradouro, nº - bairro - cidade/sigla estado):\t')
    usuarios.append({
        'nome': nome,
        'cpf': cpf,
        'data_nascimento': data_nascimento,
        'endereco': endereco
    })
    print('\n\tUsuário criado com sucesso!')


def filtrar_usuario(cpf, usuarios):
    usuarios_filtrados = [
        usuario for usuario in usuarios if usuario['cpf'] == cpf]
    return usuarios_filtrados[0] if usuarios_filtrados else None


def depositar(saldo, valor, extrato, /):
    if valor > 0:
        saldo += valor
        extrato.append(f"Depósito:\tR$ {valor:.2f}")
        print("\nDepósito realizado com sucesso!    ")
        print(f"Saldo atual:\t R${saldo:.2f}    ")
    else:
        print("\n    Operação falhou! O valor informado é inválido.    ")

    return saldo, extrato


def sacar(*, saldo, valor, extrato, numero_saques):
    if valor > saldo:
        print("\n    Operação falhou! Você não tem saldo suficiente.    ")
    elif valor > 500:
        print("\n    Operação falhou! O valor do saque excede o limite de R$ 500.00. ")
    elif numero_saques >= 3:
        print("\n    Operação falhou! Você excedeu o limite de 3 saques diários.    ")
    else:
        saldo -= valor
        extrato.append(f"Saque:\t\tR$ {valor:.2f}")
        numero_saques += 1
        print("\n    Saque realizado com sucesso!    ")

    return saldo, extrato, numero_saques


def exibir_extrato(saldo, /, *, extrato):

    print("\n                EXTRATO                  ")
    if extrato:
        for movimento in extrato:
            print(movimento)
    else:
        print("Não foram realizadas movimentações.")
    print(f"\nSaldo:\t\tR$ {saldo:.2f}")
    print("\n\n")


def criar_conta(agencia, num_conta, usuarios):
    cpf = input("Informe o CPF do usuário:\n")
    usuario = filtrar_usuario(cpf, usuarios)

    if not usuario:
        print('\n Usuário não encontrado. Cadastar Novo Usuário')
        cadastrar_usuario(usuarios)

    else:
        print('\n Conta Criada com sucesso!')
        return {
            'agencia': agencia,
            'numero_conta': num_conta,
            'usuario': usuario
        }


def listar_conta(contas):
    for conta in contas:
        linha = f"""\
            Agênccia:\t{conta['agencia']}
            C/C:\t{conta['num_conta']}
            Titular:\t{conta['usuario']['nome']}
        """
        print("=" * 100)
        print(textwrap.dedent(linha))


def main():
    agencia = 1
    saldo = 0
    extrato = []
    usuarios = []
    contas = []
    numero_saques = 0
    num_conta = 1

    while True:
        opcao = menu()

        if opcao == "d":
            valor = float(input("Informe o valor do depósito: "))
            saldo, extrato = depositar(saldo, valor, extrato)

        elif opcao == "s":
            valor = float(input("Informe o valor do saque: "))
            saldo, extrato, numero_saques = sacar(
                saldo=saldo,
                valor=valor,
                extrato=extrato,
                numero_saques=numero_saques)

        elif opcao == "nu":
            cadastrar_usuario(usuarios)

        elif opcao == "e":
            exibir_extrato(saldo, extrato=extrato)

        elif opcao == "na":
            num_conta = len(contas) + 1
            conta = criar_conta(agencia, num_conta, usuarios)

            if conta:
                contas.append(conta)
                num_conta += 1

        elif opcao == "lc":
            listar_conta(contas)

        elif opcao == "q":
            break

        else:
            print("Operação inválida. Por favor, selecione novamente.")


if __name__ == "__main__":
    main()
