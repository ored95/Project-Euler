n = int(input("Input number N: "))

a0 = 1
a1 = 1
sum = 0

while a1 < n:
    a1 += a0
    a0 = a1 - a0

    if a0 % 2 == 0:
        sum += a0

print("Total sum is", sum)