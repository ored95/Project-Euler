def palindrome(number):
    string = str(number)
    return string[0] == string[5] and \
           string[1] == string[4] and \
           string[2] == string[3]

def accept(number):
    key = 0
    i = 100
    while (i < 1000):
        if number % i == 0:
            key = int(number / i)
            if key < 1000:
                break
        i += 1
    return key

def find(number):
    if number > 998001:
        number = 998000

    key = 0
    while number > 100000:
        if palindrome(number):
            key = accept(number)
            if key > 0:
                break
        number -= 1


    if key > 0:
        print("\nResult: %d (%d x %d)\n" % (number, key, int(number/key)))
    else:
        print("\nResult: Not found!")

    return

find(int(input("Input number: ")))