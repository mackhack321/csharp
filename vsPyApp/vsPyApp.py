try:
    num1 = int(input("Give a number: "))
    num2 = int(input("Give another number: "))
    sum = num1+num2
    print(f"The sum of {num1} and {num2} is {sum}.")
except ValueError:
    print("Bad input!")
