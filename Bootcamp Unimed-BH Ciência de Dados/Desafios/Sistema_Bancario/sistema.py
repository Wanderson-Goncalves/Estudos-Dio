def menu():
    print("\nMENU")
    print("[d]\tDepositar")
    print("[s]\tSacar")
    print("[e]\tExtrato")
    print("[q]\tSair")
    return input("=> ")


def depositar(saldo, valor, extrato):
    if valor > 0:
        saldo += valor
        extrato.append(f"Depósito:\tR$ {valor:.2f}")
        print("\nDepósito realizado com sucesso!    ")
        print(f"Saldo atual:\t R${saldo:.2f}    ")
    else:
        print("\n    Operação falhou! O valor informado é inválido.    ")

    return saldo, extrato


def sacar(saldo, valor, extrato, numero_saques):
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


def exibir_extrato(saldo, extrato):
    print("\n                EXTRATO                  ")
    if extrato:
        for movimento in extrato:
            print(movimento)
    else:
        print("Não foram realizadas movimentações.")
    print(f"\nSaldo:\t\tR$ {saldo:.2f}")
    print("\n\n")


def main():
    saldo = 0
    extrato = []
    numero_saques = 0

    while True:
        opcao = menu()

        if opcao == "d":
            valor = float(input("Informe o valor do depósito: "))
            saldo, extrato = depositar(saldo, valor, extrato)

        elif opcao == "s":
            valor = float(input("Informe o valor do saque: "))
            saldo, extrato, numero_saques = sacar(
                saldo, valor, extrato, numero_saques)

        elif opcao == "e":
            exibir_extrato(saldo, extrato)

        elif opcao == "q":
            break

        else:
            print("Operação inválida. Por favor, selecione novamente.")


if __name__ == "__main__":
    main()
