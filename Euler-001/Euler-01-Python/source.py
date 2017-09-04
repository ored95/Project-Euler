n = int(input("Input number N: "))

def check_number(number):
    return (number % 3 == 0) or (number % 5 == 0)

sum = 0

for x in range(3, n):
    if check_number(x):
        sum += x

print("Total sum is", sum)
